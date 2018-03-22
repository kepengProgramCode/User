using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JJE_WMS_Entity;

namespace JJECN_WMS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            User user = new User { Id = 9876897 };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }
    }
}
