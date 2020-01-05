using A19126WMS.SubUIBusiness;
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

namespace A19126WMS.View
{
    /// <summary>
    /// StoreSettingWindows.xaml 的交互逻辑
    /// </summary>
    public partial class StoreSettingWindows : UserControl
    {
        CreateStoreBusiness createStoreBusiness;
        public StoreSettingWindows()
        {
            InitializeComponent();
            createStoreBusiness = new CreateStoreBusiness();
        }

        /// <summary>
        /// 生成库位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string regexEx_Struct = "^([1-9][0-9]*)$";
            Regex regexStruct = new Regex(regexEx_Struct);
            if (regexStruct.IsMatch(txtRow.Text) && regexStruct.IsMatch(txtRow.Text) && regexStruct.IsMatch(txtRow.Text) && regexStruct.IsMatch(txtStoreCapacity.Text))
            {
                createStoreBusiness.CreateStore(cbmType.SelectedIndex, int.Parse(txtRow.Text), int.Parse(txtColunm.Text), int.Parse(txtStoreCapacity.Text));
            }
            else
            {
                MessageBox.Show("请正确的输入对用的库位结构信息！！！", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// 选择所谓湖南工程库位的种类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbmType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;
            txtColunm.IsEnabled = (box.SelectedIndex == 3 || box.SelectedIndex == 4) ? false : true;
            txtStoreCapacity.IsEnabled = (box.SelectedIndex == 3 || box.SelectedIndex == 4) ? false : true;
        }
    }
}
