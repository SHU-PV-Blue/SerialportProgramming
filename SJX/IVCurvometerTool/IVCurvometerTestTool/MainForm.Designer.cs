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
			this.tcControl = new System.Windows.Forms.TabControl();
			this.tpHeartbeat = new System.Windows.Forms.TabPage();
			this.btnSwitchHeartbeat = new System.Windows.Forms.Button();
			this.txtHeartbeat = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tpSystem = new System.Windows.Forms.TabPage();
			this.tpSTC = new System.Windows.Forms.TabPage();
			this.tpSetI2C = new System.Windows.Forms.TabPage();
			this.tpGetI2C = new System.Windows.Forms.TabPage();
			this.tpSetData = new System.Windows.Forms.TabPage();
			this.tpGetData = new System.Windows.Forms.TabPage();
			this.tpMeasure = new System.Windows.Forms.TabPage();
			this.tpPageTips = new System.Windows.Forms.TabPage();
			this.tpMainPage = new System.Windows.Forms.TabPage();
			this.gbReceiveExplanation = new System.Windows.Forms.GroupBox();
			this.lbReceiveExplanation = new System.Windows.Forms.ListBox();
			this.gbSendData = new System.Windows.Forms.GroupBox();
			this.lbSendData = new System.Windows.Forms.ListBox();
			this.gbSendExplanation = new System.Windows.Forms.GroupBox();
			this.lbSendExplanation = new System.Windows.Forms.ListBox();
			this.lblTesterID = new System.Windows.Forms.Label();
			this.txtTesterID = new System.Windows.Forms.TextBox();
			this.btnTesterID = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gbPortSet.SuspendLayout();
			this.gbReceiveData.SuspendLayout();
			this.gbControl.SuspendLayout();
			this.tcControl.SuspendLayout();
			this.tpHeartbeat.SuspendLayout();
			this.gbReceiveExplanation.SuspendLayout();
			this.gbSendData.SuspendLayout();
			this.gbSendExplanation.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
			this.btnSwitchPort.Text = "打开串口";
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
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
			this.cbBaudRate.Location = new System.Drawing.Point(53, 54);
			this.cbBaudRate.Name = "cbBaudRate";
			this.cbBaudRate.Size = new System.Drawing.Size(66, 20);
			this.cbBaudRate.TabIndex = 3;
			this.cbBaudRate.Text = "9600";
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
			this.gbReceiveData.Size = new System.Drawing.Size(305, 192);
			this.gbReceiveData.TabIndex = 1;
			this.gbReceiveData.TabStop = false;
			this.gbReceiveData.Text = "接收数据";
			// 
			// lbReceiveData
			// 
			this.lbReceiveData.FormattingEnabled = true;
			this.lbReceiveData.ItemHeight = 12;
			this.lbReceiveData.Location = new System.Drawing.Point(6, 20);
			this.lbReceiveData.Name = "lbReceiveData";
			this.lbReceiveData.Size = new System.Drawing.Size(293, 160);
			this.lbReceiveData.TabIndex = 0;
			// 
			// gbControl
			// 
			this.gbControl.Controls.Add(this.tcControl);
			this.gbControl.Location = new System.Drawing.Point(12, 361);
			this.gbControl.Name = "gbControl";
			this.gbControl.Size = new System.Drawing.Size(747, 231);
			this.gbControl.TabIndex = 6;
			this.gbControl.TabStop = false;
			this.gbControl.Text = "控制";
			// 
			// tcControl
			// 
			this.tcControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tcControl.Controls.Add(this.tpHeartbeat);
			this.tcControl.Controls.Add(this.tpSystem);
			this.tcControl.Controls.Add(this.tpSTC);
			this.tcControl.Controls.Add(this.tpSetI2C);
			this.tcControl.Controls.Add(this.tpGetI2C);
			this.tcControl.Controls.Add(this.tpSetData);
			this.tcControl.Controls.Add(this.tpGetData);
			this.tcControl.Controls.Add(this.tpMeasure);
			this.tcControl.Controls.Add(this.tpPageTips);
			this.tcControl.Controls.Add(this.tpMainPage);
			this.tcControl.Location = new System.Drawing.Point(6, 20);
			this.tcControl.Name = "tcControl";
			this.tcControl.SelectedIndex = 0;
			this.tcControl.Size = new System.Drawing.Size(735, 205);
			this.tcControl.TabIndex = 14;
			// 
			// tpHeartbeat
			// 
			this.tpHeartbeat.Controls.Add(this.btnSwitchHeartbeat);
			this.tpHeartbeat.Controls.Add(this.txtHeartbeat);
			this.tpHeartbeat.Controls.Add(this.label1);
			this.tpHeartbeat.Location = new System.Drawing.Point(4, 22);
			this.tpHeartbeat.Name = "tpHeartbeat";
			this.tpHeartbeat.Padding = new System.Windows.Forms.Padding(3);
			this.tpHeartbeat.Size = new System.Drawing.Size(727, 179);
			this.tpHeartbeat.TabIndex = 0;
			this.tpHeartbeat.Text = "心跳包";
			this.tpHeartbeat.UseVisualStyleBackColor = true;
			// 
			// btnSwitchHeartbeat
			// 
			this.btnSwitchHeartbeat.Location = new System.Drawing.Point(448, 83);
			this.btnSwitchHeartbeat.Name = "btnSwitchHeartbeat";
			this.btnSwitchHeartbeat.Size = new System.Drawing.Size(75, 23);
			this.btnSwitchHeartbeat.TabIndex = 17;
			this.btnSwitchHeartbeat.Text = "开始";
			this.btnSwitchHeartbeat.UseVisualStyleBackColor = true;
			this.btnSwitchHeartbeat.Click += new System.EventHandler(this.btnSwitchHeartbeat_Click);
			// 
			// txtHeartbeat
			// 
			this.txtHeartbeat.Location = new System.Drawing.Point(310, 85);
			this.txtHeartbeat.Name = "txtHeartbeat";
			this.txtHeartbeat.Size = new System.Drawing.Size(122, 21);
			this.txtHeartbeat.TabIndex = 16;
			this.txtHeartbeat.Text = "1000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(191, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 12);
			this.label1.TabIndex = 15;
			this.label1.Text = "设置心跳包周期(ms)";
			// 
			// tpSystem
			// 
			this.tpSystem.Location = new System.Drawing.Point(4, 22);
			this.tpSystem.Name = "tpSystem";
			this.tpSystem.Padding = new System.Windows.Forms.Padding(3);
			this.tpSystem.Size = new System.Drawing.Size(727, 179);
			this.tpSystem.TabIndex = 1;
			this.tpSystem.Text = "系统命令";
			this.tpSystem.UseVisualStyleBackColor = true;
			// 
			// tpSTC
			// 
			this.tpSTC.Location = new System.Drawing.Point(4, 22);
			this.tpSTC.Name = "tpSTC";
			this.tpSTC.Size = new System.Drawing.Size(727, 179);
			this.tpSTC.TabIndex = 2;
			this.tpSTC.Text = "STC命令";
			this.tpSTC.UseVisualStyleBackColor = true;
			// 
			// tpSetI2C
			// 
			this.tpSetI2C.Location = new System.Drawing.Point(4, 22);
			this.tpSetI2C.Name = "tpSetI2C";
			this.tpSetI2C.Size = new System.Drawing.Size(727, 179);
			this.tpSetI2C.TabIndex = 3;
			this.tpSetI2C.Text = "设置I2C";
			this.tpSetI2C.UseVisualStyleBackColor = true;
			// 
			// tpGetI2C
			// 
			this.tpGetI2C.Location = new System.Drawing.Point(4, 22);
			this.tpGetI2C.Name = "tpGetI2C";
			this.tpGetI2C.Size = new System.Drawing.Size(727, 179);
			this.tpGetI2C.TabIndex = 4;
			this.tpGetI2C.Text = "查询I2C";
			this.tpGetI2C.UseVisualStyleBackColor = true;
			// 
			// tpSetData
			// 
			this.tpSetData.Location = new System.Drawing.Point(4, 22);
			this.tpSetData.Name = "tpSetData";
			this.tpSetData.Size = new System.Drawing.Size(727, 179);
			this.tpSetData.TabIndex = 5;
			this.tpSetData.Text = "设置数据";
			this.tpSetData.UseVisualStyleBackColor = true;
			// 
			// tpGetData
			// 
			this.tpGetData.Location = new System.Drawing.Point(4, 22);
			this.tpGetData.Name = "tpGetData";
			this.tpGetData.Size = new System.Drawing.Size(727, 179);
			this.tpGetData.TabIndex = 6;
			this.tpGetData.Text = "查询数据";
			this.tpGetData.UseVisualStyleBackColor = true;
			// 
			// tpMeasure
			// 
			this.tpMeasure.Location = new System.Drawing.Point(4, 22);
			this.tpMeasure.Name = "tpMeasure";
			this.tpMeasure.Size = new System.Drawing.Size(727, 179);
			this.tpMeasure.TabIndex = 7;
			this.tpMeasure.Text = "测量数据";
			this.tpMeasure.UseVisualStyleBackColor = true;
			// 
			// tpPageTips
			// 
			this.tpPageTips.Location = new System.Drawing.Point(4, 22);
			this.tpPageTips.Name = "tpPageTips";
			this.tpPageTips.Size = new System.Drawing.Size(727, 179);
			this.tpPageTips.TabIndex = 8;
			this.tpPageTips.Text = "页面提示";
			this.tpPageTips.UseVisualStyleBackColor = true;
			// 
			// tpMainPage
			// 
			this.tpMainPage.Location = new System.Drawing.Point(4, 22);
			this.tpMainPage.Name = "tpMainPage";
			this.tpMainPage.Size = new System.Drawing.Size(727, 179);
			this.tpMainPage.TabIndex = 9;
			this.tpMainPage.Text = "主页面";
			this.tpMainPage.UseVisualStyleBackColor = true;
			// 
			// gbReceiveExplanation
			// 
			this.gbReceiveExplanation.Controls.Add(this.lbReceiveExplanation);
			this.gbReceiveExplanation.Location = new System.Drawing.Point(454, 12);
			this.gbReceiveExplanation.Name = "gbReceiveExplanation";
			this.gbReceiveExplanation.Size = new System.Drawing.Size(305, 192);
			this.gbReceiveExplanation.TabIndex = 15;
			this.gbReceiveExplanation.TabStop = false;
			this.gbReceiveExplanation.Text = "接收数据解析";
			// 
			// lbReceiveExplanation
			// 
			this.lbReceiveExplanation.FormattingEnabled = true;
			this.lbReceiveExplanation.ItemHeight = 12;
			this.lbReceiveExplanation.Location = new System.Drawing.Point(6, 20);
			this.lbReceiveExplanation.Name = "lbReceiveExplanation";
			this.lbReceiveExplanation.Size = new System.Drawing.Size(293, 160);
			this.lbReceiveExplanation.TabIndex = 1;
			// 
			// gbSendData
			// 
			this.gbSendData.Controls.Add(this.lbSendData);
			this.gbSendData.Location = new System.Drawing.Point(143, 210);
			this.gbSendData.Name = "gbSendData";
			this.gbSendData.Size = new System.Drawing.Size(305, 145);
			this.gbSendData.TabIndex = 2;
			this.gbSendData.TabStop = false;
			this.gbSendData.Text = "发送数据";
			// 
			// lbSendData
			// 
			this.lbSendData.FormattingEnabled = true;
			this.lbSendData.ItemHeight = 12;
			this.lbSendData.Location = new System.Drawing.Point(6, 20);
			this.lbSendData.Name = "lbSendData";
			this.lbSendData.Size = new System.Drawing.Size(293, 112);
			this.lbSendData.TabIndex = 1;
			// 
			// gbSendExplanation
			// 
			this.gbSendExplanation.Controls.Add(this.lbSendExplanation);
			this.gbSendExplanation.Location = new System.Drawing.Point(454, 210);
			this.gbSendExplanation.Name = "gbSendExplanation";
			this.gbSendExplanation.Size = new System.Drawing.Size(305, 145);
			this.gbSendExplanation.TabIndex = 16;
			this.gbSendExplanation.TabStop = false;
			this.gbSendExplanation.Text = "发送数据解析";
			// 
			// lbSendExplanation
			// 
			this.lbSendExplanation.FormattingEnabled = true;
			this.lbSendExplanation.ItemHeight = 12;
			this.lbSendExplanation.Location = new System.Drawing.Point(6, 20);
			this.lbSendExplanation.Name = "lbSendExplanation";
			this.lbSendExplanation.Size = new System.Drawing.Size(293, 112);
			this.lbSendExplanation.TabIndex = 2;
			// 
			// lblTesterID
			// 
			this.lblTesterID.AutoSize = true;
			this.lblTesterID.Location = new System.Drawing.Point(21, 30);
			this.lblTesterID.Name = "lblTesterID";
			this.lblTesterID.Size = new System.Drawing.Size(77, 12);
			this.lblTesterID.TabIndex = 12;
			this.lblTesterID.Text = "设置测试仪ID";
			// 
			// txtTesterID
			// 
			this.txtTesterID.Location = new System.Drawing.Point(23, 57);
			this.txtTesterID.Name = "txtTesterID";
			this.txtTesterID.Size = new System.Drawing.Size(75, 21);
			this.txtTesterID.TabIndex = 13;
			this.txtTesterID.Text = "00";
			// 
			// btnTesterID
			// 
			this.btnTesterID.Location = new System.Drawing.Point(23, 93);
			this.btnTesterID.Name = "btnTesterID";
			this.btnTesterID.Size = new System.Drawing.Size(75, 23);
			this.btnTesterID.TabIndex = 14;
			this.btnTesterID.Text = "确认";
			this.btnTesterID.UseVisualStyleBackColor = true;
			this.btnTesterID.Click += new System.EventHandler(this.btnTesterID_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnTesterID);
			this.groupBox1.Controls.Add(this.lblTesterID);
			this.groupBox1.Controls.Add(this.txtTesterID);
			this.groupBox1.Location = new System.Drawing.Point(12, 210);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(125, 145);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "测试仪选择";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 604);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbSendExplanation);
			this.Controls.Add(this.gbSendData);
			this.Controls.Add(this.gbReceiveExplanation);
			this.Controls.Add(this.gbControl);
			this.Controls.Add(this.gbReceiveData);
			this.Controls.Add(this.gbPortSet);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IV曲线仪通讯测试";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.gbPortSet.ResumeLayout(false);
			this.gbPortSet.PerformLayout();
			this.gbReceiveData.ResumeLayout(false);
			this.gbControl.ResumeLayout(false);
			this.tcControl.ResumeLayout(false);
			this.tpHeartbeat.ResumeLayout(false);
			this.tpHeartbeat.PerformLayout();
			this.gbReceiveExplanation.ResumeLayout(false);
			this.gbSendData.ResumeLayout(false);
			this.gbSendExplanation.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
		private System.Windows.Forms.GroupBox gbReceiveExplanation;
		private System.Windows.Forms.GroupBox gbSendData;
		private System.Windows.Forms.GroupBox gbSendExplanation;
		private System.Windows.Forms.TabControl tcControl;
		private System.Windows.Forms.TextBox txtTesterID;
		private System.Windows.Forms.Label lblTesterID;
		private System.Windows.Forms.TabPage tpHeartbeat;
		private System.Windows.Forms.TabPage tpSystem;
		private System.Windows.Forms.TabPage tpSTC;
		private System.Windows.Forms.TabPage tpSetI2C;
		private System.Windows.Forms.TabPage tpGetI2C;
		private System.Windows.Forms.TabPage tpSetData;
		private System.Windows.Forms.TabPage tpGetData;
		private System.Windows.Forms.TabPage tpMeasure;
		private System.Windows.Forms.TabPage tpPageTips;
		private System.Windows.Forms.TabPage tpMainPage;
		private System.Windows.Forms.Button btnTesterID;
		private System.Windows.Forms.Button btnSwitchHeartbeat;
		private System.Windows.Forms.TextBox txtHeartbeat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox lbReceiveData;
		private System.Windows.Forms.ListBox lbReceiveExplanation;
		private System.Windows.Forms.ListBox lbSendData;
		private System.Windows.Forms.ListBox lbSendExplanation;
	}
}