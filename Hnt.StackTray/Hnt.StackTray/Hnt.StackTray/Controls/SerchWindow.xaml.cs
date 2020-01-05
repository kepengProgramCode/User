using Hnt.Business;
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
using Hnt.Entity;
using System.Collections.ObjectModel;

namespace Hnt.StackTray.Controls
{
    /// <summary>
    /// SerchWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SerchWindow : UserControl
    {
        private StackTrayBusiness business;
        public Business.Common.ViewPages viewPages;
        List<StackTrays> list;
        public SerchWindow(StackTrayBusiness business)
        {
            InitializeComponent();
            this.business = business;
            //list = business.SelectStackTrays();
            girdDataBind();
        }
        /// <summary>
        /// 初始绑定
        /// </summary>
        private void girdDataBind()
        {
            string barcode = barCode.Text.Trim();
            DateTime? _startTime = startTime.SelectedDate;
            DateTime? _endTime = endTime.SelectedDate;
            list = business.SelectStackTrays(barcode, _startTime, _endTime);
            viewPages = new Business.Common.ViewPages(list);
            this.DataContext = viewPages;
        }
        /// <summary>
        /// 按条件查询 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            girdDataBind();
        }
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOnPages_Click(object sender, RoutedEventArgs e)
        {//单击按钮时也翻页
            viewPages.Fun_Pager((viewPages.CurrentSize > 1 ? viewPages.CurrentSize - 1 : viewPages.CurrentSize));
        }
        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNextPages_Click(object sender, RoutedEventArgs e)
        {//单击按钮时也翻页
            viewPages.Fun_Pager((viewPages.CurrentSize < viewPages.Total ? viewPages.CurrentSize + 1 : viewPages.CurrentSize));
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("是否确认修改?", "提示", MessageBoxButton.OKCancel,MessageBoxImage.Question);
            if (result == MessageBoxResult.OK)
            {
                string Id = ((Button)sender).DataContext.ToString();
                foreach (StackTrays item in HistoryData.Items)
                {
                    if(item.Id.ToString().Equals(Id))
                    {
                        UpdateStackTray window = new UpdateStackTray(business)
                        {
                            Title = item.Barcode,
                            StackTray = item
                        };
                        window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                        window.ValueChanging += Window_ValueChanging; ;
                        window.ShowDialog();
                    }
                }
            }
        }

        private void Window_ValueChanging()
        {
            girdDataBind();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("是否确认删除?", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.OK)
            {
                string id = ((Button)sender).DataContext.ToString();
                business.DeleteStackTray(Int32.Parse(id));
            }
        }
    }
}
