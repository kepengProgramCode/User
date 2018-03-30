using System;
using Business.Framework.DataAttribute;
using Business.Framework;
namespace JJE_WMS_Entity
{
    [Table("Table_InStoreDetails")]
    [Columns(new string[] { "Barcode" }, "Row", "Columns", "Layer", "VirifyCode", "Count", "Category", "Time", "MaterialCode", "MaterialName", "Batch")]
    public class InStoreDetails : Entity
    {
        #region 私有字段
        // 条码
        private string barcode;
        // 货架
        private int row;
        // 货位
        private string columns;
        // 层
        private int layer;
        // 库位条码
        private string virifyCode;
        // 入库数量
        private decimal count;
        // 类别(0：原材料1：成品2：半成品3：产线的物料补充)
        private int category;
        // 入库时间
        private DateTime time;
        // 物料编码
        private string materialCode;
        // 物料名称
        private string materialName;
        private string batch;


        #endregion

        #region 属性
        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        public string Columns
        {
            get { return columns; }
            set { columns = value; }
        }

        public int Layer
        {
            get { return layer; }
            set { layer = value; }
        }

        public string VirifyCode
        {
            get { return virifyCode; }
            set { virifyCode = value; }
        }

        public decimal Count
        {
            get { return count; }
            set { count = value; }
        }

        public int Category
        {
            get { return category; }
            set { category = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public string MaterialCode
        {
            get { return materialCode; }
            set { materialCode = value; }
        }

        public string MaterialName
        {
            get { return materialName; }
            set { materialName = value; }
        }

        public string Batch
        {
            get { return batch; }
            set { batch = value; }
        }
        #endregion
    }
}
