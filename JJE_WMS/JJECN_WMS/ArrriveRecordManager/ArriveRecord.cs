using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JJECN_WMS.BaseFoundation;
using JJE_Business.Business;
using JJE_WMS_Entity;
using System.IO;
using System.Configuration;

namespace JJECN_WMS.ArrriveRecordManager
{
    public partial class Record : BaseForm
    {
        private string userinfomation;
        private ArrivedRecord record;
        public Record(string userAcount)
        {
            this.userinfomation = userAcount;
            record = new ArrivedRecord();
            InitializeComponent();
            this.grideMes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grideMes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.grideMes.AllowUserToAddRows = false;
            foreach (DataGridViewColumn item in this.grideMes.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            LogBusiness.RecordLog(userinfomation, "进入到货查询条码打印界面", "进入界面");
        }


        /// <summary>
        /// 查询到货单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable table = record.QurayArrived(txtArriveBarcode.Text.Trim());
            this.grideMes.DataSource = table;
            for (int i = 0; i < grideMes.Columns.Count; i++)
            {
                this.grideMes.Columns[i].Width = 120;
            }
            this.grideMes.Columns[2].Width = 180;
            this.grideMes.Columns[3].Width = 120;
            this.grideMes.Columns[8].Width = 60;
            this.grideMes.Columns[grideMes.Columns.Count - 1].HeaderText = "到货数量";
            LogBusiness.RecordLog(userinfomation, "进入到货查询条码打印界面点击查询到货按钮", "点击【查询】按钮");
        }

        private void ArriveRecord_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 打印条码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            LogBusiness.RecordLog(userinfomation, "进入到货查询条码打印界面点击打印条码按钮", "点击【打印条码】按钮");
            // 首先打印，完成以后保存数据到数据库
            // 获取打印机名称
            string printerName = ConfigurationManager.AppSettings["Printer"];
            Printer print = new Printer(printerName);
            //MessageBox.Show("正在打印条码", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 保存数据到数据库
            List<InvoiceVerify> list = new List<InvoiceVerify>();
            DataTable table = this.grideMes.DataSource as DataTable;
            foreach (DataRow item in table.Rows)
            {
                InvoiceVerify invoc = new InvoiceVerify();
                invoc.Barcode = string.Concat(item["物料编码"], item["供应商代码"], item["批号"]);
                invoc.Batch = (string)item["批号"];
                invoc.Count = item["到货数量"].ToString();
                invoc.InvoiceNumber = (string)item["到货单号"];
                invoc.Iquantity = item["采购数量"].ToString();
                invoc.MaterialName = (string)item["物料名称"];
                invoc.MaterialNumber = (string)item["物料编码"];
                invoc.Result = (string)item["规格"];
                invoc.SupplierCode = (string)item["供应商代码"];
                invoc.SupplierName = (string)item["供应商名称"];
                invoc.Unit = (string)item["单位"];
                invoc.Time = DateTime.Now;
                string[] str = new string[] { "物料编码：" + invoc.MaterialNumber, 
                                              "物料名称："+ invoc.MaterialName,
                                              "物料规格："+ invoc.Result,
                                              "供应商名称："+ invoc.SupplierName,
                                              "到货数量："+ invoc.Count + " " + invoc.Unit,
                                              "批号："+invoc.Batch,invoc.Barcode};
                print.PrintQRCode(0, 0, 0, 0, str);
                list.Add(invoc);
            }
            record.UserAcount = userinfomation;
            if (record.SaveDataToCaeche(list) == table.Rows.Count)
            {
                MessageBox.Show("保存成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LogBusiness.RecordLog(userinfomation, "进入到货查询条码打印界面点击查询到货按钮保存到货信息", "插入到货数据");
        }
    }
}
