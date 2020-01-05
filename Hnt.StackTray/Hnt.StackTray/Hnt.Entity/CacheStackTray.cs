// 生成时间：2017/5/24 21:48:04
using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;
namespace Hnt.Entity
{
    [Table("CacheStackTray")]
    [Column(new string[] { "Id" }, "Barcode", "Batch", "UpdateTime", "Flag", "InStack")]
    public class CacheStackTray : EntityBase
    {
        public const string ID = "Id";
        public const string BARCODE = "Barcode";
        public const string BATCH = "Batch";
        public const string UPDATE_TIME = "UpdateTime";
        public const string FLAG = "Flag";
        public const string IN_STACK = "InStack";
        private Int64 id;
        public Int64 Id
        {
            get { return id; }
            set { id = value; }
        }

        private string barcode;
        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        private string batch;
        public string Batch
        {
            get { return batch; }
            set { batch = value; }
        }

        private int inStack;
        public int InStack
        {
            get { return inStack; }
            set { inStack = value; }
        }

        private DateTime updateTime;
        public DateTime UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }
        private int flag;

        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }

    }
}
