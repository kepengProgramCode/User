using System;
using System.Collections.Generic;
using Hnt.Business.DataControl;
using Hnt.Entity;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;
using Hnt.Business;
using Hnt.Business.Access;
using System.Threading;

namespace Hnt.StackTray
{
    public class BatchBusiness : BusinessControl
    {
        public string connectionObject;

        string prefixTable = ConfigurationManager.AppSettings["prefixTable"];

        public BatchBusiness(string connectionObject)
        {
            this.connectionObject = connectionObject;
        }
        public override string GetTrayBatch(string trayCode)
        {
            return "B";
            List<MES_DCM_INJECT> _trayList = new List<MES_DCM_INJECT>();
            string connectionString = ConfigurationManager.AppSettings[connectionObject];
            string strSQL = string.Format("SELECT  BATCH_ID,TRAY_NO ,LABEL FROM MES_DCM_INJECT WHERE TRAY_NO='{0}' AND LABEL=1 ORDER BY TIME_CREATE DESC ", trayCode);
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {

                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(strSQL, connection);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader(CommandBehavior.Default);
                    while (reader.HasRows && reader.Read())
                    {
                        MES_DCM_INJECT data = new MES_DCM_INJECT();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    {
                                        data.BATCH_ID = reader.GetValue(i).ToString();
                                        break;
                                    }
                                case 1:
                                    {
                                        data.TRAY_NO = reader.GetValue(i).ToString();
                                        break;
                                    }
                                case 2:
                                    {
                                        data.LABEL = int.Parse(reader.GetValue(i).ToString());
                                        break;
                                    }
                            }
                        }
                        _trayList.Add(data);
                    }
                }
                catch (Exception ex)
                {
                    PrintInfo.I("无法连接{0}:{1}", connectionObject, ex.Message);
                }
            }
            string batch = string.Empty;
                       
            if (_trayList.Count > 0)
            {
                PrintInfo.I(string.Format("查询到托盘{0}的数据个数:{1},批次:{2}", trayCode, _trayList.Count, _trayList[0].BATCH_ID));
                batch = _trayList[0].BATCH_ID;
            }
            if (_trayList.Count == 0)
            {
                PrintInfo.I("没有查询到托盘{0}的批次数据", trayCode);               
            }
            return batch;
        }

        public override bool CheckStoreRepeat(string trayCode)
        {
            return false;
            //bool isRepeat = false;
            //string strSQL = string.Format(@"SELECT [Id],[TraysId],[Index],[Barcode] ,[Batch] FROM [" + prefixTable + "RegisterTray] WHERE TraysId IN (SELECT [TraysId] FROM [StoreUnitDetail] WHERE [TraysId] >0)");
            //List<RegisterTray> registerTrayList = new List<RegisterTray>();
            //bool success = false;
            //while (!success)
            //{
            //    using (BaseAccess access = new BaseAccess())
            //    {
            //        try
            //        {
            //            registerTrayList = access.ExecuteSelect<RegisterTray>(strSQL);
            //            success = true;
            //        }
            //        catch (Exception ex)
            //        {
            //            PrintInfo.I(ex.Message);
            //        }
            //    }
            //    if (!success)
            //    {
            //        Thread.Sleep(2000);
            //    }
            //}
            //foreach (var item in registerTrayList)
            //{
            //    if (item.Barcode == trayCode)
            //    {
            //        isRepeat = true;
            //        break;
            //    }
            //}
            //return isRepeat;
        }

        public override bool CheckTrayCode(string trayCode)
         {
            return true;
            Regex regex = new Regex(@"^\d+$");
            return trayCode.Length == 12 && regex.IsMatch(trayCode);
        }
    }
}
