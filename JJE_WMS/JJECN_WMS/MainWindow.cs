using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JJECN_WMS.BaseFoundation;
using WeifenLuo.WinFormsUI.Docking;
using JJECN_WMS.DataBaseManager;
using System.Runtime.Remoting;
using System.Reflection;
using JJE_WMS_Entity;
using JJECN_WMS.ArrriveRecordManager;
using JJE_Business.Business;
using JJECN_WMS.TestManager;
using JJECN_WMS.Instorage;
using JJECN_WMS.OutStore;

namespace JJECN_WMS
{
    public partial class MainWindow : BaseForm
    {

        // 用户账号
        private User userInfo;
        public MainWindow(User user)
        {
            this.userInfo = user;
            LogBusiness.RecordLog(userInfo.Id.ToString(), "登录进入管理系统", "登录");
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(MainWindow_FormClosing);
        }

        void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogBusiness.RecordLog(userInfo.Id.ToString(), "点击关闭管理系统，并退出系统", "关闭系统");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //管理员权限
            if (userInfo.Access == 1)
            {
                //添加一级菜单
                ToolStripMenuItem subItem;
                ToolStripMenuItem subItem_sub;
                subItem = AddContextMenu("基础数据管理(&M)", menuStrip.Items, null);
                //添加二级菜单
                subItem_sub = AddContextMenu("人员信息管理", subItem.DropDownItems, null);
                // 添加三级菜单
                AddContextMenu("人员管理", subItem_sub.DropDownItems, new EventHandler(MenuClicked));
                //添加二级菜单
                subItem_sub = AddContextMenu("仓库结构管理", subItem.DropDownItems, new EventHandler(MenuClicked));
                //添加三级菜单
                AddContextMenu("创建仓库结构", subItem_sub.DropDownItems, new EventHandler(MenuClicked));
                AddContextMenu("修改仓库结构", subItem_sub.DropDownItems, new EventHandler(MenuClicked));

                //添加菜单二
                //subItem = AddContextMenu("到货管理", menuStrip.Items, null);
                //添加子菜单
                //AddContextMenu("添加出库", subItem.DropDownItems, new EventHandler(MenuClicked));
                //AddContextMenu("出库管理", subItem.DropDownItems, new EventHandler(MenuClicked));
            }
        }


        /// <summary>
        /// 添加子菜单
        /// </summary>
        /// <param name="text">要显示的文字，如果为 - 则显示为分割线</param>
        /// <param name="collection">要添加到的子菜单集合</param>
        /// <param name="callback">点击时触发的事件</param>
        /// <returns>生成的子菜单，如果为分隔条则返回null</returns>

        private ToolStripMenuItem AddContextMenu(string text, ToolStripItemCollection collection, EventHandler callback)
        {
            if (!string.IsNullOrEmpty(text))
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(text);
                tsmi.Tag = text;
                if (callback != null)
                    tsmi.Click += callback;
                collection.Add(tsmi);
                return tsmi;
            }
            return null;
        }


        private void MenuClicked(object sender, EventArgs e)
        {
            //以下主要是动态生成事件并打开窗体
            Assembly assembly = Assembly.GetExecutingAssembly();
            string tag = (string)(sender as ToolStripMenuItem).Tag;
            object obj = null;
            switch (tag)
            {
                case "人员管理":
                    obj = assembly.CreateInstance("JJECN_WMS.DataBaseManager.StaffManager");
                    break;
                case "创建仓库结构":
                    obj = assembly.CreateInstance("JJECN_WMS.DataBaseManager.CreatStore");
                    break;
                case "修改仓库结构":
                    obj = assembly.CreateInstance("JJECN_WMS.DataBaseManager.ResizeStoreForm");
                    break;
                default:
                    break;
            }
            DockContent form = (DockContent)obj;
            ShowForm(form);
        }

        /// <summary>
        /// 根据名称查找对应的窗体
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private DockContent FindDocument(string text)
        {
            if (dockMain.DocumentStyle == DocumentStyle.DockingWindow)
            {
                foreach (DockContent content in dockMain.Contents)
                {
                    if (content.DockHandler.TabText == text)
                    {
                        return content;
                    }
                }
                Form m = MdiChildren.Where(p => p.Text.Equals(text)).FirstOrDefault();
                return m == null ? null : m as DockContent;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="form"></param>
        public void ShowForm(DockContent form)
        {
            try
            {
                DockContent hasDockContent = FindDocument(form.Text);
                if (hasDockContent != null)
                {
                    hasDockContent.Show();
                }
                else
                {
                    form.Show(dockMain);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "窗体加载", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 到货记录录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArriveRecode_Click(object sender, EventArgs e)
        {
            Record recode = new Record(userInfo.Id.ToString());
            ShowForm(recode);
        }


        /// <summary>
        /// 来料检验结果录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTestRemark_Click(object sender, EventArgs e)
        {
            RecordTestInfomation info = new RecordTestInfomation(userInfo.Id.ToString());
            ShowForm(info);
        }


        /// <summary>
        /// 检验结果查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuaryTestRemark_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 打印报检单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintTestReport_Click(object sender, EventArgs e)
        {
            PrintReport report = new PrintReport();
            report.UserAcount = userInfo.Id.ToString();
            ShowForm(report);
        }

        /// <summary>
        /// 半成品录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelfProduction_Click(object sender, EventArgs e)
        {
            SemifinishedStorage sem = new SemifinishedStorage();
            ShowForm(sem);
        }

        private void 原材料出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialOutStore material = new MaterialOutStore();
            ShowForm(material);
        }



        ///// <summary>
        ///// 创建仓库结构
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void CreatStore_Click(object sender, EventArgs e)
        //{
        //    CreatStore form = new CreatStore();
        //    ShowForm(form);
        //}


        ///// <summary>
        ///// 修改仓库结构
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void ResizeStore_Click(object sender, EventArgs e)
        //{
        //    ResizeStoreForm form = new ResizeStoreForm();
        //    ShowForm(form);
        //}

        ///// <summary>
        ///// 人员管理
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void StaffManager_Click(object sender, EventArgs e)
        //{
        //    StaffManager staff = new StaffManager();
        //    ShowForm(staff);
        //}
    }
}
