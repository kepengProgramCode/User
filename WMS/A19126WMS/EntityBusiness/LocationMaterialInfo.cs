/*
*作者：
*创建时间：2020/1/6 9:37:25 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace A19126WMS.EntityBusiness
{
    [Table("LocationMaterialInfo")]
    [Column(new string[] { "TrayCode" }, "MaterialCode", "MaterialName", "MaterialModel", "MaterialAmount", "LocationRow", "LocationColumn", "BatchNo")]
    /// <summary>
    /// 
    /// </summary>
    public class LocationMaterialInfo : EntityBase
    {
        public const string TRAYCODE = "TrayCode";
        public const string MATERIALCODE = "MaterialCode";
        public const string MATERIALNAME = "MaterialName";
        public const string MATERIALMODEL = "MaterialModel";
        public const string MATERIALAMOUNT = "MaterialAmount";
        public const string LOCATIONROW = "LocationRow";
        public const string LOCATIONCOLUMN = "LocationColumn";
        public const string BATCHNO = "BatchNo";

        private string trayCode;
        /// <summary>
        /// 托盘码
        /// </summary>
        public string TrayCode
        {
            get { return trayCode; }
            set { trayCode = value; }
        }

        private string materialCode;
        /// <summary>
        /// 物料条码
        /// </summary>
        public string MaterialCode
        {
            get { return materialCode; }
            set { materialCode = value; }
        }

        private string materialName;
        /// <summary>
        /// 物料名称
        /// </summary>
        public string MaterialName
        {
            get { return materialName; }
            set { materialName = value; }
        }

        private string materialModel;
        /// <summary>
        /// 物料型号规格
        /// </summary>
        public string MaterialModel
        {
            get { return materialModel; }
            set { materialModel = value; }
        }

        private int materialAmount;
        /// <summary>
        /// 物料数量
        /// </summary>
        public int MaterialAmount
        {
            get { return materialAmount; }
            set { materialAmount = value; }
        }

        private int locationRow;
        /// <summary>
        /// 排
        /// </summary>
        public int LocationRow
        {
            get { return locationRow; }
            set { locationRow = value; }
        }

        private int locationColumn;
        /// <summary>
        /// 列
        /// </summary>
        public int LocationColumn
        {
            get { return locationColumn; }
            set { locationColumn = value; }
        }

        private int batchNo;
        public int BatchNo
        {
            get { return batchNo; }
            set { batchNo = value; }
        }

        private string unit;
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
    }
}
