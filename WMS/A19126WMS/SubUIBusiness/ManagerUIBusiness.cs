
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace A19126WMS.SubUIBusiness
{
    class ManagerUIBusiness
    {
        private static MainWindow primaryWindow;
        private static List<MainWindow> windows = new List<MainWindow>();
        private static List<Control> controls = new List<Control>();
        private static Dictionary<Type, CustomView> windowControls = new Dictionary<Type, CustomView>();
        private static List<CustomView> views = new List<CustomView>();

        public static void Initialize(MainWindow primaryWindow)
        {
            // WindowsSys.WindowState = true;
            ManagerUIBusiness.primaryWindow = primaryWindow;
        }

        public static void Show<T>(string title) where T : Control
        {
            Type t = typeof(T);
            if (windowControls.ContainsKey(t))
            {
                CustomView view = windowControls[t];
                if (WindowsSys.WindowState)
                {
                    ((Window)view.Control).Activate();
                }
                else
                {
                    primaryWindow.ChangeTo(view.Control);
                }
            }
            else
            {
                Control control = Activator.CreateInstance<T>();
                Control target;
                if (WindowsSys.WindowState)
                {
                    primaryWindow.Visibility = Visibility.Hidden;
                    MainWindow currentWindow = new MainWindow();
                    currentWindow.Title = title;
                    currentWindow.Load(control);
                    windows.Add(currentWindow);
                    currentWindow.Show();
                    target = currentWindow;
                    for (int i = 0; i < views.Count; i++)
                    {
                        currentWindow.AppendWindowMenu(views[i].Control, views[i].Title);
                    }
                    for (int i = 0; i < windows.Count; i++)
                    {
                        windows[i].AppendWindowMenu(currentWindow, title);
                    }
                }
                else
                {
                    primaryWindow.ChangeTo(control);
                    controls.Add(control);
                    primaryWindow.AppendWindowMenu(control, title);
                    target = control;
                }

                CustomView view = new CustomView();
                view.Title = title;
                view.Control = target;
                windowControls.Add(t, view);
                views.Add(view);
            }
        }
        public static void Show(Control control, string title)
        {
            if (windowControls.ContainsKey(control.GetType()))
            {
                CustomView view = windowControls[control.GetType()];
                if (WindowsSys.WindowState)
                {
                    ((Window)view.Control).Activate();
                }
                else
                {
                    primaryWindow.ChangeTo(view.Control);
                }
            }
            else
            {
                Control target;
                if (WindowsSys.WindowState)
                {
                    primaryWindow.Visibility = Visibility.Hidden;
                    MainWindow currentWindow = new MainWindow();
                    currentWindow.Title = title;
                    currentWindow.Load(control);
                    windows.Add(currentWindow);
                    currentWindow.Show();
                    target = currentWindow;
                    for (int i = 0; i < views.Count; i++)
                    {
                        currentWindow.AppendWindowMenu(views[i].Control, views[i].Title);
                    }
                    for (int i = 0; i < windows.Count; i++)
                    {
                        windows[i].AppendWindowMenu(currentWindow, title);
                    }
                }
                else
                {
                    primaryWindow.ChangeTo(control);
                    controls.Add(control);
                    primaryWindow.AppendWindowMenu(control, title);
                    target = control;
                }

                CustomView view = new CustomView();
                view.Title = title;
                view.Control = target;
                windowControls.Add(control.GetType(), view);
                views.Add(view);
            }
        }

        public static void ChangeTo(Control control)
        {
            MainWindow win = (MainWindow)control;
            win.Activate();
            primaryWindow.Visibility = Visibility.Hidden;
        }

        public static void CloseAll()
        {
            windowControls.Clear();
            windows.Clear();
            controls.Clear();
            views.Clear();
        }

        public static MainWindow Win
        {
            get { return primaryWindow; }
            set { primaryWindow = value; }
        }

        public static List<MainWindow> Windows
        {
            get { return windows; }
        }

        public static List<Control> Controls
        {
            get { return controls; }
        }
    }
}
