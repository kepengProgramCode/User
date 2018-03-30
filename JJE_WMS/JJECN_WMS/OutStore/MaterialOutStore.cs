using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JJECN_WMS.BaseFoundation;
using DevExpress.XtraSpreadsheet;
using JJE_Business.Business;
using System.Threading;
using DevExpress.Charts.Native;
using DevExpress.Spreadsheet;
using System.Threading.Tasks;

namespace JJECN_WMS.OutStore
{
    public partial class MaterialOutStore : BaseForm
    {
        public MaterialOutStore()
        {
            InitializeComponent();
            this.spreadsheet.LoadDocument(Application.StartupPath + @"\MaterialMoldle.xlsx");
        }
        private delegate void ThreadMethod(DataRow row, int num);
        ThreadMethod method = null;
        int i = 7;
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MaterialOutBusiness material = new MaterialOutBusiness();
            DataTable table = material.GetOutStoreMessage();

            method = new ThreadMethod(LoadFile);
            Thread thread = new Thread(() =>
            {
                GetInfo(table);
            });
            thread.IsBackground = true;
            thread.Start();
        }

        private void GetInfo(DataTable table)
        {
            foreach (DataRow item in table.Rows)
            {
                this.spreadsheet.Invoke(method, item, i);
                i++;
            }
        }

        private void LoadFile(DataRow item, int i)
        {
            this.spreadsheet.ActiveWorksheet.Cells["A" + i].Value = (string)item["子件编码"];
            this.spreadsheet.ActiveWorksheet.Cells["A" + i].Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin);
            this.spreadsheet.ActiveWorksheet.Cells["B" + i].Value = (string)item["子件名称"];
            this.spreadsheet.ActiveWorksheet.Cells["B" + i].Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin);
            this.spreadsheet.ActiveWorksheet.Cells["C" + i].Value = (item["子件规格"] != null) ? item["子件规格"].ToString() : " ";
            this.spreadsheet.ActiveWorksheet.Cells["C" + i].Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin);
            this.spreadsheet.ActiveWorksheet.Cells["D" + i].Value = (string)item["计量单位"];
            this.spreadsheet.ActiveWorksheet.Cells["D" + i].Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin);
            this.spreadsheet.ActiveWorksheet.Cells["E" + i].Value = item["基本用量"].ToString().TrimEnd('0');
            this.spreadsheet.ActiveWorksheet.Cells["E" + i].Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin);
            this.spreadsheet.ActiveWorksheet.Cells["F" + i].Value = item["应领数量"].ToString().TrimEnd('0');
            this.spreadsheet.ActiveWorksheet.Cells["F" + i].Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin);
            this.spreadsheet.ActiveWorksheet.Cells["G" + i].Value = item["缺料量"].ToString().TrimEnd('0');
            this.spreadsheet.ActiveWorksheet.Cells["G" + i].Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin);
            this.spreadsheet.ActiveWorksheet.Cells["H" + i].Value = (item["批次"] != null) ? item["批次"].ToString() : " ";
            this.spreadsheet.ActiveWorksheet.Cells["H" + i].Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin);
            this.spreadsheet.ActiveWorksheet.Cells["I" + i].Value = (item["库位"] != null) ? item["库位"].ToString() : " ";
            this.spreadsheet.ActiveWorksheet.Cells["I" + i].Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin);
            this.spreadsheet.ActiveWorksheet.Cells["J" + i].Value = (item["库位"] != null) ? item["库位"].ToString() : " ";
            this.spreadsheet.ActiveWorksheet.Cells["J" + i].Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.spreadsheet.ShowPrintPreview();
        }
    }
}
