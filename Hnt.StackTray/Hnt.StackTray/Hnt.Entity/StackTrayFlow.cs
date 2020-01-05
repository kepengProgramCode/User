// 生成时间：2016/10/18 14:29:25
using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;
namespace Hnt.Entity
{
    [Table("StackTrayFlow")]
    [Column(new string[] { "Id" }, "Barcode", "Batch", "UpdateTime", "Used")]
    public class StackTrayFlow : EntityBase
    {
        public const string ID = "Id";
        public const string BARCODE = "Barcode";
        public const string BATCH = "Batch";
        public const string UPDATE_TIME = "UpdateTime";
        public const string USED = "Used"; 
        private Int64 id;
        public Int64 Id
        {
            get { return id;}
            set { id = value;}
        }

        private string barcode;
        public string Barcode
        {
            get { return barcode;}
            set { barcode = value;}
        }

        private string batch;
        public string Batch
        {
            get { return batch;}
            set { batch = value;}
        }

        private DateTime updateTime;
        public DateTime UpdateTime
        {
            get { return updateTime;}
            set { updateTime = value;}
        }
        private int used;

        public int Used
        {
            get { return used; }
            set { used = value; }
        }

    }
}
