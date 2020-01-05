using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hnt.Business.Access;
using Hnt.PlcListener.Entity;

namespace Hnt.Business
{
    class CreateTableBusiness
    {
        public static void CreateTable(string prefixTable)
        {
            using (BaseAccess access = new BaseAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();
                    //创建缓存托盘表                        
                    access.ExecuteNonQuery(GetCacheStackTraySql(prefixTable));
                    //创建托盘详情表                        
                    access.ExecuteNonQuery(GetStackTrayFlowSql(prefixTable));
                    //创建托盘表                        
                    access.ExecuteNonQuery(GetStackTraysSql(prefixTable));
                    //创建注册托盘表                        
                    //access.ExecuteNonQuery(GetRegisterTraySql(prefixTable));
                    //创建用户事件日志表                        
                    access.ExecuteNonQuery(GetUserEventLogSql(prefixTable));
                    access.Commit();
                }
                catch (Exception ex)
                {
                    access.Rollback();
                    throw new Exception("创建表失败：" + ex.Message);
                }
                finally
                {
                    access.Close();
                }
            }
        }

        /// <summary>
        /// 生成创建缓存托盘表语句
        /// </summary>
        /// <param name="prefixTable"></param>
        /// <returns></returns>
        private static string GetCacheStackTraySql(string prefixTable)
        {
            string tableName = prefixTable + "CacheStackTray";
            string insertsql = string.Format("IF OBJECT_id(N'{0}',N'U') IS NULL ", tableName);
            insertsql += string.Format("BEGIN CREATE TABLE {0} (", tableName);
            insertsql += "Id BIGINT IDENTITY(1,1) PRIMARY KEY,";
            insertsql += "Barcode NVARCHAR(50),";
            insertsql += "Batch NVARCHAR(50),";
            insertsql += "UpdateTime DATETIME,";
            insertsql += "Flag INT,";
            insertsql += "InStack INT) END ";
            return insertsql;
        }

        /// <summary>
        /// 生成创建托盘详情表语句
        /// </summary>
        /// <param name="prefixTable"></param>
        /// <returns></returns>
        private static string GetStackTrayFlowSql(string prefixTable)
        {
            string tableName = prefixTable + "StackTrayFlow";
            string insertsql = string.Format("IF OBJECT_id(N'{0}',N'U') IS NULL ", tableName);
            insertsql += string.Format("BEGIN CREATE TABLE {0} (", tableName);
            insertsql += "Id BIGINT IDENTITY(1,1) PRIMARY KEY,";
            insertsql += "Barcode NVARCHAR(50),";
            insertsql += "Batch NVARCHAR(50),";
            insertsql += "UpdateTime DATETIME,";
            insertsql += "Used INT) END ";
            return insertsql;
        }

        /// <summary>
        /// 生成创建托盘表语句
        /// </summary>
        /// <param name="prefixTable"></param>
        /// <returns></returns>
        private static string GetStackTraysSql(string prefixTable)
        {
            string tableName = prefixTable + "StackTrays";
            string insertsql = string.Format("IF OBJECT_id(N'{0}',N'U') IS NULL ", tableName);
            insertsql += string.Format("BEGIN CREATE TABLE {0} (", tableName);
            insertsql += "Id BIGINT IDENTITY(1,1) PRIMARY KEY,";
            insertsql += "TraysId BIGINT,";
            insertsql += "Barcode NVARCHAR(50),";
            insertsql += "Batch NVARCHAR(50),";
            insertsql += "TrayIndex INT,";
            insertsql += "UpdateTime DATETIME) END ";
            return insertsql;
        }

        /// <summary>
        /// 生成创建注册托盘表语句
        /// </summary>
        /// <param name="prefixTable"></param>
        /// <returns></returns>
        private static string GetRegisterTraySql(string prefixTable)
        {
            string tableName = prefixTable + "RegisterTray";
            string insertsql = string.Format("IF OBJECT_id(N'{0}',N'U') IS NULL ", tableName);
            insertsql += string.Format("BEGIN CREATE TABLE {0} (", tableName);
            insertsql += "Id BIGINT IDENTITY(1,1) PRIMARY KEY,";
            insertsql += "Barcode NVARCHAR(50),";
            insertsql += "Batch NVARCHAR(50),";
            insertsql += "Position INT,";
            insertsql += "DeviceNumber INT,";
            insertsql += "EntryNumber INT,";
            insertsql += "UpdateTime DATETIME) END ";
            return insertsql;
        }

        /// <summary>
        /// 生成创建用户事件日志表语句
        /// </summary>
        /// <param name="prefixTable"></param>
        /// <returns></returns>
        private static string GetUserEventLogSql(string prefixTable)
        {
            string tableName = prefixTable + "UserEventLog";
            string insertsql = string.Format("IF OBJECT_id(N'{0}',N'U') IS NULL ", tableName);
            insertsql += string.Format("BEGIN CREATE TABLE {0} (", tableName);
            insertsql += "Id BIGINT IDENTITY(1,1) PRIMARY KEY,";
            insertsql += "Account NVARCHAR(50),";
            insertsql += "HandleEvent NVARCHAR(500),";
            insertsql += "EventTime DATETIME DEFAULT(getdate())) END ";
            return insertsql;
        }

    }
}
