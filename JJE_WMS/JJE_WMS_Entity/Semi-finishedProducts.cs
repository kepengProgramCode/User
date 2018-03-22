using System;
using Business.Framework.DataAttribute;
using Business.Framework;
namespace JJE_WMS_Entity
{
    [Table("Semi-finishedProducts")]
    [Columns(new string[] { "WorkNumber" }, "Count", "Material", "Name")]
    public class Semi_finishedProducts : Entity
    {
        #region 私有字段
        // 工单号
        private string workNumber;
        // 数量
        private decimal count;
        // 材质
        private string material;
        // 名称
        private string name;


        #endregion

        #region 属性
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string WorkNumber
        {
            get { return workNumber; }
            set { workNumber = value; }
        }

        public decimal Count
        {
            get { return count; }
            set { count = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        #endregion
    }
}
