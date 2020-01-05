/*
*作者：
*创建时间：2020/1/5 20:18:21 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace A19126WMS.EntityBusiness
{
    [Table("WMSTask")]
    [Column(new string[] { "Id" }, "TaskType", "StartCode", "StartRow", "StartColumn", "StartLayer", "EndCode", "EndRow", "EndColumn", "EndLayer", "TrayCode", "WMSState", "Updator", "UpdateTime", "Creator", "CreateTime", "AGVState", "Remarks")]
    /// <summary>
    /// 
    /// </summary>
    public class WMSTask : EntityBase
    {
        public const string ID = "Id";
        public const string TASKTYPE = "TaskType";
        public const string STARTCODE = "StartCode";
        public const string STARTROW = "StartRow";
        public const string STARTCOLUMN = "StartColumn";
        public const string STARTLAYER = "StartLayer";
        public const string ENDCODE = "EndCode";
        public const string ENDROW = "EndRow";
        public const string ENDCOLUMN = "EndColumn";
        public const string ENDLAYER = "EndLayer";
        public const string TRAYCODE = "TrayCode";
        public const string WMSSTATE = "WMSState";
        public const string UPDATOR = "Updator";
        public const string UPDATETIME = "UpdateTime";
        public const string CREATOR = "Creator";
        public const string CREATETIME = "CreateTime";
        public const string AGVSTATE = "AGVState";
        public const string REMARKS = "Remarks";

        private int id;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int taskType;
        /// <summary>
        /// 
        /// </summary>
        public int TaskType
        {
            get { return taskType; }
            set { taskType = value; }
        }

        private string startCode;
        /// <summary>
        /// 
        /// </summary>
        public string StartCode
        {
            get { return startCode; }
            set { startCode = value; }
        }

        private string startRow;
        /// <summary>
        /// 
        /// </summary>
        public string StartRow
        {
            get { return startRow; }
            set { startRow = value; }
        }

        private string startColumn;
        /// <summary>
        /// 
        /// </summary>
        public string StartColumn
        {
            get { return startColumn; }
            set { startColumn = value; }
        }

        private string startLayer;
        /// <summary>
        /// 
        /// </summary>
        public string StartLayer
        {
            get { return startLayer; }
            set { startLayer = value; }
        }

        private string endCode;
        /// <summary>
        /// 
        /// </summary>
        public string EndCode
        {
            get { return endCode; }
            set { endCode = value; }
        }

        private string endRow;
        /// <summary>
        /// 
        /// </summary>
        public string EndRow
        {
            get { return endRow; }
            set { endRow = value; }
        }

        private string endColumn;
        /// <summary>
        /// 
        /// </summary>
        public string EndColumn
        {
            get { return endColumn; }
            set { endColumn = value; }
        }

        private string endLayer;
        /// <summary>
        /// 
        /// </summary>
        public string EndLayer
        {
            get { return endLayer; }
            set { endLayer = value; }
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

        private int wMSState;
        /// <summary>
        /// 
        /// </summary>
        public int WMSState
        {
            get { return wMSState; }
            set { wMSState = value; }
        }

        private string updator;
        /// <summary>
        /// 
        /// </summary>
        public string Updator
        {
            get { return updator; }
            set { updator = value; }
        }

        private DateTime updateTime;
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }

        private string creator;
        /// <summary>
        /// 
        /// </summary>
        public string Creator
        {
            get { return creator; }
            set { creator = value; }
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

        private int aGVState;
        /// <summary>
        /// 
        /// </summary>
        public int AGVState
        {
            get { return aGVState; }
            set { aGVState = value; }
        }

        private string remarks;
        /// <summary>
        /// 
        /// </summary>
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

    }
}
