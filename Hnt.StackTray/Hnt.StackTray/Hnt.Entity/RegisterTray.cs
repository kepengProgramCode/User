// 生成时间：2017/7/3 9:47:16
using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;
namespace Hnt.Entity
{
    [Table("RegisterTray")]
    [Column(new string[] {"Id"},"TraysId","Index","Barcode","Batch","Entered","UpdateTime")]
    public class RegisterTray : EntityBase
    {
        public const string ID = "Id";
        public const string TRAYS_ID = "TraysId";
        public const string INDEX = "Index";
        public const string BARCODE = "Barcode";
        public const string BATCH = "Batch";
        public const string ENTERED = "Entered";
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

        private int index;
        public int Index
        {
            get { return index;}
            set { index = value;}
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

        private bool entered;
        public bool Entered
        {
            get { return entered;}
            set { entered = value;}
        }

        private DateTime updateTime;
        public DateTime UpdateTime
        {
            get { return updateTime;}
            set { updateTime = value;}
        }

    }
}
