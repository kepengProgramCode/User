namespace JJECN_WMS.ArrriveRecordManager
{
    partial class Record
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.grideMes = new System.Windows.Forms.DataGridView();
            this.btnPrintBarcode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtArriveBarcode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grideMes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.grideMes);
            this.panel1.Controls.Add(this.btnPrintBarcode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 537);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文仿宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(42, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(612, 81);
            this.label2.TabIndex = 14;
            this.label2.Text = "操作提示：输入到货单号，点击【查询】，加载相关信息\r\n，在表格中修改对应的数据，所有数据修改完成以后，\r\n点击【打印】打印条码\r\n";
            // 
            // grideMes
            // 
            this.grideMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grideMes.Dock = System.Windows.Forms.DockStyle.Top;
            this.grideMes.Location = new System.Drawing.Point(0, 0);
            this.grideMes.Name = "grideMes";
            this.grideMes.RowTemplate.Height = 23;
            this.grideMes.Size = new System.Drawing.Size(1276, 421);
            this.grideMes.TabIndex = 0;
            // 
            // btnPrintBarcode
            // 
            this.btnPrintBarcode.Location = new System.Drawing.Point(1095, 447);
            this.btnPrintBarcode.Name = "btnPrintBarcode";
            this.btnPrintBarcode.Size = new System.Drawing.Size(128, 59);
            this.btnPrintBarcode.TabIndex = 13;
            this.btnPrintBarcode.Text = "打印条码";
            this.btnPrintBarcode.UseVisualStyleBackColor = true;
            this.btnPrintBarcode.Click += new System.EventHandler(this.btnPrintBarcode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文仿宋", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(278, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "到货单编号：";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(1035, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 55);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtArriveBarcode
            // 
            this.txtArriveBarcode.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtArriveBarcode.Location = new System.Drawing.Point(457, 61);
            this.txtArriveBarcode.Multiline = true;
            this.txtArriveBarcode.Name = "txtArriveBarcode";
            this.txtArriveBarcode.Size = new System.Drawing.Size(447, 42);
            this.txtArriveBarcode.TabIndex = 9;
            this.txtArriveBarcode.Text = "0000026681";
            this.txtArriveBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtArriveBarcode);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Record";
            this.Text = "到货记录及条码打印";
            this.Load += new System.EventHandler(this.ArriveRecord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grideMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtArriveBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintBarcode;
        private System.Windows.Forms.DataGridView grideMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}