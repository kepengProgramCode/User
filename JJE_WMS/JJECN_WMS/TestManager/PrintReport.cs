using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JJECN_WMS.BaseFoundation;
using System.Drawing.Printing;
using JJE_Business.Business;
using JJE_WMS_Entity;

namespace JJECN_WMS.TestManager
{
    public partial class PrintReport : BaseForm
    {
        private TestBusiness test;
        string userAcount;

        public string UserAcount
        {
            get { return userAcount; }
            set { userAcount = value; }
        }


        public PrintReport()
        {
            InitializeComponent();
            test = new TestBusiness();
            this.grideMes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grideMes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grideMes.AllowUserToAddRows = false;
        }

        /// <summary>
        /// 打印预览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "来料报检单";
            printer.SubTitle = string.Format("到货单号：{0}          到货日期：{1}             报检人：{2}              报检日期时间:          ", this.txtArriveBarcode.Text.Trim(), DateTime.Now.ToShortDateString(), grideMes.Columns["供应商名称"], userAcount);
            printer.Qr_Message = this.txtArriveBarcode.Text.Trim();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            //printer.PageNumbers = true;
            //printer.ShowTotalPageNumber = true;
            //printer.PageNumberInHeader = false;
            //printer.PorportionalColumns = true;
            //printer.HeaderCellAlignment = StringAlignment.Near;
            //printer.Footer = "页 脚";
            //printer.FooterSpacing = 15;
            //printer.PageSeparator = " / ";
            //printer.PageText = "页";
            printer.PrintPreviewDataGridView(grideMes);
        }


        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.grideMes.DataSource = test.GetInfomation(txtArriveBarcode.Text.Trim());
        }
    }
}


