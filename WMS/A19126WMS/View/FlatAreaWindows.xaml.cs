using A19126WMS.BaseBusiness;
using A19126WMS.DBBusiness;
using A19126WMS.EntityBusiness;
using A19126WMS.SubUIBusiness;
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

namespace A19126WMS.View
{
    /// <summary>
    /// FlatAreaWindows.xaml 的交互逻辑
    /// </summary>
    public partial class FlatAreaWindows : UserControl
    {
        public FlatAreaWindows()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            MainUI_DB_Business mainUI_DB_Business = new MainUI_DB_Business();
            List<LocationMaterialInfo> infomation = mainUI_DB_Business.GetStoreDetilyByStore(AreaType.FLATE, out int storeCout);
            MainUIBusiness ui = new MainUIBusiness(infomation);
            ui.CreatLable(StackPanelData, storeCout);
        }
    }
}
