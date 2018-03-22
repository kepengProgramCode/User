using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using JJE_Business.Access;
using JJE_WMS_Entity;
using System.Windows.Forms;
using System.Data.Common;

namespace JJE_Business.Business
{
    public class TestBusiness
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DataTable GetInfomation(string code)
        {
            using (StoreAccess accesss = new StoreAccess())
            {
                string strSQL = string.Format("SELECT [MaterialNumber],[MaterialName], [Result],[Iquantity],[Batch],[SupplierName] FROM [Table_InvoiceVerify] WHERE [InvoiceNumber] = '{0}'", code);
                return accesss.ExcuteTable(strSQL);
            }
        }

        /// <summary>
        /// 通过物料编码获取相关信息
        /// </summary>
        /// <param name="materialNumber">物料编码</param>
        /// <param name="code">到货编号</param>
        /// <returns></returns>
        public List<InvoiceVerify> GetMaterialMaeeage(string materialNumber, string code)
        {
            using (StoreAccess access = new StoreAccess())
            {
                string strSQL = access.CommandFormate("SELECT * FROM [Table_InvoiceVerify] WHERE [InvoiceNumber] = {0}InvoiceNumber AND [MaterialNumber] = {0}MaterialNumber");
                return access.ExcuteSelect<InvoiceVerify>(strSQL, parmater =>
                 {
                     parmater.Add(parmater.CreateParameter("InvoiceNumber", code));
                     parmater.Add(parmater.CreateParameter("MaterialNumber", materialNumber));
                 });
            }
        }



        public int SaveTestData(VerifyRecode recode)
        {
            int num = 0;
            using (StoreAccess access = new StoreAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();
                    num = access.Insert(recode);
                    access.Commit();
                }
                catch (Exception ex)
                {
                    access.RollBack();
                    access.Close();
                    LogBusiness.RecordLog(name, ex.Message + "异常", "保存检测结果");
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return num;
        }



        public List<VerifyRecode> GetMaterial(string code)
        {
            using (StoreAccess access = new StoreAccess())
            {
                string strSQL = string.Format("SELECT * FROM [Table_VerifyRecode] WHERE [Barcode] = '{0}'", code);
                return access.Select<VerifyRecode>(strSQL);
            }
        }

        public int SaveConcession(CooperativeDecision decision)
        {
            int num = 0;
            using (StoreAccess access = new StoreAccess(true))
            {
                try
                {
                    access.Open();
                    access.BeginTransaction();
                    num = access.Insert(decision);
                    access.Commit();
                }
                catch (DbException db)
                {
                    access.RollBack();
                    access.Close();
                    LogBusiness.RecordLog(name, db.Message + "异常", "保存让步接收结果");
                    MessageBox.Show("出错" + db.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return num;
        }
    }
}
