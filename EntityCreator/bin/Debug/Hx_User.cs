/*
*作者：
*创建时间：2020/1/5 11:36:00 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace fff
{
    [Table("Hx_User")]
    [Column(new string[]{"Id"},"LoginName","UserName","UserSex","UserPostion","UserTel","Password","RoleType","LastLoginTime","Del_Sign","AddUser","AddTime","UpdateUser")]
    /// <summary>
    /// 
    /// </summary>
    public class Hx_User:EntityBase
    {
       public const string ID = "Id";
       public const string LOGINNAME = "LoginName";
       public const string USERNAME = "UserName";
       public const string USERSEX = "UserSex";
       public const string USERPOSTION = "UserPostion";
       public const string USERTEL = "UserTel";
       public const string PASSWORD = "Password";
       public const string ROLETYPE = "RoleType";
       public const string LASTLOGINTIME = "LastLoginTime";
       public const string DEL_SIGN = "Del_Sign";
       public const string ADDUSER = "AddUser";
       public const string ADDTIME = "AddTime";
       public const string UPDATEUSER = "UpdateUser";

       private string id;
       /// <summary>
       /// 
       /// </summary>
       public string Id
       {
         get { return id; }
         set { id = value; }
       }

       private string loginName;
       /// <summary>
       /// 
       /// </summary>
       public string LoginName
       {
         get { return loginName; }
         set { loginName = value; }
       }

       private string userName;
       /// <summary>
       /// 
       /// </summary>
       public string UserName
       {
         get { return userName; }
         set { userName = value; }
       }

       private string userSex;
       /// <summary>
       /// 
       /// </summary>
       public string UserSex
       {
         get { return userSex; }
         set { userSex = value; }
       }

       private string userPostion;
       /// <summary>
       /// 
       /// </summary>
       public string UserPostion
       {
         get { return userPostion; }
         set { userPostion = value; }
       }

       private string userTel;
       /// <summary>
       /// 
       /// </summary>
       public string UserTel
       {
         get { return userTel; }
         set { userTel = value; }
       }

       private string password;
       /// <summary>
       /// 
       /// </summary>
       public string Password
       {
         get { return password; }
         set { password = value; }
       }

       private string roleType;
       /// <summary>
       /// 
       /// </summary>
       public string RoleType
       {
         get { return roleType; }
         set { roleType = value; }
       }

       private DateTime lastLoginTime;
       /// <summary>
       /// 
       /// </summary>
       public DateTime LastLoginTime
       {
         get { return lastLoginTime; }
         set { lastLoginTime = value; }
       }

       private string del_Sign;
       /// <summary>
       /// 
       /// </summary>
       public string Del_Sign
       {
         get { return del_Sign; }
         set { del_Sign = value; }
       }

       private string addUser;
       /// <summary>
       /// 
       /// </summary>
       public string AddUser
       {
         get { return addUser; }
         set { addUser = value; }
       }

       private DateTime addTime;
       /// <summary>
       /// 
       /// </summary>
       public DateTime AddTime
       {
         get { return addTime; }
         set { addTime = value; }
       }

       private string updateUser;
       /// <summary>
       /// 
       /// </summary>
       public string UpdateUser
       {
         get { return updateUser; }
         set { updateUser = value; }
       }

    }
}
