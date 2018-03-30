using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JJECN_WMS.BaseFoundation;
using JJE_Business.Business;
using JJE_WMS_Entity;
using System.Text.RegularExpressions;

namespace JJECN_WMS.TestManager
{
    public partial class RecordTestInfomation : BaseForm
    {
        string user;
        TestBusiness test;
        string barcode = string.Empty;
        string[] control = new string[] { "合格", "退货", "返修", "让步处理" };
        public RecordTestInfomation(string userAcount)
        {
            this.user = userAcount;
            InitializeComponent();
            test = new TestBusiness();
            test.Name = user;
            this.txtCode.KeyDown += new KeyEventHandler(txtCode_KeyDown);
            for (int i = 0; i < control.Length; i++)
            {
                cmbControl.Items.Add(control[i]);
            }
            cmbControl.SelectedIndex = 0;
        }


        void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbMaterial.Items.Clear();
                string barcode = this.txtCode.Text.Trim();
                LogBusiness.RecordLog(user, "扫码器读取条码为：" + barcode, "读取条码");
                DataTable table = test.GetInfomation(barcode);
                if (table.Rows.Count != 0)
                {
                    foreach (DataRow item in table.Rows)
                    {
                        if (!cmbMaterial.Items.Contains(item["MaterialNumber"]))
                        {
                            this.cmbMaterial.Items.Add(item["MaterialNumber"]);
                        }
                    }
                    cmbMaterial.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("未查询到数据，请重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        /// <summary>
        /// 物料编码选择加载相关数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<InvoiceVerify> message = test.GetMaterialMaeeage((string)cmbMaterial.SelectedItem, txtCode.Text.Trim());
            if (message.Count != 0)
            {
                labMaterialName.Text = message[0].MaterialName;
                labSupplier.Text = message[0].SupplierName;
                labResult.Text = message[0].Result;
                labPurchaseQuantity.Text = message[0].Count;
                labArrivalCount.Text = message[0].Iquantity;
                txtQualified.Text = message[0].Iquantity;
                txtNoQualified.Text = (0.0).ToString();
                labBatch.Text = message[0].Batch;
                labUnit1.Text = message[0].Unit;
                labUnit2.Text = message[0].Unit;
                barcode = message[0].Barcode;
            }
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            VerifyRecode recode = new VerifyRecode();
            if (!NotIsNull(labArrivalCount.Text, labPurchaseQuantity.Text, txtQualified.Text, txtNoQualified.Text))
            {
                // 条码
                recode.Barcode = barcode;
                // 处理结果0：合格 1：退货 2：返修 3：让步处理
                recode.VerifResult = cmbControl.SelectedIndex;
                recode.MaterialName = labMaterialName.Text;
                recode.InvoceNumber = txtCode.Text.Trim();
                recode.RecodeTime = DateTime.Now;
                recode.Remark = txtRemark.Text;
                recode.ArrivalQuantity = Convert.ToDecimal(labArrivalCount.Text);
                recode.MaterialCoding = (string)cmbMaterial.SelectedItem;
                recode.PurchaseQuantity = Convert.ToDecimal(labPurchaseQuantity.Text);
                recode.Qualifiedquantity = Convert.ToDecimal(txtQualified.Text);
                recode.UnqualifiedQuantity = Convert.ToDecimal(txtNoQualified.Text);
                recode.SupplierName = labSupplier.Text;
                recode.Batch = labBatch.Text;
                if (test.SaveTestData(recode) == 1)
                    MessageBox.Show("保存成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {
                    MessageBox.Show("保存失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }


        private bool NotIsNull(params string[] value)
        {
            bool isnull = false;
            for (int i = 0; i < value.Length; i++)
            {
                if (string.IsNullOrEmpty(value[i]))
                {
                    isnull = true;
                }
            }
            return isnull;
        }


        private bool IsNumber(string inputerstr)
        {
            return Regex.IsMatch(inputerstr, "^([0-9]{1,}[.][0-9]*)$");
        }

        private void RecordTestInfomation_Load(object sender, EventArgs e)
        {

        }
    }
}
