/*
*作者：
*创建时间：2020/1/6 9:37:25 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace A19126WMS.EntityBusiness
{
    [Table("StorageLocation")]
    [Column(new string[] { "Row" }, "Column", "Layer", "TrayCode", "State", "InOutStockState", "StoreType", "Priority", "StorageLocationTypeId", "Remarks", "CreateTime", "EnterTime", "SilenceTime", "SilenceTimeOut", "OverTimeOut", "StorageLocationTypeName", "LockingState", "AgvNo", "IsInStock", "EndLocationId", "Cacpcity")]
    /// <summary>
    /// 
    /// </summary>
    public class StorageLocation : EntityBase
    {
        public const string ID = "Id";
        public const string ROW = "Row";
        public const string COLUMN = "Column";
        public const string LAYER = "Layer";
        public const string TRAYCODE = "TrayCode";
        public const string STATE = "State";
        public const string INOUTSTOCKSTATE = "InOutStockState";
        public const string STORETYPE = "StoreType";
        public const string PRIORITY = "Priority";
        public const string STORAGELOCATIONTYPEID = "StorageLocationTypeId";
        public const string REMARKS = "Remarks";
        public const string CREATETIME = "CreateTime";
        public const string ENTERTIME = "EnterTime";
        public const string SILENCETIME = "SilenceTime";
        public const string SILENCETIMEOUT = "SilenceTimeOut";
        public const string OVERTIMEOUT = "OverTimeOut";
        public const string STORAGELOCATIONTYPENAME = "StorageLocationTypeName";
        public const string LOCKINGSTATE = "LockingState";
        public const string AGVNO = "AgvNo";
        public const string ISINSTOCK = "IsInStock";
        public const string ENDLOCATIONID = "EndLocationId";
        public const string CACPCITY = "Cacpcity";

        private int row;
        /// <summary>
        /// 排
        /// </summary>
        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        private int column;
        /// <summary>
        /// 列
        /// </summary>
        public int Column
        {
            get { return column; }
            set { column = value; }
        }

        private int layer;
        /// <summary>
        /// 层
        /// </summary>
        public int Layer
        {
            get { return layer; }
            set { layer = value; }
        }

        private string trayCode;
        /// <summary>
        /// 托盘条码
        /// </summary>
        public string TrayCode
        {
            get { return trayCode; }
            set { trayCode = value; }
        }

        private int state;
        /// <summary>
        /// 状态 0：空；1：可入库；2：可出库；3：工作中；4：异常；5：人工锁；6：系统锁；7：不可用；8：特殊1；9：特殊2；10：特殊3；11：盘库；
        /// </summary>
        public int State
        {
            get { return state; }
            set { state = value; }
        }

        private int inOutStockState;
        /// <summary>
        /// 出入库状态0：无；1：入库中；2：出库中；3：盘库中；
        /// </summary>
        public int InOutStockState
        {
            get { return inOutStockState; }
            set { inOutStockState = value; }
        }

        private int storeType;
        /// <summary>
        /// 1:仓储库位 2:出入库口库位
        /// </summary>
        public int StoreType
        {
            get { return storeType; }
            set { storeType = value; }
        }

        private int priority;
        /// <summary>
        /// 优先级
        /// </summary>
        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        private int storageLocationTypeId;
        /// <summary>
        /// 库位类型Id
        /// </summary>
        public int StorageLocationTypeId
        {
            get { return storageLocationTypeId; }
            set { storageLocationTypeId = value; }
        }

        private int remarks;
        /// <summary>
        /// 备注
        /// </summary>
        public int Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        private DateTime createTime;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        private DateTime enterTime;
        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime EnterTime
        {
            get { return enterTime; }
            set { enterTime = value; }
        }

        private float silenceTime;
        /// <summary>
        /// 动态静置时间
        /// </summary>
        public float SilenceTime
        {
            get { return silenceTime; }
            set { silenceTime = value; }
        }

        private DateTime silenceTimeOut;
        /// <summary>
        /// 静置到达时间
        /// </summary>
        public DateTime SilenceTimeOut
        {
            get { return silenceTimeOut; }
            set { silenceTimeOut = value; }
        }

        private DateTime overTimeOut;
        /// <summary>
        /// 超限到达时间
        /// </summary>
        public DateTime OverTimeOut
        {
            get { return overTimeOut; }
            set { overTimeOut = value; }
        }

        private string storageLocationTypeName;
        /// <summary>
        /// 库位类型名称
        /// </summary>
        public string StorageLocationTypeName
        {
            get { return storageLocationTypeName; }
            set { storageLocationTypeName = value; }
        }

        private int lockingState;
        /// <summary>
        /// 库位锁定状态：0-无锁；1-人工锁；2-系统锁；3：盘库锁
        /// </summary>
        public int LockingState
        {
            get { return lockingState; }
            set { lockingState = value; }
        }

        private string agvNo;
        /// <summary>
        /// AGV编号
        /// </summary>
        public string AgvNo
        {
            get { return agvNo; }
            set { agvNo = value; }
        }

        private int isInStock;
        /// <summary>
        /// 库位是否有货：0-无货；1-有货；
        /// </summary>
        public int IsInStock
        {
            get { return isInStock; }
            set { isInStock = value; }
        }

        private int endLocationId;
        /// <summary>
        /// 目标库位id
        /// </summary>
        public int EndLocationId
        {
            get { return endLocationId; }
            set { endLocationId = value; }
        }

        private int cacpcity;
        public int Cacpcity
        {
            get { return cacpcity; }
            set { cacpcity = value; }
        }

    }
}
