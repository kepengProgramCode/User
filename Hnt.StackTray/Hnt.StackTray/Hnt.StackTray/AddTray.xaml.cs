using Hnt.Business;
using Hnt.Business.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hnt.StackTray
{
    /// <summary>
    /// AddTray.xaml 的交互逻辑
    /// </summary>
    public partial class AddTray : Window
    {
        public delegate void NumberChangeHandler();
        public event NumberChangeHandler NumberChanging;
        private StackTrayBusiness business;
     
        public AddTray(StackTrayBusiness business)
        {
            InitializeComponent();
            this.business = business;
        }
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string barcode = barCode.Text.Trim();
            if (!business.businessControl.CheckTrayCode(barcode))
            {
                // 扫码失败
                PrintInfo.I("托盘码格式错误！");
                MessageBox.Show("托盘码格式错误！");
                return;
            }
            try
            {
                using (BaseAccess access = new BaseAccess())
                {
                    int result = business.InsertCacheTable(access, barcode, 1);
                    if (result == 1)
                    {
                        MessageBox.Show("未获取到托盘的批次");
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                PrintInfo.I(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
