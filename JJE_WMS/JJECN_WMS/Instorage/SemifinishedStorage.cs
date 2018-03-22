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
using System.Configuration;

namespace JJECN_WMS.Instorage
{
    public partial class SemifinishedStorage : BaseForm
    {
        InstorgeBusiness instore;
        public SemifinishedStorage()
        {
            InitializeComponent();
            instore = new InstorgeBusiness();
            cmbMaterial.Items.Add("首钢");
            cmbMaterial.Items.Add("首钢");
            cmbMaterial.SelectedIndex = 0;
        }

        private bool IsNumber(string inputerstr)
        {
            return Regex.IsMatch(inputerstr, "^([0-9]{1,}[.][0-9]*)$");
        }


        /// <summary>
        /// 录入信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            Semi_finishedProducts pro = new Semi_finishedProducts();
            if (!string.IsNullOrEmpty(txtWorkNumber.Text) && (IsNumber(txtStoreNum.Text)))
            {
                pro.WorkNumber = txtWorkNumber.Text.Trim();
                pro.Count = Convert.ToDecimal(txtStoreNum.Text.Trim());
                pro.Material = cmbMaterial.SelectedItem.ToString();
                pro.Name = txtName.Text.Trim();
                if (instore.SaveMessage(pro).Equals(1))
                {
                    MessageBox.Show("保存成功", "提示");
                }
            }
            else
            {
                MessageBox.Show("填写信息有误，请正确填写相关信息", "提示");
            }
        }


        /// <summary>
        /// 打印条码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            Printer print = new Printer(ConfigurationManager.AppSettings["Print"]);
            string[] str = new string[] {txtWorkNumber.Text.Trim(),
                                            "工单号码："+txtWorkNumber.Text.Trim(),
                                            "半成品名称：" + txtName.Text.Trim(),
                                            "数    量：" + txtStoreNum,
                                            "材    质：" + cmbMaterial.SelectedItem.ToString()};
            print.PrintQRCode(0, 0, 0, str);
        }
    }
}
