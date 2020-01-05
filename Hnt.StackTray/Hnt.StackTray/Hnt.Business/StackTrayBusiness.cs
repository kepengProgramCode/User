using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hnt.Entity;
using System.Configuration;
using Hnt.Business.DataControl;
using Snt.Framework.SqlCondition;
using System.Threading;
using System.Text.RegularExpressions;
using Snt.Framework.Entities;
using Hnt.Business.Access;
using System.Collections.ObjectModel;
using Hnt.BarcodeScanner;
using Hnt.PlcListener;
using Hnt.PlcListener.Entity;
using Snt.SimpleOPC;

namespace Hnt.Business
{
    public class StackTrayBusiness : WorkStation
    {
        public int stackNumber = 0;
        public LineDevice lineDevice = null;
        public BusinessControl businessControl;
        public List<CacheStackTray> trayCodeList = new List<CacheStackTray>();
        public int trayNumber = 2;
        public bool isBatchValid = false;
        public bool isTrayCodeValid = false;
        PLCDevice device;
        Scanner scanner;

        /// <summary>
        /// false:同批次,true:混批
        /// </summary>
        private bool mixBatch = false;

        public StackTrayBusiness(LineDevice lineDevice, BusinessControl businessControl)
        {
            //PrintInfo.DottedLine();
            this.stackNumber = int.Parse(ConfigurationManager.AppSettings["stackNumber"]);
            this.trayNumber = int.Parse(ConfigurationManager.AppSettings["trayNumber"]);
            this.isBatchValid = int.Parse(ConfigurationManager.AppSettings["isBatchValid"]) == 1;
            this.isTrayCodeValid = int.Parse(ConfigurationManager.AppSettings["isTrayCodeValid"]) == 1;
            this.lineDevice = lineDevice;
            this.businessControl = businessControl;
            //创建表
            this.lineDevice.PrefixTable = ConfigurationManager.AppSettings["prefixTable"];
            CreateTableBusiness.CreateTable(this.lineDevice.PrefixTable);

            InitTrayCodeList();
            DeviceInit();
        }

        private void DeviceInit()
        {
            //实例化扫码枪
            scanner = new Scanner((ScannerModel)Enum.Parse(typeof(ScannerModel), lineDevice.QRCodeReaderModel), lineDevice.QRCodeReaderIP);

            Init();

            device = Devices["StackTray"];
            //忽略异常
            device.DeviceServer.ExceptionSkip = true;

            this.lineDevice.trayArrivedAddr = device.Listeners["trayArrivedAddr"];
            this.lineDevice.trayArrivedAddr.ValueChange += trayArrivedAddr_ValueChanged;

            this.lineDevice.requestBindDataAddr = device.Listeners["requestBindDataAddr"];
            this.lineDevice.requestBindDataAddr.ValueChange += requestBindDataAddr_ValueChanged;

            this.lineDevice.trayCountAddr = device.Listeners["trayCountAddr"];
            this.lineDevice.scanCodeFeedbackAddr = device.Writers["scanCodeFeedbackAddr"];
            this.lineDevice.scanErrorCodeAddr = device.Writers["scanErrorCodeAddr"];
            this.lineDevice.bindDataResultAddr = device.Writers["bindDataResultAddr"];
        }

        private void Init()
        {
            // 不自动开启监听，默认自动开启监听
            Init(false);
            // 启动监听
            StartListen();
        }

        /// <summary>
        /// 请求数据绑定
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        void requestBindDataAddr_ValueChanged(DbAddress address, string value)
        {
            //PrintInfo.DottedLine();
            PrintInfo.I("请求数据绑定:{0}->{1}", address.oldValue, address.value);
            if (address.value == "1")
            {
                BindDataResult(CommandValue.INITIAL_STATE);
                PrintInfo.I("托盘数据处理结果地址归1");
            }
            if (address.value == "2")
            {
                PrintInfo.I("请求数据绑定(自动)");
                BindData("2");
            }
            if (address.value == "3")
            {
                PrintInfo.I("请求数据绑定(手动)");
                BindData("3");
            }
            if (address.value == "4")
            {
                PrintInfo.I("请求清除数据");
                ClearCacheData();
                BindDataResult(CommandValue.CLEAR_DATA_COMPLETE);
            }
        }


        /// <summary>
        /// 托盘到达请求扫码
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        void trayArrivedAddr_ValueChanged(DbAddress address, string value)
        {
            //PrintInfo.DottedLine();
            PrintInfo.I("请求扫码:{0}->{1}", address.oldValue, address.value);
            if (address.value == "1")
            {
                ScanCodeFeedback(CommandValue.INITIAL_STATE, CommandValue.INITIAL_STATE);
                PrintInfo.I("扫码反馈归1,异常信息归1");
            }
            if (address.value == "2")
            {
                TrayArrived();
            }
        }
        private void BatchCondition(string batchType)
        {
            this.lineDevice.scanCodeFeedbackAddr.Write(batchType);
            //CommandResult cr = this.lineDevice.scanCodeFeedbackAddr.Write(batchType);
            //PrintInfo.AddrWrite(this.lineDevice.scanCodeFeedbackAddr.AddressName, batchType, cr.Succeed);
        }
        private void BindDataResult(string result)
        {
            this.lineDevice.bindDataResultAddr.Write(result);
            //CommandResult cr = this.lineDevice.bindDataResultAddr.Write(result);
            //PrintInfo.AddrWrite(this.lineDevice.bindDataResultAddr.AddressName, result, cr.Succeed);
        }


        /// <summary>
        /// 清除缓存数据
        /// </summary>
        public void ClearCacheData()
        {
            string strSQL = string.Format("DELETE FROM [" + this.lineDevice.PrefixTable + "CacheStackTray] WHERE [Flag]={0}", this.stackNumber);
            bool success = false;
            while (!success)
            {
                using (BaseAccess access = new BaseAccess())
                {
                    try
                    {
                        access.ExecuteNonQuery(strSQL);
                        trayCodeList.Clear();
                        this.mixBatch = false;
                        success = true;
                    }
                    catch (Exception ex)
                    {
                        PrintInfo.I(ex.Message);
                    }
                }
                if (!success)
                {
                    Thread.Sleep(2000);
                }
            }
        }

        /// <summary>
        /// 读取叠盘机缓存托盘数量
        /// </summary>
        /// <returns>返回值:1->0,2->1,3->2</returns>
        public int GetStackTrayCount()
        {
            //CommandResult cr = this.lineDevice.trayCountAddr.Read();
            //PrintInfo.AddrRead(this.lineDevice.trayCountAddr.AddressName, cr.Value, cr.Succeed);
            //int count = int.Parse(cr.Value);

            string result = this.lineDevice.trayCountAddr.Read();

            return int.Parse(result);
        }

        public void BindData(string type)
        {
            int trayCount = GetStackTrayCount();
            PrintInfo.I("当前叠盘机中缓存托盘数量为:{0}", trayCount);
            if (trayCount < 1)
            {
                BindDataResult(CommandValue.TRAY_COUNT_ERROR);
                PrintInfo.I("托盘数量匹配异常");
                return;
            }
            if (trayCodeList.Count < int.Parse(CommandValue.MIN_STACK_COUNT) || trayCodeList.Count > int.Parse(CommandValue.MAX_STACK_COUNT))
            {
                BindDataResult(CommandValue.TRAY_COUNT_ERROR);
                return;
            }
            // 自动请求放行托盘
            if (type == "2")
            {
                if (trayCodeList.Count > 1)
                {
                    if (this.mixBatch == true && trayCount < trayNumber)
                    {
                        SaveCacheData();
                    }
                    else if (this.mixBatch == false && trayCount == trayNumber)
                    {
                        SaveAllCacheData();
                    }
                }
                else
                {
                    BindDataResult(CommandValue.TRAY_COUNT_ERROR);
                }
            }
            // 人工请求放行托盘
            else if (type == "3")
            {
                // 重新扫码，判断托盘条码是否重复
                string trayCode = ScanTrayCode();
                bool isPass = true;
                for (int i = 0; i < trayCodeList.Count; i++)
                {
                    if (trayCodeList[i].Barcode == trayCode)
                    {
                        PrintInfo.I("PC:托盘条码：{0},叠盘机异常时改托盘没通过", trayCode);
                        isPass = false;
                    }
                }
                // 托盘没过
                if (!isPass)
                {
                    SaveCacheData();
                }
                else if (isPass)
                {
                    SaveAllCacheData();
                }
            }
        }

        /// <summary>
        /// 重启读取缓存托盘信息
        /// </summary>
        private void InitTrayCodeList()
        {
            trayCodeList = SelectCacheTable();
            //初始化判断数据库里有没有混批
            if (trayCodeList.Count != 0)
            {
                if (CheckIsMixture(trayCodeList) == 1 && isBatchValid)
                {
                    this.mixBatch = true;
                }
            }
            PrintInfo.I("缓存托盘个数:{0}", trayCodeList.Count);
        }

        public List<CacheStackTray> SelectCacheTable()
        {
            List<CacheStackTray> cacheList = new List<CacheStackTray>();
            using (BaseAccess access = new BaseAccess())
            {
                //BaseCondition condition = new Column(CacheStackTray.FLAG).Equal(/*CommandValue.FLAG*/this.stackNumber);
                cacheList = access.ExecuteSelect<CacheStackTray>(string.Format("SELECT * FROM {0} WHERE Flag = {1}", lineDevice.PrefixTable + "CacheStackTray", this.stackNumber));
            }
            return cacheList;
        }

        public void ReadLineStatus()
        {
            string lineStatus = this.lineDevice.trayArrivedAddr.Read();
            if (lineStatus == "2")
            {
                PrintInfo.I("程序启动时,线体有托盘");
            }
            else if (lineStatus == "1")
            {
                ScanCodeFeedback(CommandValue.INITIAL_STATE, CommandValue.INITIAL_STATE);
                PrintInfo.I("程序启动时,线体无托盘");
            }
            WriteRunningState("Running", string.Format("线体{0}托盘", lineStatus == "2" ? "有" : "无"), ServicesConfig.WorkStationGroups[0].Key);
        }

        private string ScanTrayCode()
        {
            string trayCode = string.Empty;
            trayCode = scanner.OpenAndScan();
            return trayCode;
        }


        private void ScanCodeFeedback(string scanResult, string errorMsg)
        {
            //CommandResult cr = new CommandResult();
            //cr = this.lineDevice.scanCodeFeedbackAddr.Write(scanResult);
            //PrintInfo.AddrWrite(this.lineDevice.scanCodeFeedbackAddr.AddressName, scanResult, cr.Succeed);
            //cr = this.lineDevice.scanErrorCodeAddr.Write(errorMsg);
            //PrintInfo.AddrWrite(this.lineDevice.scanErrorCodeAddr.AddressName, errorMsg, cr.Succeed);

            this.lineDevice.scanCodeFeedbackAddr.Write(scanResult);
            this.lineDevice.scanErrorCodeAddr.Write(errorMsg);
        }

        private List<string> TrayCodelist(string code)
        {
            List<string> codeArray = new List<string>();
            // 此处将要换成数据库查询
            codeArray.Add("TP001");
            codeArray.Add("Tp002");
            return codeArray;
        }



        /// <summary>
        /// 托盘到达
        /// </summary>
        public void TrayArrived()
        {
            string trayCode = ScanTrayCode().TrimEnd('\r');// string.Empty;
            //trayCode = ScanTrayCode(this.lineDevice.QRCodeReaderIP).TrimEnd('\r');
            PrintInfo.I("托盘条码:{0}", trayCode);
            if (!businessControl.CheckTrayCode(trayCode))
            {
                // 扫码失败
                ScanCodeFeedback(CommandValue.SCAN_ERROR, CommandValue.SCAN_CODE_FAILED);
                PrintInfo.I("扫码失败");
                return;
            }
            else
            {
                // 根据扫码扫到的托盘带出高温库叠好的托盘,获得一组条码，包含两个条码
                string[] trayArray = TrayCodelist(trayCode).ToArray();
                // 与叠盘机中的托盘做重码校验(两个托盘都要校验)
                bool trayCodeIsExist = CheckIsExist(trayArray, trayCodeList);
                if (trayCodeIsExist)
                {
                    ScanCodeFeedback(CommandValue.SCAN_ERROR, CommandValue.REPEAT_SCAN_CODE);
                    PrintInfo.I("与叠盘机内缓存托盘码重复");
                    return;
                }
                // 与库存托盘做重码校验
                bool isRepeat = businessControl.CheckStoreRepeat(trayArray[0]);
                bool isRepeats = businessControl.CheckStoreRepeat(trayArray[1]);
                if ((isRepeat && isRepeats) || !isTrayCodeValid)
                {
                    ScanCodeFeedback(CommandValue.SCAN_ERROR, CommandValue.REPEAT_STORE_CODE);
                    PrintInfo.I("与库存托盘码重复");
                    return;
                }
                if (trayCodeList.Count == 0)
                {
                    #region
                    using (BaseAccess access = new BaseAccess())
                    {
                        try
                        {
                            // 同时缓存托盘条码（首先判断是否能获取托盘的批次，再存入缓存库）
                            int result = InsertCacheTable(access, trayArray, 1);
                            if (result == 1)
                            {
                                // 获取批次失败
                                ScanCodeFeedback(CommandValue.SCAN_ERROR, CommandValue.GET_BATCH_FAILED);
                                PrintInfo.I("查不到批次信息");
                                return;
                            }
                            // 通知PLC上位机数据处理完成
                            BatchCondition(CommandValue.SCAN_SUCCESS_NO_MIXTURE);
                            PrintInfo.I("扫码成功，不混批");
                        }
                        catch (Exception ex)
                        {
                            WriteRunningState("Error", "请求批次中断", ServicesConfig.WorkStationGroups[0].Key);
                            PrintInfo.I("ERROR1:{0}", ex.Message);
                        }
                    }
                    #endregion
                }
                // 集合不为空，判断批次
                else if (trayCodeList.Count > 0)
                {
                    #region
                    trayCodeList[trayCodeList.Count - 1].InStack = 2;
                    #region

                    using (BaseAccess access = new BaseAccess())
                    {
                        try
                        {
                            //更新上一个缓存数据为已叠盘
                            UpdateCacheTable(access, trayCodeList[trayCodeList.Count - 1].Barcode, 2);
                            // 同时缓存托盘条码（首先判断是否能获取托盘的批次，再存入缓存库）
                            int result = InsertCacheTable(access, trayArray, 1);
                            // 如果获取批次失败
                            if (result == 1)
                            {
                                // 获取批次失败
                                ScanCodeFeedback(CommandValue.SCAN_ERROR, CommandValue.GET_BATCH_FAILED);
                                PrintInfo.I("查不到批次信息");
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            WriteRunningState("Error", "缓存异常", ServicesConfig.WorkStationGroups[0].Key);
                            PrintInfo.I("ERROR2:{0}", ex.Message);
                        }
                    }
                    #endregion

                    int mixResult = CheckIsMixture(trayCodeList);

                    // 托盘混批验证
                    if (mixResult == 0 || !isBatchValid)
                    {
                        this.mixBatch = false;
                        // 同批次处理
                        BatchCondition(CommandValue.SCAN_SUCCESS_NO_MIXTURE);
                        PrintInfo.I("扫码成功，不混批");
                    }
                    else if (mixResult == 1)
                    {
                        this.mixBatch = true;
                        BatchCondition(CommandValue.SCAN_SUCCESS_MIXTURE);
                        PrintInfo.I("扫码成功，混批");
                    }
                    #endregion
                }
            }
        }
        /// <summary>
        /// 修改缓存托盘集合
        /// </summary>
        /// <param name="cacheTrayList"></param>
        public void UpdateCacheTableList(List<CacheStackTray> cacheTrayList)
        {
            using (BaseAccess access = new BaseAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();
                    foreach (CacheStackTray entity in cacheTrayList)
                    {
                        string updateSql = string.Format("UPDATE {0} SET Barcode='{1}',Batch={2} WHERE Id ={3}", lineDevice.PrefixTable + "CacheStackTray", entity.Barcode, entity.Batch, entity.Id);
                        access.ExecuteNonQuery(updateSql);
                        //access.Update(entity, new string[] { CacheStackTray.ID }, CacheStackTray.BARCODE, CacheStackTray.BATCH);
                    }
                    access.Commit();
                }
                catch (Exception ex)
                {
                    access.Rollback();
                    PrintInfo.I(ex.Message);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    access.Close();
                }
            }
        }
        /// <summary>
        /// 将托盘存入缓存库
        /// </summary>
        /// <param name="trayCode">托盘条码</param>
        /// <param name="access">数据库实例对象</param>
        /// <returns>执行结果。1：未获取到托盘批次。0：缓存成功</returns>
        public int InsertCacheTable(BaseAccess access, string[] trayCode, int inStack)
        {
            int fls = 0;
            for (int i = 0; i < trayCode.Length; i++)
            {
                string batch = businessControl.GetTrayBatch(trayCode[i]);
                ProductProcessDataEntity entity;
                if (string.IsNullOrEmpty(batch))
                {

                    // 未获取到托盘的批次
                    entity = new ProductProcessDataEntity()
                    {
                        TrayCode = trayCode[i],
                        CreateTime = DateTime.Now,
                        State = "托盘到达",
                        MaterialData = "未获取到批次",
                        ExceptionInfo = "未获取到批次"
                    };
                    //WriteProductDateBase(Writers["scanCodeFeedbackAddr"], entity);
                    WriteProductDateBase(device, entity);
                    fls = 1;
                }
                else
                {
                    entity = new ProductProcessDataEntity()
                    {
                        TrayCode = trayCode[i],
                        CreateTime = DateTime.Now,
                        State = "托盘批次",
                        MaterialData = batch
                    };

                    //WriteProductDateBase(Writers["scanCodeFeedbackAddr"], entity);
                    WriteProductDateBase(device, entity);

                    CacheStackTray trayData = new CacheStackTray();
                    trayData.Barcode = trayCode[i];
                    trayData.Batch = batch;
                    trayData.InStack = inStack;
                    trayData.UpdateTime = DateTime.Now;
                    trayData.Flag = this.stackNumber;

                    string insertSql = string.Format("INSERT INTO {0} (Barcode,Batch,InStack,Flag,UpdateTime) OUTPUT INSERTED.Id VALUES ('{1}','{2}','{3}','{4}','{5}')",
                               lineDevice.PrefixTable + "CacheStackTray",
                               trayData.Barcode,
                               trayData.Batch,
                               trayData.InStack,
                               trayData.Flag,
                               trayData.UpdateTime);
                    access.ExecuteNonQuery(insertSql);
                    //access.Insert(trayData, CacheStackTray.BARCODE, CacheStackTray.BATCH, CacheStackTray.IN_STACK, CacheStackTray.UPDATE_TIME, CacheStackTray.FLAG);
                    // 将托盘加入集合
                    trayCodeList.Add(trayData);
                    fls = 0;
                }
            }
            return fls;
        }

        /// <summary>
        /// 更新上一缓存InStack为2（已叠盘）
        /// </summary>
        /// <param name="trayCode">托盘条码</param>
        /// <param name="access">数据库实例对象</param>
        /// <returns>执行结果。1：未获取到托盘批次。0：缓存成功</returns>
        private void UpdateCacheTable(BaseAccess access, string trayCode, int inStack)
        {
            CacheStackTray trayData = new CacheStackTray();
            trayData.Barcode = trayCode;
            trayData.InStack = inStack;
            trayData.UpdateTime = DateTime.Now;
            trayData.Flag = this.stackNumber;

            string updateSql = string.Format("UPDATE {0} SET InStack={1},UpdateTime='{2}' WHERE Barcode='{3}' AND Flag={4}", lineDevice.PrefixTable + "CacheStackTray", trayData.InStack, trayData.UpdateTime, trayData.Barcode, trayData.Flag);
            access.ExecuteNonQuery(updateSql);

            //access.Update(trayData, new string[] { CacheStackTray.BARCODE, CacheStackTray.FLAG }, CacheStackTray.IN_STACK, CacheStackTray.UPDATE_TIME);
        }
        /// <summary>
        /// 更新缓存InStack托盘码（已叠盘）
        /// </summary>
        /// <param name="trayCode">托盘条码</param>
        /// <param name="access">数据库实例对象</param>
        /// <returns>执行结果。1：未获取到托盘批次。0：缓存成功</returns>
        //public void UpdateCacheTable(BaseAccess access, string trayCode, string oldTrayCode)
        //{
        //    BaseCondition condition = new Column(CacheStackTray.BARCODE).Equal(oldTrayCode);
        //    CacheStackTray trayData = access.Select<CacheStackTray>(condition).First();
        //    trayData.Barcode = trayCode;
        //    trayData.UpdateTime = DateTime.Now;
        //    //trayData.Flag = this.stackNumber;
        //    string updateSql = string.Format("UPDATE {0} SET Barcode='{1}',UpdateTime='{2}' WHERE Id='{3}'", lineDevice.PrefixTable + "CacheStackTray", trayData.Barcode, trayData.UpdateTime, trayData.Id);
        //    access.ExecuteNonQuery(updateSql);
        //    //access.Update(trayData, new string[] { CacheStackTray.ID }, CacheStackTray.BARCODE, CacheStackTray.UPDATE_TIME);
        //}
        /// <summary>
        /// 删除缓存托盘
        /// </summary>
        /// <param name="trayCode"></param>
        public void DeleteCacheTable(string trayCode)
        {
            using (BaseAccess access = new BaseAccess())
            {
                try
                {
                    string deleteSql = string.Format("DELETE FROM {0} WHERE Barcode='{1}'", lineDevice.PrefixTable + "CacheStackTray", trayCode);
                    access.ExecuteNonQuery(deleteSql);

                    //BaseCondition condition = new Column(CacheStackTray.BARCODE).Equal(trayCode);
                    //access.Delete<CacheStackTray>(condition);
                    int count = trayCodeList.Count;
                    for (int i = count - 1; i > -1; i--)
                    {
                        if (trayCodeList[i].Barcode == trayCode)
                        {
                            trayCodeList.RemoveAt(i);
                        }
                    }
                }
                catch (Exception ex)
                {
                    PrintInfo.I(ex.Message);
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// 重复扫码校验
        /// </summary>
        /// <param name="trayCode">托盘条码</param>
        /// <param name="trayCodeList">托盘条码集合</param>
        /// <returns>重复扫码：true；非重复扫码：false</returns>
        private bool CheckIsExist(string[] trayCode, List<CacheStackTray> trayCodeList)
        {
            foreach (var item in trayCodeList)
            {
                if (item.Barcode == trayCode[0] || item.Barcode == trayCode[1])
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 保存最下面托盘的信息
        /// </summary>
        /// <param name="flowTray">最下面托盘信息</param>
        /// <param name="access">数据库对象</param>
        private void SaveStackFlowTray(CacheStackTray flowTray, BaseAccess access)
        {
            UpdateUsed(flowTray.Barcode, access);
            StackTrayFlow _flowTray = new StackTrayFlow();
            _flowTray.Barcode = flowTray.Barcode;
            // 通过托盘条码查询得到
            _flowTray.Batch = flowTray.Batch;
            _flowTray.UpdateTime = DateTime.Now;
            _flowTray.Used = 0;

            string insertSql = string.Format("INSERT INTO {0} (Barcode,Batch,Used,UpdateTime) OUTPUT INSERTED.Id VALUES ('{1}','{2}','{3}','{4}')",
                      lineDevice.PrefixTable + "StackTrayFlow",
                      _flowTray.Barcode,
                      _flowTray.Batch,
                      _flowTray.Used,
                      _flowTray.UpdateTime);
            access.ExecuteNonQuery(insertSql);

            //int count = access.Insert(_flowTray, StackTrayFlow.BARCODE, StackTrayFlow.BATCH, StackTrayFlow.UPDATE_TIME, StackTrayFlow.USED);
        }
        /// <summary>
        /// 查询历史数据
        /// </summary>
        /// <returns></returns>
        public List<StackTrays> SelectStackTrays(string barCode = "", DateTime? startTime = null, DateTime? endTime = null)
        {
            List<StackTrays> list = new List<StackTrays>();
            try
            {
                using (BaseAccess access = new BaseAccess())
                {
                    //BaseCondition condition = new Column(StackTrays.ID).IsNotNULL();
                    //if (!string.IsNullOrEmpty(barCode))
                    //{
                    //    BaseCondition barCondition = new Column(StackTrays.BARCODE).Contains(barCode);
                    //    barCondition.Or(new Column(StackTrays.BATCH).Contains(barCode));
                    //    condition.And(barCondition);
                    //}
                    //if (startTime != null)
                    //{
                    //    BaseCondition strCondition = new Column(StackTrays.UPDATE_TIME).MoreThan(startTime);
                    //    condition.And(strCondition);
                    //}
                    //if (endTime != null)
                    //{
                    //    BaseCondition endCondition = new Column(StackTrays.UPDATE_TIME).LessThan(endTime);
                    //    condition.And(endCondition);
                    //}
                    //OrderBy order = new OrderBy(StackTrays.UPDATE_TIME, Order.DESC);
                    //list = access.Select<StackTrays>(condition, order);

                    string whereStr = "Id IS NOT NULL";
                    if (!string.IsNullOrEmpty(barCode))
                    {
                        whereStr += " AND (Barcode LIKE '%" + barCode + "%' OR Batch LIKE '%" + barCode + "%')";
                    }
                    if (startTime != null)
                    {
                        whereStr += " AND UpdateTime > '" + startTime + "'";
                    }
                    if (endTime != null)
                    {
                        whereStr += " AND UpdateTime < '" + endTime + "'";
                    }
                    list = access.ExecuteSelect<StackTrays>(string.Format("SELECT * FROM {0} WHERE {1} ORDER BY UpdateTime DESC", lineDevice.PrefixTable + "StackTrays", whereStr));
                }
            }
            catch (Exception ex)
            {
                PrintInfo.I(ex.Message);
                Console.WriteLine(ex.Message);
            }
            return list;
        }

        public bool UpdateStackTrays(StackTrays stackTrays)
        {
            using (BaseAccess access = new BaseAccess())
            {
                try
                {
                    string updateSql = string.Format("UPDATE {0} SET Barcode='{1}',BATCH='{2}' WHERE Id='{3}'", lineDevice.PrefixTable + "StackTrays", stackTrays.Barcode, stackTrays.Batch, stackTrays.Id);
                    access.ExecuteNonQuery(updateSql);
                    //access.Update(stackTrays, new string[] { StackTrays.ID }, StackTrays.BARCODE, StackTrays.BATCH);
                    return true;
                }
                catch (Exception ex)
                {
                    PrintInfo.I(ex.Message);
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
        /// <summary>
        /// 查询托盘的Id
        /// </summary>
        /// <param name="trayCode">托盘条码</param>
        /// <param name="access">数据库对象实例</param>
        /// <returns>托盘在数据库中的Id</returns>
        private long SelectTraysId(string trayCode, BaseAccess access)
        {
            long traysId = -1;

            //BaseCondition condition = new Column(StackTrayFlow.BARCODE).Equal(trayCode);
            //BaseCondition condition2 = new Column(StackTrayFlow.USED).Equal(0);
            //OrderBy orderByDESC = new OrderBy(StackTrayFlow.ID, Order.DESC);
            //List<StackTrayFlow> traysIdList = access.Select<StackTrayFlow>(condition.And(condition2), orderByDESC);

            List<StackTrayFlow> traysIdList = access.ExecuteSelect<StackTrayFlow>(string.Format("SELECT * FROM {0} WHERE Barcode='{1}' AND Used=0 ORDER BY Id DESC", lineDevice.PrefixTable + "StackTrayFlow", trayCode));

            if (traysIdList.Count > 0)
            {
                traysId = traysIdList[0].Id;
            }
            return traysId;
        }
        /// <summary>
        /// 保存堆叠的托盘
        /// </summary>
        /// <param name="trayCodeList">托盘条码集合</param>
        /// <param name="access">数据库对象实例</param>
        private void SaveStackTrays(List<CacheStackTray> trayCodeList, BaseAccess access, string flag)
        {
            // 按照允许叠盘数量依次增加，根据实际情况而定，其中1盘在最上面,就不需要翻转
            // 翻转保存
            // trayCodeList.Reverse();
            long traysId = SelectTraysId(trayCodeList[trayCodeList.Count - int.Parse(flag)].Barcode, access);
            int trayIndex = 0;
            foreach (var item in trayCodeList)
            {
                if (flag == "2" && item.InStack == 1)
                {
                    continue;
                }

                StackTrays tray = new StackTrays();
                //tray.Id = Guid.NewGuid();
                tray.TraysId = traysId;
                tray.Barcode = item.Barcode;
                tray.Batch = item.Batch;
                tray.TrayIndex = ++trayIndex;
                tray.UpdateTime = DateTime.Now;

                string insertSql = string.Format("INSERT INTO {0} (TraysId,Barcode,Batch,TrayIndex,UpdateTime) OUTPUT INSERTED.Id VALUES ('{1}','{2}','{3}','{4}','{5}')",
                       lineDevice.PrefixTable + "StackTrays",
                       tray.TraysId,
                       tray.Barcode,
                       tray.Batch,
                       tray.TrayIndex,
                       tray.UpdateTime);
                access.ExecuteNonQuery(insertSql);

                //int count = access.Insert(tray, StackTrays.TRAYS_ID, StackTrays.BARCODE, StackTrayFlow.BATCH, StackTrays.TRAY_INDEX, StackTrayFlow.UPDATE_TIME);
                ProductProcessDataEntity entity = new ProductProcessDataEntity()
                {
                    TrayCode = item.Barcode,
                    CreateTime = DateTime.Now,
                    State = "叠盘完成",
                    MaterialData = item.Batch
                };

                //WriteProductDateBase(Writers["scanCodeFeedbackAddr"], entity);
                WriteProductDateBase(device, entity);
            }
        }
        /// <summary>
        /// 删除历史托盘数据
        /// </summary>
        /// <param name="trayId"></param>
        /// <returns></returns>
        public bool DeleteStackTray(int trayId)
        {
            using (BaseAccess access = new BaseAccess())
            {
                try
                {
                    string deleteSql = string.Format("DELETE FROM {0} WHERE Id='{1}'", lineDevice.PrefixTable + "StackTrays", trayId);
                    access.ExecuteNonQuery(deleteSql);
                    //BaseCondition condition = new Column(StackTrays.ID).Equal(trayId);
                    //access.Delete<StackTrays>(condition);
                }
                catch (Exception ex)
                {
                    PrintInfo.I(ex.Message);
                    Console.WriteLine(ex.Message);
                }
            }
            return true;
        }
        /// <summary>
        /// 删除缓存托盘数据
        /// </summary>
        /// <param name="access">数据库对象实例</param>
        private void DeleteCacheData(BaseAccess access, string delFlag)
        {
            string whereStr = string.Empty;
            if (delFlag == "1")
            {
                whereStr = string.Format(" WHERE [Flag]={0}", this.stackNumber);
            }
            else if (delFlag == "2")
            {
                whereStr = string.Format(" WHERE [InStack] = '2' AND [Flag]={0}", this.stackNumber);
            }

            string strSQL = "DELETE  FROM [" + lineDevice.PrefixTable + "CacheStackTray]" + whereStr;
            int count = access.ExecuteNonQuery(strSQL);
        }

        private void UpdateUsed(string trayCode, BaseAccess access)
        {
            string strSQL = string.Format("UPDATE [" + lineDevice.PrefixTable + "StackTrayFlow] SET [Used]=1 WHERE [Barcode]='{0}' AND [Used]=0", trayCode);
            access.ExecuteNonQuery(strSQL);
        }
        /// <summary>
        /// 混批验证:0:同批次;1:混批
        /// </summary>
        /// <param name="trayCodeList">带批次的托盘集合</param>
        /// <returns></returns>
        private int CheckIsMixture(List<CacheStackTray> trayCodeList)
        {
            string currentBatch = trayCodeList[0].Batch;
            foreach (var item in trayCodeList)
            {
                if (item.Batch != currentBatch)
                {
                    // 混批
                    return 1;
                }
            }
            // 同批次
            return 0;
        }

        /// <summary>
        /// 保存所有缓存数据
        /// </summary>
        private void SaveAllCacheData()
        {
            //if (trayCodeList.Count < 2 && type == "2")
            //{
            //    PrintInfo.I("托盘个数小于2个,当前{0}个", trayCodeList.Count);
            //    BindDataResult(CommandValue.TRAY_COUNT_ERROR);
            //    return;
            //}
            // 保存叠盘机堆叠的所有托盘数据
            using (BaseAccess access = new BaseAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();

                    SaveStackFlowTray(trayCodeList[trayCodeList.Count - 1], access);
                    SaveStackTrays(trayCodeList, access, "1");
                    DeleteCacheData(access, "1");
                    //清空托盘list
                    trayCodeList.Clear();

                    access.Commit();
                    this.mixBatch = false;
                    trayCodeList.Clear();
                    WriteRunningState("Running", "处理完成", ServicesConfig.WorkStationGroups[0].Key);
                }
                catch (Exception ex)
                {
                    access.Rollback();
                    WriteRunningState("Error", "保存缓存异常", ServicesConfig.WorkStationGroups[0].Key);
                    PrintInfo.I("异常：{0}", ex.Message);
                }
            }

            //可以放行
            BindDataResult(CommandValue.BIND_COMPLETE);
        }
        /// <summary>
        /// 保存InStack为2的缓存数据
        /// </summary>
        private void SaveCacheData()
        {
            //if (trayCodeList.Count < 2)
            //{
            //    PrintInfo.I("托盘个数小于2个,当前{0}个", trayCodeList.Count);
            //    BindDataResult(CommandValue.TRAY_COUNT_ERROR);
            //    return;
            //}
            // 此时叠盘机中应该只有一个托盘
            // 保存叠盘机堆叠InStack为2的所有托盘数据
            using (BaseAccess access = new BaseAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();

                    SaveStackFlowTray(trayCodeList[trayCodeList.Count - 2], access);
                    SaveStackTrays(trayCodeList, access, "2");
                    DeleteCacheData(access, "2");
                    //清空托盘list中InStack为2的
                    int count = trayCodeList.Count;
                    for (int i = count - 1; i > -1; i--)
                    {
                        if (trayCodeList[i].InStack == 2)
                        {
                            trayCodeList.RemoveAt(i);
                        }
                    }
                    access.Commit();
                    this.mixBatch = false;
                    WriteRunningState("Running", "处理完成", ServicesConfig.WorkStationGroups[0].Key);

                }
                catch (Exception ex)
                {
                    access.Rollback();
                    WriteRunningState("Error", "保存缓存异常", ServicesConfig.WorkStationGroups[0].Key);
                    PrintInfo.I("异常:{0}", ex.Message);
                }
            }
            BindDataResult(CommandValue.BIND_COMPLETE);
        }

    }
}
