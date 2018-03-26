using WeifenLuo.WinFormsUI.Docking;
using System.ComponentModel;
using System.Drawing;
namespace JJECN_WMS
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin1 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient1 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            this.dockMain = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.到货管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.到货信息录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.待处理物料检验ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印报检单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.来料检验结果录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.来料检验结果查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库发料单生成以及打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.原材料出库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.半成品出库明细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成品出库明细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockMain
            // 
            this.dockMain.ActiveAutoHideContent = null;
            this.dockMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockMain.DockBackColor = System.Drawing.SystemColors.Control;
            this.dockMain.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockMain.Location = new System.Drawing.Point(0, 33);
            this.dockMain.Name = "dockMain";
            this.dockMain.Size = new System.Drawing.Size(1276, 693);
            dockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient1.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin1.DockStripGradient = dockPanelGradient1;
            tabGradient1.EndColor = System.Drawing.SystemColors.Control;
            tabGradient1.StartColor = System.Drawing.SystemColors.Control;
            tabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin1.TabGradient = tabGradient1;
            autoHideStripSkin1.TextFont = new System.Drawing.Font("微软雅黑", 9F);
            dockPanelSkin1.AutoHideStripSkin = autoHideStripSkin1;
            tabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.ActiveTabGradient = tabGradient2;
            dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient1.DockStripGradient = dockPanelGradient2;
            tabGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.InactiveTabGradient = tabGradient3;
            dockPaneStripSkin1.DocumentGradient = dockPaneStripGradient1;
            dockPaneStripSkin1.TextFont = new System.Drawing.Font("微软雅黑", 9F);
            tabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient1.ActiveCaptionGradient = tabGradient4;
            tabGradient5.EndColor = System.Drawing.SystemColors.Control;
            tabGradient5.StartColor = System.Drawing.SystemColors.Control;
            tabGradient5.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient1.ActiveTabGradient = tabGradient5;
            dockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient1.DockStripGradient = dockPanelGradient3;
            tabGradient6.EndColor = System.Drawing.SystemColors.InactiveCaption;
            tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
            dockPaneStripToolWindowGradient1.InactiveCaptionGradient = tabGradient6;
            tabGradient7.EndColor = System.Drawing.Color.Transparent;
            tabGradient7.StartColor = System.Drawing.Color.Transparent;
            tabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient1.InactiveTabGradient = tabGradient7;
            dockPaneStripSkin1.ToolWindowGradient = dockPaneStripToolWindowGradient1;
            dockPanelSkin1.DockPaneStripSkin = dockPaneStripSkin1;
            this.dockMain.Skin = dockPanelSkin1;
            this.dockMain.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.到货管理ToolStripMenuItem,
            this.待处理物料检验ToolStripMenuItem,
            this.出库管理ToolStripMenuItem,
            this.出库管理ToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1276, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 到货管理ToolStripMenuItem
            // 
            this.到货管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.到货信息录入ToolStripMenuItem});
            this.到货管理ToolStripMenuItem.Name = "到货管理ToolStripMenuItem";
            this.到货管理ToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.到货管理ToolStripMenuItem.Text = "到货信息管理";
            // 
            // 到货信息录入ToolStripMenuItem
            // 
            this.到货信息录入ToolStripMenuItem.Name = "到货信息录入ToolStripMenuItem";
            this.到货信息录入ToolStripMenuItem.Size = new System.Drawing.Size(293, 30);
            this.到货信息录入ToolStripMenuItem.Text = "到货信息查询及条码打印";
            this.到货信息录入ToolStripMenuItem.Click += new System.EventHandler(this.ArriveRecode_Click);
            // 
            // 待处理物料检验ToolStripMenuItem
            // 
            this.待处理物料检验ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打印报检单ToolStripMenuItem,
            this.来料检验结果录入ToolStripMenuItem,
            this.来料检验结果查询ToolStripMenuItem});
            this.待处理物料检验ToolStripMenuItem.Name = "待处理物料检验ToolStripMenuItem";
            this.待处理物料检验ToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.待处理物料检验ToolStripMenuItem.Text = "物料检验管理";
            // 
            // 打印报检单ToolStripMenuItem
            // 
            this.打印报检单ToolStripMenuItem.Name = "打印报检单ToolStripMenuItem";
            this.打印报检单ToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.打印报检单ToolStripMenuItem.Text = "打印报检单";
            this.打印报检单ToolStripMenuItem.Click += new System.EventHandler(this.PrintTestReport_Click);
            // 
            // 来料检验结果录入ToolStripMenuItem
            // 
            this.来料检验结果录入ToolStripMenuItem.Name = "来料检验结果录入ToolStripMenuItem";
            this.来料检验结果录入ToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.来料检验结果录入ToolStripMenuItem.Text = "来料检验结果录入";
            this.来料检验结果录入ToolStripMenuItem.Click += new System.EventHandler(this.AddTestRemark_Click);
            // 
            // 来料检验结果查询ToolStripMenuItem
            // 
            this.来料检验结果查询ToolStripMenuItem.Name = "来料检验结果查询ToolStripMenuItem";
            this.来料检验结果查询ToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.来料检验结果查询ToolStripMenuItem.Text = "来料检验结果查询";
            this.来料检验结果查询ToolStripMenuItem.Click += new System.EventHandler(this.QuaryTestRemark_Click);
            // 
            // 出库管理ToolStripMenuItem
            // 
            this.出库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.出库发料单生成以及打印ToolStripMenuItem});
            this.出库管理ToolStripMenuItem.Name = "出库管理ToolStripMenuItem";
            this.出库管理ToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.出库管理ToolStripMenuItem.Text = "入库管理";
            // 
            // 出库发料单生成以及打印ToolStripMenuItem
            // 
            this.出库发料单生成以及打印ToolStripMenuItem.Name = "出库发料单生成以及打印ToolStripMenuItem";
            this.出库发料单生成以及打印ToolStripMenuItem.Size = new System.Drawing.Size(331, 30);
            this.出库发料单生成以及打印ToolStripMenuItem.Text = "半成品信息录入以及条码打印";
            this.出库发料单生成以及打印ToolStripMenuItem.Click += new System.EventHandler(this.SelfProduction_Click);
            // 
            // 出库管理ToolStripMenuItem1
            // 
            this.出库管理ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.原材料出库ToolStripMenuItem,
            this.半成品出库明细ToolStripMenuItem,
            this.成品出库明细ToolStripMenuItem});
            this.出库管理ToolStripMenuItem1.Name = "出库管理ToolStripMenuItem1";
            this.出库管理ToolStripMenuItem1.Size = new System.Drawing.Size(100, 29);
            this.出库管理ToolStripMenuItem1.Text = "出库管理";
            // 
            // 原材料出库ToolStripMenuItem
            // 
            this.原材料出库ToolStripMenuItem.Name = "原材料出库ToolStripMenuItem";
            this.原材料出库ToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.原材料出库ToolStripMenuItem.Text = "原材料出库明细";
            this.原材料出库ToolStripMenuItem.Click += new System.EventHandler(this.原材料出库ToolStripMenuItem_Click);
            // 
            // 半成品出库明细ToolStripMenuItem
            // 
            this.半成品出库明细ToolStripMenuItem.Name = "半成品出库明细ToolStripMenuItem";
            this.半成品出库明细ToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.半成品出库明细ToolStripMenuItem.Text = "半成品出库明细";
            // 
            // 成品出库明细ToolStripMenuItem
            // 
            this.成品出库明细ToolStripMenuItem.Name = "成品出库明细ToolStripMenuItem";
            this.成品出库明细ToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.成品出库明细ToolStripMenuItem.Text = "成品出库明细";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 726);
            this.Controls.Add(this.dockMain);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "仓库管理系统";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;


        private DockPanel dockMain;
        private System.Windows.Forms.ToolStripMenuItem 到货管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 到货信息录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 待处理物料检验ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 来料检验结果录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 来料检验结果查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印报检单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库发料单生成以及打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 原材料出库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 半成品出库明细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成品出库明细ToolStripMenuItem;

    }
}

