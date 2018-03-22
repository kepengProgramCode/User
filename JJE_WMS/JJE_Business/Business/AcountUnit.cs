using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JJE_Business.Access;
using JJE_WMS_Entity;
using System.Data;
using System.Data.Common;

namespace JJE_Business.Business
{
    public class AcountUnit
    {
        private static User loginUser;

        public enum LoginResult
        {
            // 成功
            Success = 0,
            // 失败
            ValidateError = 1,
            // 网络故障
            NetError = 2
        }



        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="user"></param>
        public int CreatAcount(User user)
        {
            int num = 0;
            using (StoreAccess access = new StoreAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();
                    num = access.Insert<User>(user);
                    access.Commit();
                }
                catch (Exception ex)
                {
                    access.RollBack();
                    access.Close();
                }
            }
            return num;
        }

        /// <summary>
        /// 加载主界面数据
        /// </summary>
        /// <returns></returns>
        public DataTable LoadUserAcount()
        {
            using (StoreAccess access = new StoreAccess())
            {
                return access.ToDataTable<User>(access.Select<User>());
            }
        }

        /// <summary>
        /// 获得账户信息
        /// </summary>
        /// <param name="userAcount"></param>
        /// <returns></returns>
        public List<User> GetUserForAcount(object userAcount)
        {
            using (StoreAccess access = new StoreAccess())
            {
                string strSQL = access.CommandFormate("SELECT [Name],[Remark],[Access] FROM [Table_User] WHERE Id = {0}Id");
                return access.ExcuteSelect<User>(strSQL, parameter =>
                 {
                     parameter.Add(parameter.CreateParameter("Id", Convert.ToInt32(userAcount)));
                 });
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int ResizeAcount(User user)
        {
            int num = 0;
            using (StoreAccess access = new StoreAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();
                    num = access.Update<User>(user);
                    access.Commit();
                }
                catch (Exception ex)
                {
                    access.RollBack();
                    access.Close();
                }
            }
            return num;
        }


        /// <summary>
        /// 删除用户怇
        /// </summary>
        /// <param name="acount"></param>
        /// <param name="type">1：条件删除 2：全部删除</param>
        /// <returns></returns>
        public int DeleteAcount(object acount, int type)
        {
            int num = 0;
            string sql = string.Empty;
            if (type == 1)
            {
                sql = string.Format("DELETE FROM [Table_User] WHERE [Id] = {0}", acount);
            }
            else
            {
                sql = "DELETE FROM [Table_User]";
            }
            using (StoreAccess access = new StoreAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();
                    num = access.Delete(sql);
                    access.Commit();
                }
                catch (Exception ex)
                {
                    access.RollBack();
                    access.Close();
                }
            }
            return num;
        }

        public static LoginResult Login(string account, string password, out User loginUser)
        {
            loginUser = null;
            using (StoreAccess access = new StoreAccess())
            {
                try
                {
                    User user = access.Login(account, password);
                    if (user == null)
                    {
                        return LoginResult.ValidateError;
                    }
                    else
                    {
                        loginUser = user;
                        return LoginResult.Success;
                    }
                }
                catch (DbException err)
                {
                    return LoginResult.NetError;
                }
                finally
                {
                    access.Close();
                }
            }
        }
    }
}
