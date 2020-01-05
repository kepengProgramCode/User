// 生成时间：2016/12/5 23:23:30
using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;
namespace Hnt.Entity
{
    [Table("MES_DCM_INJECT")]
    [Column(new string[] { "BATCH_ID" }, "MDL_NAME", "TRAY_NO", "TIME_CREATE", "LABEL")]
    public class MES_DCM_INJECT : EntityBase
    {
        public const string _BATCH_ID = "BATCH_ID";
        public const string _MDL_NAME = "MDL_NAME";
        public const string _TRAY_NO = "TRAY_NO";
        public const string _TIME_CREATE = "TIME_CREATE";
        public const string _LABEL = "LABEL";
        private string Batch_Id;
        public string BATCH_ID
        {
            get { return Batch_Id; }
            set { Batch_Id = value; }
        }

        private string MDL_Name;
        public string MDL_NAME
        {
            get { return MDL_Name; }
            set { MDL_Name = value; }
        }

        private string Tray_No;
        public string TRAY_NO
        {
            get { return Tray_No; }
            set { Tray_No = value; }
        }

        private DateTime Time_Create;
        public DateTime TIME_CREATE
        {
            get { return Time_Create; }
            set { Time_Create = value; }
        }

        private int Label;
        public int LABEL
        {
            get { return Label; }
            set { Label = value; }
        }

    }
}
