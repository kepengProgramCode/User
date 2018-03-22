using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JJE_Business.Business;
using JJE_WMS_Entity;

namespace JJECN_WMS
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Loginin_Click(object sender, EventArgs e)
        {
            User userInfo;
            AcountUnit.LoginResult result = AcountUnit.Login(txtUserName.Text, txtUserPassword.Text, out userInfo);
            switch (result)
            {
                case AcountUnit.LoginResult.Success:
                    MainWindow mainWin = new MainWindow(userInfo);
                    Hide();
                    mainWin.ShowDialog();
                    Close();
                    break;
                case AcountUnit.LoginResult.ValidateError:
                    MessageBox.Show(this, "用户名或密码错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserPassword.Clear();
                    break;
                case AcountUnit.LoginResult.NetError:
                    MessageBox.Show(this, "连接服务器失败，请联系管理员", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }
    }
}
