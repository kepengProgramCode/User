using A19126WMS.SubUIBusiness;
using A19126WMS.View;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace A19126WMS
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        MainUIBusiness mainUI;
        public List<MenuItem> MenuItemWindows { get; }
        public MainWindow()
        {
            InitializeComponent();
            ManagerUIBusiness.Initialize(this);
            MenuItemWindows = new List<MenuItem>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //mainUI = new MainUI();
            //mainUI.CreatLable(stackpanelSide);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyPassword_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StoreSetting_Click(object sender, RoutedEventArgs e)
        {
            ManagerUIBusiness.Show<StoreSettingWindows>("库位设定");
        }

        private void MenuItemCreateUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemViewUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemInTask_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemOutTask_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseAllWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemOpenedWindow_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            ManagerUIBusiness.ChangeTo((Control)item.Tag);
        }

        public MainWindow Load(Control control)
        {
            this.MainCanvas.Children.Add(control);
            return this;
        }

        private void MenuItemLabArea_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemMarketArea_Click(object sender, RoutedEventArgs e)
        {
            ManagerUIBusiness.Show<MarketAreaWindows>("超市区域");
        }

        private void MenuItemFlateArea_Click(object sender, RoutedEventArgs e)
        {
            ManagerUIBusiness.Show<FlatAreaWindows>("平面区域");
        }

        public void AppendWindowMenu(Control control, string title)
        {
            MenuItem item = new MenuItem();
            item.Header = title;
            item.HorizontalContentAlignment = HorizontalAlignment.Center;
            item.Click += MenuItemOpenedWindow_Click;
            //item.Control = control;
            //item.Width = 140;
            //item.Height = 30;
            item.Tag = control;
            MenuItemWindows.Add(item);
        }

        internal Control ChangeTo(Control control)
        {
            Control previousControl = null;
            if (MainCanvas.Children.Count > 0)
            {
                previousControl = (Control)MainCanvas.Children[0];
                MainCanvas.Children.RemoveAt(0);
            }
            MainCanvas.Children.Add(control);
            return previousControl;
        }

        private void MenuItemMoveTask_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
