using A19126WMS.EntityBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace A19126WMS.View.StoreStructInfomation
{
    /// <summary>
    /// StoreStructWindows.xaml 的交互逻辑
    /// </summary>
    public partial class StoreStructWindows : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private List<LocationMaterialInfo> listBind;
        public List<LocationMaterialInfo> ListBind
        {
            get { return listBind; }
            set
            {
                listBind = value;
                NotifyPropertyChanged("ListBind");
            }
        }


        public StoreStructWindows()
        {
            InitializeComponent();
            Loaded += StoreStructWindows_Loaded;
        }

        private void StoreStructWindows_Loaded(object sender, RoutedEventArgs e)
        {
            ListData.ItemsSource = ListBind;
        }

        public void NotifyPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
