using Hnt.Business;
using Hnt.Business.Access;
using Hnt.Entity;
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
using System.Windows.Shapes;

namespace Hnt.StackTray
{
    /// <summary>
    /// UpdateTray.xaml 的交互逻辑
    /// </summary>
    public partial class UpdateTray : Window
    {
        public delegate void ValueChangeHandler();
        public event ValueChangeHandler ValueChanging;
        private List<CacheStackTray> cacheTrayList;
        private StackTrayBusiness business;
        private string oldTrayCode;
        public UpdateTray(StackTrayBusiness business)
        {
            InitializeComponent();
            this.business = business;
        }

        public List<CacheStackTray> CacheTrayList
        {
            get { return cacheTrayList; }
            set { cacheTrayList = value; }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = CacheTrayList;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            business.UpdateCacheTableList(CacheTrayList);
            //引发事件

            this.Close();
        }
    }
}
