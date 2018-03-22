using System;
using Business.Framework.DataAttribute;
using Business.Framework;
namespace JJE_WMS_Entity
{
    [Table("Table_InvoiceVerify")]
    [Columns(new string[] { "Barcode" }, "Batch", "Count", "InvoiceNumber", "MaterialName", "MaterialNumber", "Result", "SupplierCode", "Time", "Iquantity", "SupplierName","Unit")]
    public class InvoiceVerify : Entity
    {
        private string unit;

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }


        private string supplierName;

        public string SupplierName
        {
            get { return supplierName; }
            set { supplierName = value; }
        }

        private string barcode;
        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        private string batch;
        public string Batch
        {
            get { return batch; }
            set { batch = value; }
        }

        /// <summary>
        /// 到货数量
        /// </summary>
        private string count;
        public string Count
        {
            get { return count; }
            set { count = value; }
        }

        private string invoiceNumber;
        public string InvoiceNumber
        {
            get { return invoiceNumber; }
            set { invoiceNumber = value; }
        }

        private string materialName;
        public string MaterialName
        {
            get { return materialName; }
            set { materialName = value; }
        }

        private string materialNumber;
        public string MaterialNumber
        {
            get { return materialNumber; }
            set { materialNumber = value; }
        }

        private string result;
        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        private string supplierCode;
        public string SupplierCode
        {
            get { return supplierCode; }
            set { supplierCode = value; }
        }

        private DateTime time;
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        /// <summary>
        /// 采购数量
        /// </summary>
        private string iquantity;
        public string Iquantity
        {
            get { return iquantity; }
            set { iquantity = value; }
        }

    }
}
