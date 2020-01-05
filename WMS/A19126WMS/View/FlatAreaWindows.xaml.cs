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
            Init();
        }

        private void Init()
        {
            MainUIBusiness ui = new MainUIBusiness();
            StoreInfomation infomation = new StoreInfomation
            {
                MaterialCode = "4352345",
                MaterialName = "sdfsdfsdsgsdfhdfsghfsdgdf",
                MaterialSpc = "rgaergeejfgjghjrgw756745675",
                Batch = "3452378567856784532",
                Count = "590"
            };
            ui.CreatLable(StackPanelData, infomation, 100);
        }
    }
}
