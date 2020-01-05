/*
*作者：
*创建时间：2020/1/5 1:59:13 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace fff
{
    [Table("StorageLocation")]
    [Column(new string[]{"Id"},"Row","Column","Layer","TrayCode","State","InOutStockState","StoreType","Priority","StorageLocationTypeId","Remarks","CreateTime","EnterTime","SilenceTime","SilenceTimeOut","OverTimeOut","StorageLocationTypeName","LockingState","AgvNo","IsInStock")]
    /// <summary>
    /// 
    /// </summary>
    public class StorageLocation:EntityBase
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

       private int id;
       /// <summary>
       /// 自动生成Id
       /// </summary>
       public int Id
       {
         get { return id; }
         set { id = value; }
       }

       private int row;
       /// <summary>
       /// 
       /// </summary>
       public int Row
       {
         get { return row; }
         set { row = value; }
       }

       private int column;
       /// <summary>
       /// 
       /// </summary>
       public int Column
       {
         get { return column; }
         set { column = value; }
       }

       private int layer;
       /// <summary>
       /// 
       /// </summary>
       public int Layer
       {
         get { return layer; }
         set { layer = value; }
       }

       private string trayCode;
       /// <summary>
       /// 
       /// </summary>
       public string TrayCode
       {
         get { return trayCode; }
         set { trayCode = value; }
       }

       private int state;
       /// <summary>
       /// 
       /// </summary>
       public int State
       {
         get { return state; }
         set { state = value; }
       }

       private int inOutStockState;
       /// <summary>
       /// 
       /// </summary>
       public int InOutStockState
       {
         get { return inOutStockState; }
         set { inOutStockState = value; }
       }

       private int storeType;
       /// <summary>
       /// 
       /// </summary>
       public int StoreType
       {
         get { return storeType; }
         set { storeType = value; }
       }

       private int priority;
       /// <summary>
       /// 
       /// </summary>
       public int Priority
       {
         get { return priority; }
         set { priority = value; }
       }

       private int storageLocationTypeId;
       /// <summary>
       /// 
       /// </summary>
       public int StorageLocationTypeId
       {
         get { return storageLocationTypeId; }
         set { storageLocationTypeId = value; }
       }

       private int remarks;
       /// <summary>
       /// 
       /// </summary>
       public int Remarks
       {
         get { return remarks; }
         set { remarks = value; }
       }

       private DateTime createTime;
       /// <summary>
       /// 
       /// </summary>
       public DateTime CreateTime
       {
         get { return createTime; }
         set { createTime = value; }
       }

       private DateTime enterTime;
       /// <summary>
       /// 
       /// </summary>
       public DateTime EnterTime
       {
         get { return enterTime; }
         set { enterTime = value; }
       }

       private float silenceTime;
       /// <summary>
       /// 
       /// </summary>
       public float SilenceTime
       {
         get { return silenceTime; }
         set { silenceTime = value; }
       }

       private DateTime silenceTimeOut;
       /// <summary>
       /// 
       /// </summary>
       public DateTime SilenceTimeOut
       {
         get { return silenceTimeOut; }
         set { silenceTimeOut = value; }
       }

       private DateTime overTimeOut;
       /// <summary>
       /// 
       /// </summary>
       public DateTime OverTimeOut
       {
         get { return overTimeOut; }
         set { overTimeOut = value; }
       }

       private string storageLocationTypeName;
       /// <summary>
       /// 
       /// </summary>
       public string StorageLocationTypeName
       {
         get { return storageLocationTypeName; }
         set { storageLocationTypeName = value; }
       }

       private int lockingState;
       /// <summary>
       /// 
       /// </summary>
       public int LockingState
       {
         get { return lockingState; }
         set { lockingState = value; }
       }

       private string agvNo;
       /// <summary>
       /// 
       /// </summary>
       public string AgvNo
       {
         get { return agvNo; }
         set { agvNo = value; }
       }

       private int isInStock;
       /// <summary>
       /// 
       /// </summary>
       public int IsInStock
       {
         get { return isInStock; }
         set { isInStock = value; }
       }

    }
}
