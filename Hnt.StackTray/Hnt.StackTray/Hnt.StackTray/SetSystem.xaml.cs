using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
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
    /// SetSystem.xaml 的交互逻辑
    /// </summary>
    public partial class SetSystem : Window
    {
        public delegate void NumberChangeHandler();
        public event NumberChangeHandler NumberChanging;
        public SetSystem()
        {
            InitializeComponent();
            ConfigurationManager.RefreshSection("appSettings");
            trayNumbers.Text = ConfigurationManager.AppSettings["trayNumber"];
            isBatchValid.IsChecked = ConfigurationManager.AppSettings["isBatchValid"] == "1";
            noBatchValid.IsChecked = !isBatchValid.IsChecked;
            isTrayCodeValid.IsChecked = ConfigurationManager.AppSettings["isTrayCodeValid"] == "1";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hnt.Business.Common.ConfigSetting.SetAppSetting("isBatchValid", ((bool)isBatchValid.IsChecked ? "1" : "0"));
            Hnt.Business.Common.ConfigSetting.SetAppSetting("isTrayCodeValid", ((bool)isTrayCodeValid.IsChecked ? "1" : "0"));
            Hnt.Business.Common.ConfigSetting.SetAppSetting("trayNumber", trayNumbers.Text.Trim());
            //引发事件
            if (NumberChanging != null)
            {
                NumberChanging();
            }
            this.Close();
        }
    }

}
