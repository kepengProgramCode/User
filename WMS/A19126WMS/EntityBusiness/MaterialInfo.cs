/*
*作者：
*创建时间：2020/1/6 9:37:25 
*/

using Snt.Framework.DataAttribute;
using Snt.Framework.Entities;
using System;

namespace A19126WMS.EntityBusiness
{
    [Table("MaterialInfo")]
    [Column(new string[] { "MaterialCode" }, "MaterialName", "MaterialModel", "Specification", "TypeId", "BatchNo", "Unit", "CreateTime")]
    /// <summary>
    /// 
    /// </summary>
    public class MaterialInfo : EntityBase
    {
        public const string ID = "Id";
        public const string MATERIALCODE = "MaterialCode";
        public const string MATERIALNAME = "MaterialName";
        public const string MATERIALMODEL = "MaterialModel";
        public const string SPECIFICATION = "Specification";
        public const string TYPEID = "TypeId";
        public const string BATCHNO = "BatchNo";
        public const string UNIT = "Unit";
        public const string CREATETIME = "CreateTime";

        private int id;
        /// <summary>
        /// Id
        /// </summary>
        public int Id
        {
            get { return id; }
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
        /// 物料型号
        /// </summary>
        public string MaterialModel
        {
            get { return materialModel; }
            set { materialModel = value; }
        }

        private string specification;
        /// <summary>
        /// 规格
        /// </summary>
        public string Specification
        {
            get { return specification; }
            set { specification = value; }
        }

        private int typeId;
        /// <summary>
        /// 物料类型编号
        /// </summary>
        public int TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }

        private int batchNo;
        /// <summary>
        /// 批号
        /// </summary>
        public int BatchNo
        {
            get { return batchNo; }
            set { batchNo = value; }
        }

        private string unit;
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        private DateTime createTime;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

    }
}
