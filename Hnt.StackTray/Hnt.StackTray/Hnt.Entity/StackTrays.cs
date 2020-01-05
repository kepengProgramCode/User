// 生成时间：2016/10/18 14:29:25
using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;
namespace Hnt.Entity
{
    [Table("StackTrays")]
    [Column(new string[] {"Id"},"TraysId","Barcode","Batch","TrayIndex","UpdateTime")]
    public class StackTrays : EntityBase
    {
        public const string ID = "Id";
        public const string TRAYS_ID = "TraysId";
        public const string BARCODE = "Barcode";
        public const string BATCH = "Batch";
        public const string TRAY_INDEX = "TrayIndex";
        public const string UPDATE_TIME = "UpdateTime";
        private Int64 id;
        public Int64 Id
        {
            get { return id;}
            set { id = value;}
        }

        private Int64 traysId;
        public Int64 TraysId
        {
            get { return traysId;}
            set { traysId = value;}
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

        private int trayIndex;
        public int TrayIndex
        {
            get { return trayIndex;}
            set { trayIndex = value;}
        }

        private DateTime updateTime;
        public DateTime UpdateTime
        {
            get { return updateTime;}
            set { updateTime = value;}
        }

    }
}
