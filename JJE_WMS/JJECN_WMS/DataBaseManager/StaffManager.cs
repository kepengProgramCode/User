using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JJECN_WMS.BaseFoundation;
using JJE_WMS_Entity;
using JJE_Business.Access;
using JJE_Business.Business;
using System.Text.RegularExpressions;
using Business.Framework.MD5Business;

namespace JJECN_WMS.DataBaseManager
{
    public partial class StaffManager : BaseForm
    {
        AcountUnit acount;
        Regex reg = new Regex(@"^\d+$");
        public StaffManager()
        {
            InitializeComponent();
            string[] message = new string[] { "普通用户权限", "管理员权限" };
            for (int i = 0; i < message.Length; i++)
            {
                cmbAccess.Items.Add(message[i]);
                cmbAccessOperation.Items.Add(message[i]);
            }
            cmbAccess.SelectedIndex = 0;
            cmbAccessOperation.SelectedIndex = 0;
            acount = new AcountUnit();
        }

        private bool VirafiryNumber(string str)
        {
            return reg.IsMatch(str);
        }


        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStaffNumber.Text) && VirafiryNumber(txtStaffNumber.Text))
            {
                MessageBox.Show("请输入账号", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtStaffName.Text))
            {
                MessageBox.Show("请输入名称", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtStaffPassword.Text))
            {
                MessageBox.Show("请输入密码", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User user = new User();
            user.Id = Convert.ToInt32(txtStaffNumber.Text);
            user.Name = txtStaffName.Text;
            user.Password = MD5Unit.ToByte(txtStaffPassword.Text);
            user.Access = (cmbAccess.SelectedItem == "管理员权限" ? 1 : 2);
            user.Remark = txtRemark.Text;
            if (acount.CreatAcount(user) == 1)
            {
                this.gridControlMessage.DataSource = acount.LoadUserAcount();
                MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtStaffNumber.Clear();
                txtStaffName.Clear();
                txtStaffPassword.Clear();
                txtRemark.Clear();
            }

        }

        private void StaffManager_Load(object sender, EventArgs e)
        {
            DataTable table = acount.LoadUserAcount();
            this.gridControlMessage.DataSource = table;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cmbStaffNumber.Items.Add(table.Rows[i].ItemArray[1]);
                cmbDeletestaffnumber.Items.Add(table.Rows[i].ItemArray[1]);
            }
            if (table.Rows.Count > 0)
                cmbStaffNumber.SelectedIndex = 0;
        }

        /// <summary>
        /// 修改用户信息保存修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResize_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword_Resize.Text))
            {
                MessageBox.Show("请输入密码", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User user = new User();
            user.Id = Convert.ToInt32(cmbStaffNumber.SelectedItem);
            user.Name = txtName_Resize.Text;
            user.Password = MD5Unit.ToByte(txtPassword_Resize.Text);
            user.Access = (cmbAccessOperation.SelectedItem == "管理员权限" ? 1 : 2);
            user.Remark = txtRemark_Resize.Text;
            if (acount.ResizeAcount(user) == 1)
            {
                this.gridControlMessage.DataSource = acount.LoadUserAcount();
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtName_Resize.Clear();
                txtPassword_Resize.Clear();
                txtRemark_Resize.Clear();
            }
        }

        /// <summary>
        /// 选择Id号加载信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbStaffNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<User> user = acount.GetUserForAcount(cmbStaffNumber.SelectedItem);
            if (user != null && user.Count != 0)
            {
                txtPassword_Resize.Text = string.Empty;
                txtRemark_Resize.Text = user[0].Remark;
                txtName_Resize.Text = user[0].Name;
                if (user[0].Access == 1)
                {
                    cmbAccessOperation.SelectedIndex = 1;
                }
                else
                {
                    cmbAccessOperation.SelectedIndex = 0;
                }
            }

        }

        /// <summary>
        /// 删除指定用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelStaff_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确认要删除该用户？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (acount.DeleteAcount(cmbDeletestaffnumber.SelectedItem, 1) == 1)
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.gridControlMessage.DataSource = acount.LoadUserAcount();

                    txtDelStaffName.Clear();
                    txtDelStaffAccess.Clear();
                    cmbDeletestaffnumber.SelectedIndex = -1;
                }
            }
        }


        /// <summary>
        /// 删除全部用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelAllStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("该操作将会删除全部用户数据，请谨慎操作。确认要删除全部用户数据？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (acount.DeleteAcount(cmbDeletestaffnumber.SelectedItem, 2) > 0)
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.gridControlMessage.DataSource = acount.LoadUserAcount();
                    txtDelStaffName.Clear();
                    txtDelStaffAccess.Clear();
                    cmbDeletestaffnumber.SelectedIndex = -1;
                }
            }
        }

        private void cmbDeletestaffnumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<User> user = acount.GetUserForAcount(cmbDeletestaffnumber.SelectedItem);
            if (user != null && user.Count != 0)
            {
                txtDelStaffName.Text = user[0].Name;
                txtDelStaffAccess.Text = user[0].Access.ToString();
            }
        }
    }
}
