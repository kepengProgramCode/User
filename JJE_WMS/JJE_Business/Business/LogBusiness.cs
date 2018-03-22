using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JJE_WMS_Entity;
using JJE_Business.Access;
using System.Data.Common;


namespace JJE_Business.Business
{
    public class LogBusiness
    {
        /// <summary>
        /// 必须按照格式【什么人，干什么事，什么类型】
        /// </summary>
        /// <param name="log"></param>
        public static void RecordLog(string logs1, string logs2, string logs3)
        {
            using (StoreAccess access = new StoreAccess(true))
            {
                try
                {
                    string strSQL = access.CommandFormate("INSERT INTO [Table_Log] ([Logtime] ,[LogUser],[Remark],[Type]) VALUES ({0}Logtime,{0}LogUser,{0}Remark,{0}Type)");
                    access.Open();
                    access.BeginTransaction();
                    access.Insert(strSQL, parmater =>
                    {
                        parmater.Add(parmater.CreateParameter("Logtime", DateTime.Now));
                        parmater.Add(parmater.CreateParameter("LogUser", logs1));
                        parmater.Add(parmater.CreateParameter("Remark", logs2));
                        parmater.Add(parmater.CreateParameter("Type", logs3));
                    });
                    access.Commit();
                }
                catch (DbException db)
                {
                    access.RollBack();
                    access.Close();
                }
            }
        }
    }
}
