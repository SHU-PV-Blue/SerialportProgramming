namespace SerialDemo_1
{
	partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSetParam = new System.Windows.Forms.Button();
			this.cmbParity = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbStopBit = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbDataBit = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbBaudRate = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbPorts = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRecive = new System.Windows.Forms.TextBox();
			this.txtSend = new System.Windows.Forms.TextBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSend = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnInit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnInit);
			this.groupBox1.Controls.Add(this.btnSetParam);
			this.groupBox1.Controls.Add(this.cmbParity);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cmbStopBit);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cmbDataBit);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cmbBaudRate);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cmbPorts);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = System.Drawing.Color.Orange;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(226, 257);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "设置";
			// 
			// btnSetParam
			// 
			this.btnSetParam.Location = new System.Drawing.Point(12, 208);
			this.btnSetParam.Name = "btnSetParam";
			this.btnSetParam.Size = new System.Drawing.Size(76, 30);
			this.btnSetParam.TabIndex = 2;
			this.btnSetParam.Text = "应用设置";
			this.btnSetParam.UseVisualStyleBackColor = true;
			this.btnSetParam.Click += new System.EventHandler(this.btnSetParam_Click);
			// 
			// cmbParity
			// 
			this.cmbParity.FormattingEnabled = true;
			this.cmbParity.Items.AddRange(new object[] {
            "无"});
			this.cmbParity.Location = new System.Drawing.Point(80, 153);
			this.cmbParity.Name = "cmbParity";
			this.cmbParity.Size = new System.Drawing.Size(121, 20);
			this.cmbParity.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(12, 153);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "校验位";
			// 
			// cmbStopBit
			// 
			this.cmbStopBit.FormattingEnabled = true;
			this.cmbStopBit.Items.AddRange(new object[] {
            "1"});
			this.cmbStopBit.Location = new System.Drawing.Point(80, 127);
			this.cmbStopBit.Name = "cmbStopBit";
			this.cmbStopBit.Size = new System.Drawing.Size(121, 20);
			this.cmbStopBit.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(12, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "停止位 :  ";
			// 
			// cmbDataBit
			// 
			this.cmbDataBit.FormattingEnabled = true;
			this.cmbDataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
			this.cmbDataBit.Location = new System.Drawing.Point(80, 101);
			this.cmbDataBit.Name = "cmbDataBit";
			this.cmbDataBit.Size = new System.Drawing.Size(121, 20);
			this.cmbDataBit.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(12, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "数据位 : ";
			// 
			// cmbBaudRate
			// 
			this.cmbBaudRate.FormattingEnabled = true;
			this.cmbBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "4800",
            "2400",
            "1200"});
			this.cmbBaudRate.Location = new System.Drawing.Point(80, 75);
			this.cmbBaudRate.Name = "cmbBaudRate";
			this.cmbBaudRate.Size = new System.Drawing.Size(121, 20);
			this.cmbBaudRate.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(12, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "波特率 : ";
			// 
			// cmbPorts
			// 
			this.cmbPorts.FormattingEnabled = true;
			this.cmbPorts.Location = new System.Drawing.Point(80, 49);
			this.cmbPorts.Name = "cmbPorts";
			this.cmbPorts.Size = new System.Drawing.Size(121, 20);
			this.cmbPorts.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(12, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "串口号 : ";
			// 
			// txtRecive
			// 
			this.txtRecive.Location = new System.Drawing.Point(232, 31);
			this.txtRecive.Multiline = true;
			this.txtRecive.Name = "txtRecive";
			this.txtRecive.Size = new System.Drawing.Size(405, 142);
			this.txtRecive.TabIndex = 1;
			// 
			// txtSend
			// 
			this.txtSend.Location = new System.Drawing.Point(232, 195);
			this.txtSend.Name = "txtSend";
			this.txtSend.Size = new System.Drawing.Size(340, 21);
			this.txtSend.TabIndex = 1;
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(12, 279);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(59, 38);
			this.btnOpen.TabIndex = 3;
			this.btnOpen.Text = "打开";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(80, 279);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(59, 38);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(578, 195);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(59, 21);
			this.btnSend.TabIndex = 5;
			this.btnSend.Text = "发送";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(155, 279);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(59, 38);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "退出";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnInit
			// 
			this.btnInit.Location = new System.Drawing.Point(109, 208);
			this.btnInit.Name = "btnInit";
			this.btnInit.Size = new System.Drawing.Size(82, 30);
			this.btnInit.TabIndex = 2;
			this.btnInit.Text = "初始化参数";
			this.btnInit.UseVisualStyleBackColor = true;
			this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 399);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.txtSend);
			this.Controls.Add(this.txtRecive);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSetParam;
		private System.Windows.Forms.ComboBox cmbParity;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbStopBit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbDataBit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbBaudRate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbPorts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRecive;
		private System.Windows.Forms.TextBox txtSend;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnInit;
	}
}

