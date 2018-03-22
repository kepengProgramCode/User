using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using System.Windows.Forms;
using System.Drawing;

namespace JJECN_WMS.BaseFoundation
{
    public class BaseForm : DockContent
    {
        public BaseForm()
        {
            ContextMenuStrip contentMenu = new ContextMenuStrip();

            ToolStripMenuItem toolClose = new ToolStripMenuItem();
            toolClose.Name = "closed";
            toolClose.Text = "全部关闭";
            toolClose.Size = new Size(90, 20);
            toolClose.Click += new EventHandler(toolClose_Click);


            ToolStripMenuItem toolCloseAll = new ToolStripMenuItem();
            toolCloseAll.Name = "closed";
            toolCloseAll.Text = "关闭";
            toolCloseAll.Size = new Size(90, 20);
            toolCloseAll.Click += new EventHandler(toolCloseAll_Click);


            contentMenu.Items.Add(toolClose);
            contentMenu.Items.Add(toolCloseAll);
            contentMenu.Name = "tsmiClose";
            contentMenu.Size = new System.Drawing.Size(99, 26);
            this.TabPageContextMenuStrip = contentMenu;
        }

        void toolCloseAll_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void toolClose_Click(object sender, EventArgs e)
        {
            DockContentCollection connection = DockPanel.Contents;
            for (int i = 0; i < connection.Count; i++)
            {
                if (connection[i].DockHandler.DockState == DockState.Document)
                {
                    connection[i].DockHandler.Hide();
                }
            }
        }
    }
}
