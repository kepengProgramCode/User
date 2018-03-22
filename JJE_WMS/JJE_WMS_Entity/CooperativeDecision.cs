using System;
using Business.Framework.DataAttribute;
using Business.Framework;
namespace JJE_WMS_Entity
{
    [Table("Table_CooperativeDecision")]
    [Columns(new string[] { "Barcode" }, "InvoiceNumber", "MatarialName", "MaterialCode", "RecordResult", "Time", "Remark", "SupplierName", "Count")]
    public class CooperativeDecision : Entity
    {
        // 打印的条码
        private string barcode;
        // 到货单号
        private string invoiceNumber;
        // 物料名称
        private string matarialName;
        // 物料编码
        private string materialCode;
        // 判定结果0：合格 1：不合格
        private int recordResult;
        // 记录时间
        private DateTime time;
        // 备注
        private string remark;
        // 供应商名称
        private string supplierName;
        // 数量
        private decimal count;

        public decimal Count
        {
            get { return count; }
            set { count = value; }
        }
        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        public string InvoiceNumber
        {
            get { return invoiceNumber; }
            set { invoiceNumber = value; }
        }

        public string MatarialName
        {
            get { return matarialName; }
            set { matarialName = value; }
        }

        public string MaterialCode
        {
            get { return materialCode; }
            set { materialCode = value; }
        }

        public int RecordResult
        {
            get { return recordResult; }
            set { recordResult = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        public string SupplierName
        {
            get { return supplierName; }
            set { supplierName = value; }
        }

    }
}
