namespace JJECN_WMS.DataBaseManager
{
    partial class ResizeStoreForm
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
            this.gridControlMessage = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtRowNumber = new System.Windows.Forms.TextBox();
            this.txtColumnNumber = new System.Windows.Forms.TextBox();
            this.txtLayerNumber = new System.Windows.Forms.TextBox();
            this.txtUsedStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbDel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStoreType = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 389);
            this.panel1.TabIndex = 0;
            // 
            // gridControlMessage
            // 
            this.gridControlMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMessage.Location = new System.Drawing.Point(0, 0);
            this.gridControlMessage.MainView = this.gridView1;
            this.gridControlMessage.Name = "gridControlMessage";
            this.gridControlMessage.Size = new System.Drawing.Size(1261, 389);
            this.gridControlMessage.TabIndex = 0;
            this.gridControlMessage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControlMessage;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "货架";
            this.gridColumn1.FieldName = "Row";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "货位";
            this.gridColumn2.FieldName = "Column";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "层数";
            this.gridColumn3.FieldName = "Layer";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "使用状态";
            this.gridColumn4.FieldName = "StoreStaus";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "库位类型";
            this.gridColumn6.FieldName = "Type";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // txtRowNumber
            // 
            this.txtRowNumber.Location = new System.Drawing.Point(161, 454);
            this.txtRowNumber.Name = "txtRowNumber";
            this.txtRowNumber.Size = new System.Drawing.Size(100, 21);
            this.txtRowNumber.TabIndex = 1;
            this.txtRowNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtColumnNumber
            // 
            this.txtColumnNumber.Location = new System.Drawing.Point(413, 454);
            this.txtColumnNumber.Name = "txtColumnNumber";
            this.txtColumnNumber.Size = new System.Drawing.Size(100, 21);
            this.txtColumnNumber.TabIndex = 2;
            this.txtColumnNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLayerNumber
            // 
            this.txtLayerNumber.Location = new System.Drawing.Point(659, 454);
            this.txtLayerNumber.Name = "txtLayerNumber";
            this.txtLayerNumber.Size = new System.Drawing.Size(100, 21);
            this.txtLayerNumber.TabIndex = 3;
            this.txtLayerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsedStatus
            // 
            this.txtUsedStatus.Location = new System.Drawing.Point(158, 521);
            this.txtUsedStatus.Name = "txtUsedStatus";
            this.txtUsedStatus.Size = new System.Drawing.Size(100, 21);
            this.txtUsedStatus.TabIndex = 5;
            this.txtUsedStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "货架号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "使用状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "货位号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "层数";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(847, 544);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 50);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1103, 544);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 50);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbDel
            // 
            this.cmbDel.FormattingEnabled = true;
            this.cmbDel.Location = new System.Drawing.Point(1072, 449);
            this.cmbDel.Name = "cmbDel";
            this.cmbDel.Size = new System.Drawing.Size(121, 20);
            this.cmbDel.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1007, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "删除选项";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "【库位类型:0：原材料库，1：半成品库，2：成品库】";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 526);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "库位类型";
            // 
            // txtStoreType
            // 
            this.txtStoreType.Location = new System.Drawing.Point(405, 523);
            this.txtStoreType.Name = "txtStoreType";
            this.txtStoreType.Size = new System.Drawing.Size(100, 21);
            this.txtStoreType.TabIndex = 19;
            this.txtStoreType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResizeStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 618);
            this.Controls.Add(this.txtStoreType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsedStatus);
            this.Controls.Add(this.txtLayerNumber);
            this.Controls.Add(this.txtColumnNumber);
            this.Controls.Add(this.txtRowNumber);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ResizeStoreForm";
            this.Text = "修改仓库结构";
            this.Load += new System.EventHandler(this.ResizeStoreForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlMessage;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.TextBox txtRowNumber;
        private System.Windows.Forms.TextBox txtColumnNumber;
        private System.Windows.Forms.TextBox txtLayerNumber;
        private System.Windows.Forms.TextBox txtUsedStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbDel;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStoreType;

    }
}