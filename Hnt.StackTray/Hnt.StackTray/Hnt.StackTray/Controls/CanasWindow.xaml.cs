using Hnt.Business;
using Hnt.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Hnt.StackTray.Controls
{
    /// <summary>
    /// CanasWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CanasWindow : UserControl
    {
        private List<CacheStackTray> listCache = new List<CacheStackTray>();
        private int trayNumber = 0;
        private StackTrayBusiness business;
        private List<UserEventLog> eventLogList;
        public CanasWindow(StackTrayBusiness business)
        {
            InitializeComponent();
            ConfigurationManager.RefreshSection("appSettings");
            this.business = business;
            Int32.TryParse(ConfigurationManager.AppSettings["trayNumber"], out trayNumber);
            SetCanvas();
            upCanvas();
        }
        /// <summary>
        /// 界面加载
        /// </summary>
        private void SetCanvas()
        {
            //固定宽度，便于计算间隔
            int height = 30;
            GridCanvas.Children.Clear();

            for (int j = 1; j <= trayNumber; j++)
            {
                Border border = new Border()
                {
                    BorderBrush = new SolidColorBrush(Color.FromRgb(68, 85, 152)),
                    BorderThickness = new Thickness(1),
                    Height = height,
                    Width = 200
                };
                Canvas canvas = new Canvas()
                {
                    Background = new SolidColorBrush(Colors.White),
                    ToolTip = "空",
                    Name = "canvas" + j.ToString()
                };
                ContextMenu contextMenu = new ContextMenu();
                MenuItem addMenuItem = new MenuItem() { Header = "添加", Name = "admenu" + j.ToString() };
                MenuItem updateMnuItem = new MenuItem() { Header = "修改", Name = "upmenu" + j.ToString() };
                MenuItem deleteMnuItem = new MenuItem() { Header = "删除", Name = "dlmenu" + j.ToString() };
                contextMenu.Items.Add(addMenuItem);
                contextMenu.Items.Add(updateMnuItem);
                contextMenu.Items.Add(deleteMnuItem);
                canvas.ContextMenu = contextMenu;
                addMenuItem.Click += AddMenuItem_Click;
                updateMnuItem.Click += UpdateMnuItem_Click;
                deleteMnuItem.Click += DeleteMnuItem_Click;
                border.Child = canvas;
                if (GridCanvas.FindName("canvas" + j.ToString()) == null)
                {
                    GridCanvas.RegisterName("canvas" + j.ToString(), canvas);
                    GridCanvas.RegisterName("admenu" + j.ToString(), addMenuItem);
                    GridCanvas.RegisterName("upmenu" + j.ToString(), updateMnuItem);
                    GridCanvas.RegisterName("dlmenu" + j.ToString(), updateMnuItem);
                }
                //动态定位
                int spaceHeight = (370 - trayNumber * height) / (trayNumber + 2);
                border.Margin = new Thickness(0, spaceHeight, 0, 0);
                GridCanvas.Children.Add(border);
            }
        }
        private void upCanvas()
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            Task task = new TaskFactory().StartNew(() =>
            {
                bool isExit = false;
                while (!isExit)
                {
                    //long i = 1;
                    listCache = business.SelectCacheTable();
                    eventLogList = PrintInfo.SelectEventLog();
                    bool isTrayArrived = business.lineDevice.trayArrivedAddr.Read() == "2";
                    try
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            //更换扫码枪图片
                            if (isTrayArrived)
                            {
                                TrayArrivedCanvas.Background = new ImageBrush
                                {
                                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/TrayArrive.png"))
                                };
                            }
                            else
                            {
                                TrayArrivedCanvas.Background = new ImageBrush
                                {
                                    ImageSource = new BitmapImage(new Uri("pack://application:,,,/Images/TrayLeave.png"))
                                };
                            }

                            EventGridView.ItemsSource = eventLogList;
                            foreach (UIElement child in GridCanvas.Children)
                            {
                                if (child.GetType() == typeof(Border) && ((Border)child).Child.GetType() == typeof(Canvas))
                                {
                                    Canvas canvas = (Canvas)(((Border)child).Child);
                                    int n = Int32.Parse(canvas.Name.Substring(6)) - 1;
                                    if (listCache.Count > n && listCache[n] != null && canvas != null)
                                    {
                                        //this.Dispatcher.Invoke(() =>
                                        //{
                                        StringBuilder builder = new StringBuilder();
                                        //Canvas newcanvas = (Canvas)gridCanvas.FindName("canvas" + n.ToString());
                                        builder.AppendLine("托盘：" + (n + 1).ToString());
                                        builder.AppendLine("托盘码：" + listCache[n].Barcode);
                                        builder.AppendLine("批次：" + listCache[n].Batch);
                                        canvas.ToolTip = builder.ToString();
                                        canvas.Background = new SolidColorBrush(Color.FromRgb(106, 120, 175));
                                        //});
                                    }
                                    else
                                    {
                                        canvas.ToolTip = "空";
                                        canvas.Background = new SolidColorBrush(Colors.White);
                                    }
                                }
                            }
                        });
                    }
                    catch (Exception ex)
                    {
                        isExit = true;
                        PrintInfo.I(ex.Message);
                        Console.WriteLine(ex.Message);
                    }
                    Task.Delay(1000).Wait();
                }
            }, token);
        }
        /// <summary>
        /// 删除托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteMnuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("是否确认删除?", "提示", MessageBoxButton.OKCancel,MessageBoxImage.Question);
            if (result == MessageBoxResult.OK)
            {
                int n = Int32.Parse(((MenuItem)sender).Name.Substring(6)) - 1;
                if (listCache.Count > n && listCache[n] != null)
                {
                    business.DeleteCacheTable(listCache[n].Barcode);
                    //SetCanvas();
                }
                else
                {
                    MessageBox.Show("没有托盘，请点击添加！","提示",MessageBoxButton.OKCancel,MessageBoxImage.Stop);
                }
            }
        }

        /// <summary>
        /// 修改托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateMnuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("是否确认修改?", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.OK)
            {
                int n = Int32.Parse(((MenuItem)sender).Name.Substring(6)) - 1;
                if (listCache.Count > n && listCache[n] != null)
                {
                    UpdateTray window = new UpdateTray(business)
                    {
                        Title = listCache[n].Barcode,
                        CacheTrayList = listCache
                    };
                    window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    window.ValueChanging += Window_NumberChanging;
                    window.ShowDialog();
                }
                else
                {
                    MessageBox.Show("没有托盘，请点击添加！","提示", MessageBoxButton.OKCancel, MessageBoxImage.Stop);
                }
            }
        }
        /// <summary>
        /// 添加托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMenuItem_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(((MenuItem)sender).Name.Substring(6)) - 1;
            if (listCache.Count > n && listCache[n] != null)
            {
                MessageBox.Show("存在托盘，请点击修改！", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Stop);
            }
            else
            {
                AddTray window = new AddTray(business)
                {
                    Title = n.ToString()
                };
                window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                window.NumberChanging += Window_NumberChanging;
                window.ShowDialog();
            }
        }

        private void Window_NumberChanging()
        {
            SetCanvas();
        }
    }
}
