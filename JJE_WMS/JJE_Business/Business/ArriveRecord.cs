using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JJE_Business.Access;
using System.Data;
using JJE_WMS_Entity;
using System.Data.Common;
using System.Windows.Forms;

namespace JJE_Business.Business
{
    /// <summary>
    /// 到货
    /// </summary>
    public class ArrivedRecord
    {
        string userAcount;

        public string UserAcount
        {
            get { return userAcount; }
            set { userAcount = value; }
        }

        public DataTable QurayArrived(string code)
        {
            using (BaseAccess access = new BaseAccess())
            {
                string strSQL = string.Format("SELECT T1.ccode 到货单号,T1.dDate 单据日期,T2.cvenname 供应商名称, B.cComunitCode 供应商代码,B.cInvStd 规格, B.cinvcode 物料编码,B.cinvname 物料名称,A.iquantity 采购数量,C.cComUnitName 单位,A.cbatch 批号,A.iNum 到货数量 FROM  pu_arrivalVouchs A, inventory B,ComputationUnit C,PU_ArrivalVouch T1,vendor T2 WHERE A.cInvCode = B.cinvcode and B.cComunitCode = C.cComunitCode and T1.ID = A.ID and T1.cvencode=T2.cvencode and T1.ccode='{0}'", code);
                DataTable table = access.ExcuteTable(strSQL);
                foreach (DataRow row in table.Rows)
                {
                    row["到货数量"] = row["采购数量"];
                }
                return table;
            }
        }


        /// <summary>
        /// 保存到货数据
        /// </summary>
        /// <param name="invoice"></param>
        public int SaveDataToCaeche(List<InvoiceVerify> invoice)
        {
            int num = 0;
            using (StoreAccess access = new StoreAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();
                    for (int i = 0; i < invoice.Count; i++)
                    {
                        num += access.Insert(invoice[i]);
                        //string strSQL = access.CommandFormate("INSERT INTO [Table_InvoiceVerify] ([InvoiceNumber],[SupplierCode],[Result],[MaterialNumber],[MaterialName],[Count],[Batch],[Barcode],[Time],[Iquantity]) VALUES ({0}InvoiceNumber,{0}SupplierCode,{0}Result,{0}MaterialNumber,{0}MaterialName,{0}Count,{0}Batch,{0}Barcode,{0}Time,{0}Iquantity)");
                        //access.Insert(strSQL, paramater =>
                        //{
                        //    paramater.Add(paramater.CreateParameter("Barcode", invoice[i].Barcode));
                        //    paramater.Add(paramater.CreateParameter("InvoiceNumber", invoice[i].InvoiceNumber));
                        //    paramater.Add(paramater.CreateParameter("SupplierCode", invoice[i].SupplierCode));
                        //    paramater.Add(paramater.CreateParameter("Result", invoice[i].Result));
                        //    paramater.Add(paramater.CreateParameter("MaterialNumber", invoice[i].MaterialNumber));
                        //    paramater.Add(paramater.CreateParameter("MaterialName", invoice[i].MaterialName));
                        //    paramater.Add(paramater.CreateParameter("Count", invoice[i].Count));
                        //    paramater.Add(paramater.CreateParameter("Batch", invoice[i].Batch));
                        //    paramater.Add(paramater.CreateParameter("Time", invoice[i].Time));
                        //    paramater.Add(paramater.CreateParameter("Iquantity", invoice[i].Iquantity));
                        //});
                    }
                    access.Commit();
                }
                catch (DbException ex)
                {
                    LogBusiness.RecordLog(userAcount, "保存到货数据异常" + ex.Message, "保存到货数据");
                    access.RollBack();
                    access.Close();
                    MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //throw;
                }
                return num;
            }
        }

        /// <summary>
        /// 补充物料信息
        /// </summary>
        public int AddMaterialForLining(MaterialSupplement material)
        {
            int num = 0;
            using (StoreAccess access = new StoreAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();
                    num = access.Insert<MaterialSupplement>(material);
                    access.Commit();
                }
                catch (DbException ex)
                {
                    LogBusiness.RecordLog(userAcount, "录入补充物料异常" + ex.Message, "录入补充到货数据");
                    access.RollBack();
                    access.Close();
                }
            }
            return num;
        }
    }
}
