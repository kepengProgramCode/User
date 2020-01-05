using Hnt.Business;
using Hnt.Entity;
using System;
using System.Configuration;
using System.Windows;
using System.Windows.Input;

namespace Hnt.StackTray
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private LineDevice lineDevice;
        private StackTrayBusiness business;

        public MainWindow()
        {
            InitializeComponent();
            ConfigurationManager.RefreshSection("appSettings");
            this.Title = ConfigurationManager.AppSettings["title"];
            lineDevice = new LineDevice();
            lineDevice.QRCodeReaderIP = ConfigurationManager.AppSettings["ScanerIP"];
            lineDevice.QRCodeReaderModel = ConfigurationManager.AppSettings["ScanerModel"];
            business = new StackTrayBusiness(lineDevice, new BatchBusiness("MySQLConnection1"));
            business.ReadLineStatus();
            GridCanvas.Children.Add(new Controls.CanasWindow(business));
        }



        /// <summary>
        /// 系统设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SetSystem window = new SetSystem()
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            window.NumberChanging += Window_NumberChanging;
            window.ShowDialog();
        }

        private void Window_NumberChanging()
        {
            GridCanvas.Children.Clear();
            GridCanvas.Children.Add(new Controls.CanasWindow(business));
        }

        /// <summary>
        /// 重启
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void ReStartMenuItem_Click(object sender, RoutedEventArgs e)
        //{
        //    System.Windows.Forms.Application.Restart();
        //    Environment.Exit(0);
        //}
        /// <summary>
        /// 叠盘数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrayMenuItem_Click(object sender, RoutedEventArgs e)
        {
            GridCanvas.Children.Clear();
            GridCanvas.Children.Add(new Controls.CanasWindow(business));
        }
        /// <summary>
        /// 查询窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerchMenuItem_Click(object sender, RoutedEventArgs e)
        {
            GridCanvas.Children.Clear();
            GridCanvas.Children.Add(new Controls.SerchWindow(business));
        }
        /// <summary>
        /// 退出 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
