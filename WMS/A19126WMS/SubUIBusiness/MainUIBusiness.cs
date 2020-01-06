using A19126WMS.EntityBusiness;
using A19126WMS.View.StoreStructInfomation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace A19126WMS.SubUIBusiness
{
    class MainUIBusiness
    {
        /// <summary>
        ///  创建库存
        /// </summary>
        /// <param name="panel"></param>
        public void CreatLable(StackPanel panel, List<List<LocationMaterialInfo>> infomation, int storeCout)
        {
            int row = 1;
            List<Label> listLable1 = new List<Label>();
            for (int i = 0; i < storeCout; i++)
            {
                Label labes = new Label();
                labes.HorizontalAlignment = HorizontalAlignment.Center;
                labes.Content = $"{row}-{(i % 10) + 1}";
                //labs.FontSize = 10;
                labes.HorizontalContentAlignment = HorizontalAlignment.Center;
                labes.VerticalContentAlignment = VerticalAlignment.Center;
                labes.Background = new SolidColorBrush(Colors.DarkGray);
                labes.VerticalAlignment = VerticalAlignment.Top;
                labes.Margin = new Thickness(15);
                labes.Name = "LB" + i;
                labes.Width = 85;
                labes.Height = 50;
                labes.MouseDown += Labes_MouseDown;
                //labes.ToolTip = $"{infomation.MaterialCode}\r\n{infomation.MaterialName}\r\n{infomation.MaterialSpc}\r\n{infomation.Count}\r\n{infomation.Batch}\r\n{labes.Content}";
                listLable1.Add(labes);
                if ((i + 1) % 10 == 0)
                {
                    ++row;
                    StackPanel stackPanle = new StackPanel();
                    stackPanle.Orientation = Orientation.Horizontal;
                    foreach (Label bt in listLable1)
                    {
                        stackPanle.Children.Add(bt);
                    }
                    listLable1.Clear();
                    panel.Children.Add(stackPanle);
                }
            }
        }

        private void Labes_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            StoreStructWindows storeStructWindows = new StoreStructWindows();
            storeStructWindows.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            storeStructWindows.Show();
        }
    }
}
