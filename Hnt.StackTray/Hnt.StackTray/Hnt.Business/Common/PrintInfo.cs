using Hnt.Business.Access;
using Snt.Framework.Logs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hnt.Entity;
using Snt.Framework.SqlCondition;

namespace Hnt.Business
{
    public class PrintInfo
    {
        /// <summary>
        /// 分割线
        /// </summary>
        public static void DottedLine()
        {
            // 50个
            I("--------------------------------------------------");
        }
        public static void I(string str)
        {
            Log.Info(str);
            string info = string.Format("{0}\t{1}", DateTime.Now.ToString("yyyy-MM-dd   HH:mm:ss:fff"), str);
            RecordUserLog(info);
            Console.WriteLine(info);
        }
        public static void I(string str, params object[] para)
        {
            string temp = string.Format(str, para);
            Log.Info(temp);
            RecordUserLog(temp);
            Console.WriteLine(string.Format("{0}\t{1}", DateTime.Now.ToString("yyyy-MM-dd   HH:mm:ss:fff"), temp));
        }
        public static void AddrWrite(string addr, string value, bool success)
        {
            I("地址{0}写入{1},success:{2}", addr, value, success);
        }
        public static void AddrRead(string addr, string value, bool success)
        {
            I("地址{0}读取{1},success:{2}", addr, value, success);
        }

        static string tableName = ConfigurationManager.AppSettings["prefixTable"] + "UserEventLog";
        private static void RecordUserLog(string message)
        {
            string unKnownUser = "unKnownUser";
            using (BaseAccess access = new BaseAccess())
            {
                try
                {
                    string strSQL = string.Format("INSERT INTO [{0}] ([Account],[HandleEvent]) VALUES('{1}','{2}')",tableName, unKnownUser, message);
                    access.ExecuteNonQuery(strSQL);
                }
                catch (System.Data.Common.DbException ex)
                {
                    Log.Error(ex.StackTrace);
                }
            }
        }
        public static List<UserEventLog> SelectEventLog()
        {
            using (BaseAccess access = new BaseAccess())
            {
                try
                {
                    //BaseCondition condition = new Column(UserEventLog.EVENT_TIME).MoreThan(DateTime.Now.AddDays(-1));
                    List<UserEventLog> userEventLogList = access.ExecuteSelect<UserEventLog>(string.Format("SELECT * FROM {0} WHERE EventTime > '{1}'", tableName, DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss")));
                    return userEventLogList;
                }
                catch (System.Data.Common.DbException ex)
                {
                    Log.Error(ex.StackTrace);
                    return null;
                }
            }
        }
    }
}
