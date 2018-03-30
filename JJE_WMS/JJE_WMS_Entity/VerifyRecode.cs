using System;
using Business.Framework.DataAttribute;
using Business.Framework;
namespace JJE_WMS_Entity
{
    [Table("Table_VerifyRecode")]
    [Columns(new string[] { "Barcode" }, "ArrivalQuantity", "InvoceNumber", "MaterialCoding", "MaterialName", "PurchaseQuantity", "Qualifiedquantity", "RecodeTime", "Remark", "SupplierName", "UnqualifiedQuantity", "VerifResult", "Batch")]
    public class VerifyRecode : Entity
    {
        // 到货数量
        private decimal arrivalQuantity;
        // 条码
        private string barcode;
        // 到货编号
        private string invoceNumber;
        // 物料编码
        private string materialCoding;
        // 物料名称
        private string materialName;
        // 采购数量
        private decimal purchaseQuantity;
        // 合格数量
        private decimal qualifiedquantity;
        // 记录时间
        private DateTime recodeTime;
        // 备注
        private string remark;
        // 供应商名称
        private string supplierName;
        // 不合格数量
        private decimal unqualifiedQuantity;
        // 检验结果
        private int verifResult;
        //批次
        private string batch;


        public string Batch
        {
            get { return batch; }
            set { batch = value; }
        }
        public decimal ArrivalQuantity
        {
            get { return arrivalQuantity; }
            set { arrivalQuantity = value; }
        }

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        public string InvoceNumber
        {
            get { return invoceNumber; }
            set { invoceNumber = value; }
        }

        public string MaterialCoding
        {
            get { return materialCoding; }
            set { materialCoding = value; }
        }

        public string MaterialName
        {
            get { return materialName; }
            set { materialName = value; }
        }

        public decimal PurchaseQuantity
        {
            get { return purchaseQuantity; }
            set { purchaseQuantity = value; }
        }

        public decimal Qualifiedquantity
        {
            get { return qualifiedquantity; }
            set { qualifiedquantity = value; }
        }

        public DateTime RecodeTime
        {
            get { return recodeTime; }
            set { recodeTime = value; }
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

        public decimal UnqualifiedQuantity
        {
            get { return unqualifiedQuantity; }
            set { unqualifiedQuantity = value; }
        }

        public int VerifResult
        {
            get { return verifResult; }
            set { verifResult = value; }
        }

    }
}
