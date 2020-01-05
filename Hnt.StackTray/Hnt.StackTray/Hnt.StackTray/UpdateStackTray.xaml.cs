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
    /// UpdateStackTray.xaml 的交互逻辑
    /// </summary>
    public partial class UpdateStackTray : Window
    {
        public delegate void ValueChangeHandler();
        public event ValueChangeHandler ValueChanging;
        private StackTrays stackTray;
        private StackTrayBusiness business;
        private string oldTrayCode;
        public UpdateStackTray(StackTrayBusiness business)
        {
            InitializeComponent();
            this.business = business;
        }
        public StackTrays StackTray
        {
            get { return stackTray; }
            set { stackTray = value; }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            barCode.Text = StackTray.Barcode;
            oldTrayCode = StackTray.Barcode;
            batch.Text = StackTray.Batch;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StackTray.Barcode = barCode.Text.Trim();
            StackTray.Batch = batch.Text.Trim();
            business.UpdateStackTrays(StackTray);
            //引发事件
            if (ValueChanging != null) ValueChanging();
            this.Close();
        }
    }
}
