namespace IVCurvometerTestTool
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.gbPortSet = new System.Windows.Forms.GroupBox();
			this.btnSwitchPort = new System.Windows.Forms.Button();
			this.cbStopBits = new System.Windows.Forms.ComboBox();
			this.lblStopBits = new System.Windows.Forms.Label();
			this.cbDataBits = new System.Windows.Forms.ComboBox();
			this.lblDataBits = new System.Windows.Forms.Label();
			this.cbParity = new System.Windows.Forms.ComboBox();
			this.lblParity = new System.Windows.Forms.Label();
			this.cbBaudRate = new System.Windows.Forms.ComboBox();
			this.lblBaudRate = new System.Windows.Forms.Label();
			this.cbPortName = new System.Windows.Forms.ComboBox();
			this.lblPortName = new System.Windows.Forms.Label();
			this.gbReceiveData = new System.Windows.Forms.GroupBox();
			this.lbReceiveData = new System.Windows.Forms.ListBox();
			this.gbControl = new System.Windows.Forms.GroupBox();
			this.lblTip = new System.Windows.Forms.Label();
			this.lalDateTime = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblTimesToDo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnStop = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTimes = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.gbSendData = new System.Windows.Forms.GroupBox();
			this.lbSendData = new System.Windows.Forms.ListBox();
			this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
			this.gbPortSet.SuspendLayout();
			this.gbReceiveData.SuspendLayout();
			this.gbControl.SuspendLayout();
			this.gbSendData.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbPortSet
			// 
			this.gbPortSet.BackColor = System.Drawing.SystemColors.Control;
			this.gbPortSet.Controls.Add(this.btnSwitchPort);
			this.gbPortSet.Controls.Add(this.cbStopBits);
			this.gbPortSet.Controls.Add(this.lblStopBits);
			this.gbPortSet.Controls.Add(this.cbDataBits);
			this.gbPortSet.Controls.Add(this.lblDataBits);
			this.gbPortSet.Controls.Add(this.cbParity);
			this.gbPortSet.Controls.Add(this.lblParity);
			this.gbPortSet.Controls.Add(this.cbBaudRate);
			this.gbPortSet.Controls.Add(this.lblBaudRate);
			this.gbPortSet.Controls.Add(this.cbPortName);
			this.gbPortSet.Controls.Add(this.lblPortName);
			this.gbPortSet.Location = new System.Drawing.Point(12, 12);
			this.gbPortSet.Name = "gbPortSet";
			this.gbPortSet.Size = new System.Drawing.Size(125, 192);
			this.gbPortSet.TabIndex = 0;
			this.gbPortSet.TabStop = false;
			this.gbPortSet.Text = "通讯设置";
			// 
			// btnSwitchPort
			// 
			this.btnSwitchPort.Location = new System.Drawing.Point(23, 158);
			this.btnSwitchPort.Name = "btnSwitchPort";
			this.btnSwitchPort.Size = new System.Drawing.Size(75, 23);
			this.btnSwitchPort.TabIndex = 10;
			this.btnSwitchPort.Text = "配置串口";
			this.btnSwitchPort.UseVisualStyleBackColor = true;
			this.btnSwitchPort.Click += new System.EventHandler(this.btnSwitchPort_Click);
			// 
			// cbStopBits
			// 
			this.cbStopBits.FormattingEnabled = true;
			this.cbStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
			this.cbStopBits.Location = new System.Drawing.Point(53, 132);
			this.cbStopBits.Name = "cbStopBits";
			this.cbStopBits.Size = new System.Drawing.Size(66, 20);
			this.cbStopBits.TabIndex = 9;
			this.cbStopBits.Text = "1";
			// 
			// lblStopBits
			// 
			this.lblStopBits.AutoSize = true;
			this.lblStopBits.Location = new System.Drawing.Point(6, 135);
			this.lblStopBits.Name = "lblStopBits";
			this.lblStopBits.Size = new System.Drawing.Size(41, 12);
			this.lblStopBits.TabIndex = 8;
			this.lblStopBits.Text = "停止位";
			// 
			// cbDataBits
			// 
			this.cbDataBits.FormattingEnabled = true;
			this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
			this.cbDataBits.Location = new System.Drawing.Point(53, 106);
			this.cbDataBits.Name = "cbDataBits";
			this.cbDataBits.Size = new System.Drawing.Size(66, 20);
			this.cbDataBits.TabIndex = 7;
			this.cbDataBits.Text = "8";
			// 
			// lblDataBits
			// 
			this.lblDataBits.AutoSize = true;
			this.lblDataBits.Location = new System.Drawing.Point(6, 109);
			this.lblDataBits.Name = "lblDataBits";
			this.lblDataBits.Size = new System.Drawing.Size(41, 12);
			this.lblDataBits.TabIndex = 6;
			this.lblDataBits.Text = "数据位";
			// 
			// cbParity
			// 
			this.cbParity.FormattingEnabled = true;
			this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
			this.cbParity.Location = new System.Drawing.Point(53, 80);
			this.cbParity.Name = "cbParity";
			this.cbParity.Size = new System.Drawing.Size(66, 20);
			this.cbParity.TabIndex = 5;
			this.cbParity.Text = "None";
			// 
			// lblParity
			// 
			this.lblParity.AutoSize = true;
			this.lblParity.Location = new System.Drawing.Point(6, 83);
			this.lblParity.Name = "lblParity";
			this.lblParity.Size = new System.Drawing.Size(41, 12);
			this.lblParity.TabIndex = 4;
			this.lblParity.Text = "校检位";
			// 
			// cbBaudRate
			// 
			this.cbBaudRate.FormattingEnabled = true;
			this.cbBaudRate.Items.AddRange(new object[] {
            "请使用Open [波特率] 命令"});
			this.cbBaudRate.Location = new System.Drawing.Point(53, 54);
			this.cbBaudRate.Name = "cbBaudRate";
			this.cbBaudRate.Size = new System.Drawing.Size(66, 20);
			this.cbBaudRate.TabIndex = 3;
			this.cbBaudRate.Text = "请使用Open [波特率] 命令";
			this.cbBaudRate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cbBaudRate_MouseUp);
			// 
			// lblBaudRate
			// 
			this.lblBaudRate.AutoSize = true;
			this.lblBaudRate.Location = new System.Drawing.Point(6, 57);
			this.lblBaudRate.Name = "lblBaudRate";
			this.lblBaudRate.Size = new System.Drawing.Size(41, 12);
			this.lblBaudRate.TabIndex = 2;
			this.lblBaudRate.Text = "波特率";
			// 
			// cbPortName
			// 
			this.cbPortName.FormattingEnabled = true;
			this.cbPortName.Items.AddRange(new object[] {
            "无可用"});
			this.cbPortName.Location = new System.Drawing.Point(53, 28);
			this.cbPortName.Name = "cbPortName";
			this.cbPortName.Size = new System.Drawing.Size(66, 20);
			this.cbPortName.TabIndex = 1;
			// 
			// lblPortName
			// 
			this.lblPortName.AutoSize = true;
			this.lblPortName.Location = new System.Drawing.Point(6, 31);
			this.lblPortName.Name = "lblPortName";
			this.lblPortName.Size = new System.Drawing.Size(41, 12);
			this.lblPortName.TabIndex = 0;
			this.lblPortName.Text = "串口号";
			// 
			// gbReceiveData
			// 
			this.gbReceiveData.Controls.Add(this.lbReceiveData);
			this.gbReceiveData.Location = new System.Drawing.Point(143, 12);
			this.gbReceiveData.Name = "gbReceiveData";
			this.gbReceiveData.Size = new System.Drawing.Size(616, 192);
			this.gbReceiveData.TabIndex = 1;
			this.gbReceiveData.TabStop = false;
			this.gbReceiveData.Text = "接收数据";
			// 
			// lbReceiveData
			// 
			this.lbReceiveData.FormattingEnabled = true;
			this.lbReceiveData.HorizontalScrollbar = true;
			this.lbReceiveData.ItemHeight = 12;
			this.lbReceiveData.Location = new System.Drawing.Point(6, 20);
			this.lbReceiveData.Name = "lbReceiveData";
			this.lbReceiveData.Size = new System.Drawing.Size(604, 160);
			this.lbReceiveData.TabIndex = 0;
			// 
			// gbControl
			// 
			this.gbControl.Controls.Add(this.lblTip);
			this.gbControl.Controls.Add(this.lalDateTime);
			this.gbControl.Controls.Add(this.label3);
			this.gbControl.Controls.Add(this.lblTimesToDo);
			this.gbControl.Controls.Add(this.label2);
			this.gbControl.Controls.Add(this.btnStop);
			this.gbControl.Controls.Add(this.label1);
			this.gbControl.Controls.Add(this.txtTimes);
			this.gbControl.Controls.Add(this.btnStart);
			this.gbControl.Location = new System.Drawing.Point(12, 361);
			this.gbControl.Name = "gbControl";
			this.gbControl.Size = new System.Drawing.Size(747, 231);
			this.gbControl.TabIndex = 6;
			this.gbControl.TabStop = false;
			this.gbControl.Text = "控制";
			// 
			// lblTip
			// 
			this.lblTip.AutoSize = true;
			this.lblTip.ForeColor = System.Drawing.Color.Red;
			this.lblTip.Location = new System.Drawing.Point(455, 108);
			this.lblTip.Name = "lblTip";
			this.lblTip.Size = new System.Drawing.Size(221, 12);
			this.lblTip.TabIndex = 8;
			this.lblTip.Text = "串口未配置，程序不会自动按下自动按钮";
			// 
			// lalDateTime
			// 
			this.lalDateTime.AutoSize = true;
			this.lalDateTime.Location = new System.Drawing.Point(514, 65);
			this.lalDateTime.Name = "lalDateTime";
			this.lalDateTime.Size = new System.Drawing.Size(53, 12);
			this.lalDateTime.TabIndex = 7;
			this.lalDateTime.Text = "DateTime";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(455, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "当前时间";
			// 
			// lblTimesToDo
			// 
			this.lblTimesToDo.AutoSize = true;
			this.lblTimesToDo.Location = new System.Drawing.Point(227, 108);
			this.lblTimesToDo.Name = "lblTimesToDo";
			this.lblTimesToDo.Size = new System.Drawing.Size(11, 12);
			this.lblTimesToDo.TabIndex = 5;
			this.lblTimesToDo.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(135, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "此轮剩余周期";
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(227, 184);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(100, 23);
			this.btnStop.TabIndex = 3;
			this.btnStop.Text = "剩余周期置零";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(135, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "每轮执行周期";
			// 
			// txtTimes
			// 
			this.txtTimes.Location = new System.Drawing.Point(227, 62);
			this.txtTimes.Name = "txtTimes";
			this.txtTimes.Size = new System.Drawing.Size(100, 21);
			this.txtTimes.TabIndex = 1;
			this.txtTimes.Text = "0";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(227, 145);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(100, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "启动";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// gbSendData
			// 
			this.gbSendData.Controls.Add(this.lbSendData);
			this.gbSendData.Location = new System.Drawing.Point(143, 210);
			this.gbSendData.Name = "gbSendData";
			this.gbSendData.Size = new System.Drawing.Size(614, 145);
			this.gbSendData.TabIndex = 2;
			this.gbSendData.TabStop = false;
			this.gbSendData.Text = "发送数据";
			// 
			// lbSendData
			// 
			this.lbSendData.FormattingEnabled = true;
			this.lbSendData.HorizontalScrollbar = true;
			this.lbSendData.ItemHeight = 12;
			this.lbSendData.Location = new System.Drawing.Point(6, 20);
			this.lbSendData.Name = "lbSendData";
			this.lbSendData.Size = new System.Drawing.Size(602, 112);
			this.lbSendData.TabIndex = 1;
			// 
			// tmrDateTime
			// 
			this.tmrDateTime.Interval = 1000;
			this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 604);
			this.Controls.Add(this.gbSendData);
			this.Controls.Add(this.gbControl);
			this.Controls.Add(this.gbReceiveData);
			this.Controls.Add(this.gbPortSet);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "串口命令自动发送接收器";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.gbPortSet.ResumeLayout(false);
			this.gbPortSet.PerformLayout();
			this.gbReceiveData.ResumeLayout(false);
			this.gbControl.ResumeLayout(false);
			this.gbControl.PerformLayout();
			this.gbSendData.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbPortSet;
		private System.Windows.Forms.ComboBox cbPortName;
		private System.Windows.Forms.Label lblPortName;
		private System.Windows.Forms.Button btnSwitchPort;
		private System.Windows.Forms.ComboBox cbStopBits;
		private System.Windows.Forms.Label lblStopBits;
		private System.Windows.Forms.ComboBox cbDataBits;
		private System.Windows.Forms.Label lblDataBits;
		private System.Windows.Forms.ComboBox cbParity;
		private System.Windows.Forms.Label lblParity;
		private System.Windows.Forms.ComboBox cbBaudRate;
		private System.Windows.Forms.Label lblBaudRate;
		private System.Windows.Forms.GroupBox gbReceiveData;
		private System.Windows.Forms.GroupBox gbControl;
		private System.Windows.Forms.GroupBox gbSendData;
		private System.Windows.Forms.ListBox lbReceiveData;
		private System.Windows.Forms.ListBox lbSendData;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTimes;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lblTip;
		private System.Windows.Forms.Label lalDateTime;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTimesToDo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer tmrDateTime;
	}
}