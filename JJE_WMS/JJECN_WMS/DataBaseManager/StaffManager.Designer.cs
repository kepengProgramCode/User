namespace JJECN_WMS.DataBaseManager
{
    partial class StaffManager
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
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.txtDelStaffAccess = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDelStaffName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDelAllStaff = new System.Windows.Forms.Button();
            this.btnDelStaff = new System.Windows.Forms.Button();
            this.cmbDeletestaffnumber = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnResize = new System.Windows.Forms.Button();
            this.txtRemark_Resize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbStaffNumber = new System.Windows.Forms.ComboBox();
            this.cmbAccessOperation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName_Resize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword_Resize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAccess = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStaffPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStaffNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 329);
            this.panel1.TabIndex = 1;
            // 
            // gridControlMessage
            // 
            this.gridControlMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMessage.Location = new System.Drawing.Point(0, 0);
            this.gridControlMessage.MainView = this.gridView1;
            this.gridControlMessage.Name = "gridControlMessage";
            this.gridControlMessage.Size = new System.Drawing.Size(1287, 329);
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
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControlMessage;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "员工工号";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "密码";
            this.gridColumn2.FieldName = "Password";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "姓名";
            this.gridColumn3.FieldName = "Name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "权限";
            this.gridColumn4.FieldName = "Access";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "备注";
            this.gridColumn5.FieldName = "Remark";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.txtDelStaffAccess);
            this.xtraTabPage3.Controls.Add(this.label12);
            this.xtraTabPage3.Controls.Add(this.txtDelStaffName);
            this.xtraTabPage3.Controls.Add(this.label13);
            this.xtraTabPage3.Controls.Add(this.btnDelAllStaff);
            this.xtraTabPage3.Controls.Add(this.btnDelStaff);
            this.xtraTabPage3.Controls.Add(this.cmbDeletestaffnumber);
            this.xtraTabPage3.Controls.Add(this.label11);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1281, 280);
            this.xtraTabPage3.Text = "删除人员信息";
            // 
            // txtDelStaffAccess
            // 
            this.txtDelStaffAccess.Location = new System.Drawing.Point(924, 80);
            this.txtDelStaffAccess.Name = "txtDelStaffAccess";
            this.txtDelStaffAccess.Size = new System.Drawing.Size(165, 21);
            this.txtDelStaffAccess.TabIndex = 25;
            this.txtDelStaffAccess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(868, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "权限";
            // 
            // txtDelStaffName
            // 
            this.txtDelStaffName.Location = new System.Drawing.Point(630, 82);
            this.txtDelStaffName.Name = "txtDelStaffName";
            this.txtDelStaffName.Size = new System.Drawing.Size(165, 21);
            this.txtDelStaffName.TabIndex = 23;
            this.txtDelStaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(578, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 22;
            this.label13.Text = "姓名";
            // 
            // btnDelAllStaff
            // 
            this.btnDelAllStaff.Location = new System.Drawing.Point(734, 180);
            this.btnDelAllStaff.Name = "btnDelAllStaff";
            this.btnDelAllStaff.Size = new System.Drawing.Size(107, 53);
            this.btnDelAllStaff.TabIndex = 21;
            this.btnDelAllStaff.Text = "删除全部用户";
            this.btnDelAllStaff.UseVisualStyleBackColor = true;
            this.btnDelAllStaff.Click += new System.EventHandler(this.btnDelAllStaff_Click);
            // 
            // btnDelStaff
            // 
            this.btnDelStaff.Location = new System.Drawing.Point(402, 180);
            this.btnDelStaff.Name = "btnDelStaff";
            this.btnDelStaff.Size = new System.Drawing.Size(107, 53);
            this.btnDelStaff.TabIndex = 20;
            this.btnDelStaff.Text = "删除用户";
            this.btnDelStaff.UseVisualStyleBackColor = true;
            this.btnDelStaff.Click += new System.EventHandler(this.btnDelStaff_Click);
            // 
            // cmbDeletestaffnumber
            // 
            this.cmbDeletestaffnumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeletestaffnumber.FormattingEnabled = true;
            this.cmbDeletestaffnumber.Location = new System.Drawing.Point(351, 83);
            this.cmbDeletestaffnumber.Name = "cmbDeletestaffnumber";
            this.cmbDeletestaffnumber.Size = new System.Drawing.Size(172, 20);
            this.cmbDeletestaffnumber.TabIndex = 18;
            this.cmbDeletestaffnumber.SelectedIndexChanged += new System.EventHandler(this.cmbDeletestaffnumber_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "员工工号";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnResize);
            this.xtraTabPage2.Controls.Add(this.txtRemark_Resize);
            this.xtraTabPage2.Controls.Add(this.label10);
            this.xtraTabPage2.Controls.Add(this.cmbStaffNumber);
            this.xtraTabPage2.Controls.Add(this.cmbAccessOperation);
            this.xtraTabPage2.Controls.Add(this.label6);
            this.xtraTabPage2.Controls.Add(this.txtName_Resize);
            this.xtraTabPage2.Controls.Add(this.label7);
            this.xtraTabPage2.Controls.Add(this.txtPassword_Resize);
            this.xtraTabPage2.Controls.Add(this.label8);
            this.xtraTabPage2.Controls.Add(this.label9);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1281, 280);
            this.xtraTabPage2.Text = "修改人员信息";
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(986, 182);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(107, 53);
            this.btnResize.TabIndex = 19;
            this.btnResize.Text = "确认修改";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // txtRemark_Resize
            // 
            this.txtRemark_Resize.Location = new System.Drawing.Point(876, 84);
            this.txtRemark_Resize.Name = "txtRemark_Resize";
            this.txtRemark_Resize.Size = new System.Drawing.Size(310, 21);
            this.txtRemark_Resize.TabIndex = 18;
            this.txtRemark_Resize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(807, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "备注";
            // 
            // cmbStaffNumber
            // 
            this.cmbStaffNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaffNumber.FormattingEnabled = true;
            this.cmbStaffNumber.Location = new System.Drawing.Point(289, 84);
            this.cmbStaffNumber.Name = "cmbStaffNumber";
            this.cmbStaffNumber.Size = new System.Drawing.Size(172, 20);
            this.cmbStaffNumber.TabIndex = 16;
            this.cmbStaffNumber.SelectedIndexChanged += new System.EventHandler(this.cmbStaffNumber_SelectedIndexChanged);
            // 
            // cmbAccessOperation
            // 
            this.cmbAccessOperation.FormattingEnabled = true;
            this.cmbAccessOperation.Location = new System.Drawing.Point(579, 179);
            this.cmbAccessOperation.Name = "cmbAccessOperation";
            this.cmbAccessOperation.Size = new System.Drawing.Size(172, 20);
            this.cmbAccessOperation.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "权限";
            // 
            // txtName_Resize
            // 
            this.txtName_Resize.Location = new System.Drawing.Point(289, 179);
            this.txtName_Resize.Name = "txtName_Resize";
            this.txtName_Resize.Size = new System.Drawing.Size(165, 21);
            this.txtName_Resize.TabIndex = 13;
            this.txtName_Resize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "姓名";
            // 
            // txtPassword_Resize
            // 
            this.txtPassword_Resize.Location = new System.Drawing.Point(579, 84);
            this.txtPassword_Resize.Name = "txtPassword_Resize";
            this.txtPassword_Resize.Size = new System.Drawing.Size(172, 21);
            this.txtPassword_Resize.TabIndex = 11;
            this.txtPassword_Resize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "密码";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "员工工号";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnCancle);
            this.xtraTabPage1.Controls.Add(this.btnAdd);
            this.xtraTabPage1.Controls.Add(this.txtRemark);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Controls.Add(this.cmbAccess);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.txtStaffName);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.txtStaffPassword);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txtStaffNumber);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1281, 280);
            this.xtraTabPage1.Text = "增加人员信息";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(1086, 194);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(100, 53);
            this.btnCancle.TabIndex = 11;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(876, 194);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 53);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(876, 91);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(310, 21);
            this.txtRemark.TabIndex = 9;
            this.txtRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(807, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "备注";
            // 
            // cmbAccess
            // 
            this.cmbAccess.FormattingEnabled = true;
            this.cmbAccess.Location = new System.Drawing.Point(553, 183);
            this.cmbAccess.Name = "cmbAccess";
            this.cmbAccess.Size = new System.Drawing.Size(172, 20);
            this.cmbAccess.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "权限";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(263, 183);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(165, 21);
            this.txtStaffName.TabIndex = 5;
            this.txtStaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓名";
            // 
            // txtStaffPassword
            // 
            this.txtStaffPassword.Location = new System.Drawing.Point(553, 88);
            this.txtStaffPassword.Name = "txtStaffPassword";
            this.txtStaffPassword.PasswordChar = '*';
            this.txtStaffPassword.Size = new System.Drawing.Size(172, 21);
            this.txtStaffPassword.TabIndex = 3;
            this.txtStaffPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // txtStaffNumber
            // 
            this.txtStaffNumber.Location = new System.Drawing.Point(263, 88);
            this.txtStaffNumber.Name = "txtStaffNumber";
            this.txtStaffNumber.Size = new System.Drawing.Size(165, 21);
            this.txtStaffNumber.TabIndex = 1;
            this.txtStaffNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工工号";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 329);
            this.xtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1287, 309);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // StaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 638);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "StaffManager";
            this.Text = "人员管理";
            this.Load += new System.EventHandler(this.StaffManager_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlMessage;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAccess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStaffNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.TextBox txtRemark_Resize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbStaffNumber;
        private System.Windows.Forms.ComboBox cmbAccessOperation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName_Resize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword_Resize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelAllStaff;
        private System.Windows.Forms.Button btnDelStaff;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDelStaffAccess;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDelStaffName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbDeletestaffnumber;

    }
}