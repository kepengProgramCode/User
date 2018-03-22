using System;
using Business.Framework.DataAttribute;
using Business.Framework;
namespace JJE_WMS_Entity
{
    [Table("Table_Warehouse")]
    [Columns(new string[] { "Row", "Layer", "Column" }, "MaxCount", "Status", "StoreStaus", "Type")]
    public class Warehouse : Entity
    {
        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        private string column;
        public string Column
        {
            get { return column; }
            set { column = value; }
        }

        private int layer;
        public int Layer
        {
            get { return layer; }
            set { layer = value; }
        }

        private int maxCount;
        public int MaxCount
        {
            get { return maxCount; }
            set { maxCount = value; }
        }

        private int row;
        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private int storeStaus;
        public int StoreStaus
        {
            get { return storeStaus; }
            set { storeStaus = value; }
        }

    }
}
