namespace PDA_WMSClient
{
    partial class InStoreForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.txtVerifyCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStarge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVerifyCode
            // 
            this.txtVerifyCode.Location = new System.Drawing.Point(83, 191);
            this.txtVerifyCode.Name = "txtVerifyCode";
            this.txtVerifyCode.Size = new System.Drawing.Size(101, 23);
            this.txtVerifyCode.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.Text = "库位校验码：";
            // 
            // cmbAddress
            // 
            this.cmbAddress.Location = new System.Drawing.Point(83, 101);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(146, 23);
            this.cmbAddress.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.Text = "入库地址：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 21;
            this.button2.Text = "入库";
            this.button2.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "取消";
            this.button1.Click += new System.EventHandler(this.Cancle_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(83, 147);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(101, 23);
            this.txtCount.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.Text = "数量：";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(60, 12);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(169, 23);
            this.txtBarCode.TabIndex = 18;
            this.txtBarCode.Text = "2102004001151708010051";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.Text = "条码：";
            // 
            // cmbStarge
            // 
            this.cmbStarge.Location = new System.Drawing.Point(83, 58);
            this.cmbStarge.Name = "cmbStarge";
            this.cmbStarge.Size = new System.Drawing.Size(146, 23);
            this.cmbStarge.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.Text = "入库选项：";
            // 
            // InStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.txtVerifyCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStarge);
            this.Controls.Add(this.label1);
            this.Name = "InStoreForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtVerifyCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStarge;
        private System.Windows.Forms.Label label1;
    }
}

