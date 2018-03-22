using System;
using Business.Framework.DataAttribute;
using Business.Framework;
namespace JJE_WMS_Entity
{
    [Table("Table_MaterialSupplement")]
    [Columns(new string[] { "MaterialCode" }, "DateTime", "MaterialCount", "MaterialName")]
    public class MaterialSupplement : Entity
    {
        // 时间
        private DateTime dateTime;
        // 物料编码
        private string materialCode;
        // 物料数量
        private decimal materialCount;
        // 物料名称
        private  string materialName;
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public string MaterialCode
        {
            get { return materialCode; }
            set { materialCode = value; }
        }

        public decimal MaterialCount
        {
            get { return materialCount; }
            set { materialCount = value; }
        }

        public string MaterialName
        {
            get { return materialName; }
            set { materialName = value; }
        }

    }
}
