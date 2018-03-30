using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PDA_WMSClient.WebReference;
using System.Text.RegularExpressions;

namespace PDA_WMSClient
{
    public partial class InStoreForm : Form
    {
        WMS_WebService client = null;
        public InStoreForm()
        {
            InitializeComponent();
            client = new WMS_WebService();
            cmbStarge.Items.Add("原材料");
            cmbStarge.Items.Add("成品");
            cmbStarge.Items.Add("半成品");
            cmbStarge.SelectedIndex = 0;
            this.txtBarCode.KeyDown += new KeyEventHandler(txtBarCode_KeyDown);
            this.txtBarCode.Focus();
        }

        void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal count = 0;
                string[] list = new string[] { };
                list = client.GrtStoreInfomation(txtBarCode.Text.Trim(), out count);
                if (list[0].Contains("-"))
                {
                    for (int i = 0; i < list.Length; i++)
                    {
                        this.cmbAddress.Items.Add(list[i]);
                    }
                    this.cmbAddress.SelectedIndex = 0;
                    this.txtCount.Text = count.ToString();
                    this.txtVerifyCode.Focus();
                }
                else
                {
                    MessageBox.Show(list[0], "消息", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
        }

        private bool IsNumber(string inputerstr)
        {
            string reg = (inputerstr.Contains(".")) ? @"^(-?\d+)(\.\d+)?$" : @"^[1-9]\d*$";
            bool s = Regex.IsMatch(inputerstr, reg);
            return s;
        }

        private bool IsStoreNumber(string store)
        {
            bool s = Regex.IsMatch(store, "(\\d+).*?([A-Z]).*?(\\d+)");
            return s;
        }


        private void SaveData_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBarCode.Text) && !string.IsNullOrEmpty(txtVerifyCode.Text))
            {
                if (IsNumber(txtCount.Text) && IsStoreNumber(txtVerifyCode.Text))
                {
                    string res = client.InStorage(txtBarCode.Text, cmbAddress.SelectedItem.ToString(), txtVerifyCode.Text.Trim(), Convert.ToDecimal(txtCount.Text), cmbStarge.SelectedIndex);
                    MessageBox.Show(res, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    this.txtBarCode.Text = string.Empty;
                    this.txtVerifyCode.Text = string.Empty;
                    this.cmbAddress.Items.Clear();
                    this.txtCount.Text = string.Empty;
                    this.txtBarCode.Focus();
                }
                else
                {
                    MessageBox.Show("数量填写格式错误，请正确填写数量", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("请正确填写相关信息，其中条码以及库位校验码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            this.cmbAddress.Items.Clear();
            this.cmbAddress.SelectedIndex = -1;
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            this.txtBarCode.Text = string.Empty;
            this.txtVerifyCode.Text = string.Empty;
            this.cmbAddress.Items.Clear();
            this.txtCount.Text = string.Empty;
            this.txtBarCode.Focus();
        }
    }
}