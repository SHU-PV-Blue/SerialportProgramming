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
			this.gbStatusLog = new System.Windows.Forms.GroupBox();
			this.gbControl = new System.Windows.Forms.GroupBox();
			this.lbStatusLog = new System.Windows.Forms.ListBox();
			this.gbReceiveExplanation = new System.Windows.Forms.GroupBox();
			this.gbSendData = new System.Windows.Forms.GroupBox();
			this.gbSendExplanation = new System.Windows.Forms.GroupBox();
			this.tpMainPage = new System.Windows.Forms.TabPage();
			this.tpPageTips = new System.Windows.Forms.TabPage();
			this.tpMeasure = new System.Windows.Forms.TabPage();
			this.tpGetData = new System.Windows.Forms.TabPage();
			this.tpSetData = new System.Windows.Forms.TabPage();
			this.tpGetI2C = new System.Windows.Forms.TabPage();
			this.tpSetI2C = new System.Windows.Forms.TabPage();
			this.tpSTC = new System.Windows.Forms.TabPage();
			this.tpSystem = new System.Windows.Forms.TabPage();
			this.tpHeartbeat = new System.Windows.Forms.TabPage();
			this.tcControl = new System.Windows.Forms.TabControl();
			this.tpTesterID = new System.Windows.Forms.TabPage();
			this.lblTesterID = new System.Windows.Forms.Label();
			this.txtTesterID = new System.Windows.Forms.TextBox();
			this.btnTesterID = new System.Windows.Forms.Button();
			this.btnSwitchHeartbeat = new System.Windows.Forms.Button();
			this.txtHeartbeat = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gbPortSet.SuspendLayout();
			this.gbStatusLog.SuspendLayout();
			this.gbControl.SuspendLayout();
			this.tpHeartbeat.SuspendLayout();
			this.tcControl.SuspendLayout();
			this.tpTesterID.SuspendLayout();
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
			// 
			// cbStopBits
			// 
			this.cbStopBits.FormattingEnabled = true;
			this.cbStopBits.Items.AddRange(new object[] {
            "COM1",
            "无校检"});
			this.cbStopBits.Location = new System.Drawing.Point(53, 132);
			this.cbStopBits.Name = "cbStopBits";
			this.cbStopBits.Size = new System.Drawing.Size(66, 20);
			this.cbStopBits.TabIndex = 9;
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
            "COM1",
            "无校检"});
			this.cbDataBits.Location = new System.Drawing.Point(53, 106);
			this.cbDataBits.Name = "cbDataBits";
			this.cbDataBits.Size = new System.Drawing.Size(66, 20);
			this.cbDataBits.TabIndex = 7;
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
            "COM1",
            "无校检"});
			this.cbParity.Location = new System.Drawing.Point(53, 80);
			this.cbParity.Name = "cbParity";
			this.cbParity.Size = new System.Drawing.Size(66, 20);
			this.cbParity.TabIndex = 5;
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
            "COM1",
            "无校检"});
			this.cbBaudRate.Location = new System.Drawing.Point(53, 54);
			this.cbBaudRate.Name = "cbBaudRate";
			this.cbBaudRate.Size = new System.Drawing.Size(66, 20);
			this.cbBaudRate.TabIndex = 3;
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
            "COM1",
            "无校检"});
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
			this.gbReceiveData.Location = new System.Drawing.Point(143, 12);
			this.gbReceiveData.Name = "gbReceiveData";
			this.gbReceiveData.Size = new System.Drawing.Size(305, 192);
			this.gbReceiveData.TabIndex = 1;
			this.gbReceiveData.TabStop = false;
			this.gbReceiveData.Text = "接收数据";
			// 
			// gbStatusLog
			// 
			this.gbStatusLog.Controls.Add(this.lbStatusLog);
			this.gbStatusLog.Location = new System.Drawing.Point(12, 210);
			this.gbStatusLog.Name = "gbStatusLog";
			this.gbStatusLog.Size = new System.Drawing.Size(125, 368);
			this.gbStatusLog.TabIndex = 3;
			this.gbStatusLog.TabStop = false;
			this.gbStatusLog.Text = "状态记录";
			// 
			// gbControl
			// 
			this.gbControl.Controls.Add(this.tcControl);
			this.gbControl.Location = new System.Drawing.Point(143, 361);
			this.gbControl.Name = "gbControl";
			this.gbControl.Size = new System.Drawing.Size(616, 217);
			this.gbControl.TabIndex = 6;
			this.gbControl.TabStop = false;
			this.gbControl.Text = "控制";
			// 
			// lbStatusLog
			// 
			this.lbStatusLog.FormattingEnabled = true;
			this.lbStatusLog.ItemHeight = 12;
			this.lbStatusLog.Location = new System.Drawing.Point(6, 20);
			this.lbStatusLog.Name = "lbStatusLog";
			this.lbStatusLog.Size = new System.Drawing.Size(113, 340);
			this.lbStatusLog.TabIndex = 0;
			// 
			// gbReceiveExplanation
			// 
			this.gbReceiveExplanation.Location = new System.Drawing.Point(454, 12);
			this.gbReceiveExplanation.Name = "gbReceiveExplanation";
			this.gbReceiveExplanation.Size = new System.Drawing.Size(305, 192);
			this.gbReceiveExplanation.TabIndex = 15;
			this.gbReceiveExplanation.TabStop = false;
			this.gbReceiveExplanation.Text = "接收数据解析";
			// 
			// gbSendData
			// 
			this.gbSendData.Location = new System.Drawing.Point(143, 210);
			this.gbSendData.Name = "gbSendData";
			this.gbSendData.Size = new System.Drawing.Size(305, 145);
			this.gbSendData.TabIndex = 2;
			this.gbSendData.TabStop = false;
			this.gbSendData.Text = "发送数据";
			// 
			// gbSendExplanation
			// 
			this.gbSendExplanation.Location = new System.Drawing.Point(454, 210);
			this.gbSendExplanation.Name = "gbSendExplanation";
			this.gbSendExplanation.Size = new System.Drawing.Size(305, 145);
			this.gbSendExplanation.TabIndex = 16;
			this.gbSendExplanation.TabStop = false;
			this.gbSendExplanation.Text = "发送数据解析";
			// 
			// tpMainPage
			// 
			this.tpMainPage.Location = new System.Drawing.Point(4, 22);
			this.tpMainPage.Name = "tpMainPage";
			this.tpMainPage.Size = new System.Drawing.Size(596, 163);
			this.tpMainPage.TabIndex = 9;
			this.tpMainPage.Text = "主页面";
			this.tpMainPage.UseVisualStyleBackColor = true;
			// 
			// tpPageTips
			// 
			this.tpPageTips.Location = new System.Drawing.Point(4, 22);
			this.tpPageTips.Name = "tpPageTips";
			this.tpPageTips.Size = new System.Drawing.Size(596, 163);
			this.tpPageTips.TabIndex = 8;
			this.tpPageTips.Text = "页面提示";
			this.tpPageTips.UseVisualStyleBackColor = true;
			// 
			// tpMeasure
			// 
			this.tpMeasure.Location = new System.Drawing.Point(4, 22);
			this.tpMeasure.Name = "tpMeasure";
			this.tpMeasure.Size = new System.Drawing.Size(596, 163);
			this.tpMeasure.TabIndex = 7;
			this.tpMeasure.Text = "测量数据";
			this.tpMeasure.UseVisualStyleBackColor = true;
			// 
			// tpGetData
			// 
			this.tpGetData.Location = new System.Drawing.Point(4, 22);
			this.tpGetData.Name = "tpGetData";
			this.tpGetData.Size = new System.Drawing.Size(596, 163);
			this.tpGetData.TabIndex = 6;
			this.tpGetData.Text = "查询数据";
			this.tpGetData.UseVisualStyleBackColor = true;
			// 
			// tpSetData
			// 
			this.tpSetData.Location = new System.Drawing.Point(4, 22);
			this.tpSetData.Name = "tpSetData";
			this.tpSetData.Size = new System.Drawing.Size(596, 163);
			this.tpSetData.TabIndex = 5;
			this.tpSetData.Text = "设置数据";
			this.tpSetData.UseVisualStyleBackColor = true;
			// 
			// tpGetI2C
			// 
			this.tpGetI2C.Location = new System.Drawing.Point(4, 22);
			this.tpGetI2C.Name = "tpGetI2C";
			this.tpGetI2C.Size = new System.Drawing.Size(596, 163);
			this.tpGetI2C.TabIndex = 4;
			this.tpGetI2C.Text = "查询I2C";
			this.tpGetI2C.UseVisualStyleBackColor = true;
			// 
			// tpSetI2C
			// 
			this.tpSetI2C.Location = new System.Drawing.Point(4, 22);
			this.tpSetI2C.Name = "tpSetI2C";
			this.tpSetI2C.Size = new System.Drawing.Size(596, 163);
			this.tpSetI2C.TabIndex = 3;
			this.tpSetI2C.Text = "设置I2C";
			this.tpSetI2C.UseVisualStyleBackColor = true;
			// 
			// tpSTC
			// 
			this.tpSTC.Location = new System.Drawing.Point(4, 22);
			this.tpSTC.Name = "tpSTC";
			this.tpSTC.Size = new System.Drawing.Size(596, 163);
			this.tpSTC.TabIndex = 2;
			this.tpSTC.Text = "STC命令";
			this.tpSTC.UseVisualStyleBackColor = true;
			// 
			// tpSystem
			// 
			this.tpSystem.Location = new System.Drawing.Point(4, 22);
			this.tpSystem.Name = "tpSystem";
			this.tpSystem.Padding = new System.Windows.Forms.Padding(3);
			this.tpSystem.Size = new System.Drawing.Size(596, 163);
			this.tpSystem.TabIndex = 1;
			this.tpSystem.Text = "系统命令";
			this.tpSystem.UseVisualStyleBackColor = true;
			// 
			// tpHeartbeat
			// 
			this.tpHeartbeat.Controls.Add(this.btnSwitchHeartbeat);
			this.tpHeartbeat.Controls.Add(this.txtHeartbeat);
			this.tpHeartbeat.Controls.Add(this.label1);
			this.tpHeartbeat.Location = new System.Drawing.Point(4, 22);
			this.tpHeartbeat.Name = "tpHeartbeat";
			this.tpHeartbeat.Padding = new System.Windows.Forms.Padding(3);
			this.tpHeartbeat.Size = new System.Drawing.Size(596, 163);
			this.tpHeartbeat.TabIndex = 0;
			this.tpHeartbeat.Text = "心跳包";
			this.tpHeartbeat.UseVisualStyleBackColor = true;
			// 
			// tcControl
			// 
			this.tcControl.Controls.Add(this.tpTesterID);
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
			this.tcControl.Size = new System.Drawing.Size(604, 189);
			this.tcControl.TabIndex = 14;
			// 
			// tpTesterID
			// 
			this.tpTesterID.Controls.Add(this.btnTesterID);
			this.tpTesterID.Controls.Add(this.txtTesterID);
			this.tpTesterID.Controls.Add(this.lblTesterID);
			this.tpTesterID.Location = new System.Drawing.Point(4, 22);
			this.tpTesterID.Name = "tpTesterID";
			this.tpTesterID.Size = new System.Drawing.Size(596, 163);
			this.tpTesterID.TabIndex = 10;
			this.tpTesterID.Text = "测试仪ID";
			this.tpTesterID.UseVisualStyleBackColor = true;
			// 
			// lblTesterID
			// 
			this.lblTesterID.AutoSize = true;
			this.lblTesterID.Location = new System.Drawing.Point(163, 73);
			this.lblTesterID.Name = "lblTesterID";
			this.lblTesterID.Size = new System.Drawing.Size(77, 12);
			this.lblTesterID.TabIndex = 12;
			this.lblTesterID.Text = "设置测试仪ID";
			// 
			// txtTesterID
			// 
			this.txtTesterID.Location = new System.Drawing.Point(246, 70);
			this.txtTesterID.Name = "txtTesterID";
			this.txtTesterID.Size = new System.Drawing.Size(122, 21);
			this.txtTesterID.TabIndex = 13;
			this.txtTesterID.Text = "00";
			// 
			// btnTesterID
			// 
			this.btnTesterID.Location = new System.Drawing.Point(374, 68);
			this.btnTesterID.Name = "btnTesterID";
			this.btnTesterID.Size = new System.Drawing.Size(75, 23);
			this.btnTesterID.TabIndex = 14;
			this.btnTesterID.Text = "确认";
			this.btnTesterID.UseVisualStyleBackColor = true;
			// 
			// btnSwitchHeartbeat
			// 
			this.btnSwitchHeartbeat.Location = new System.Drawing.Point(398, 128);
			this.btnSwitchHeartbeat.Name = "btnSwitchHeartbeat";
			this.btnSwitchHeartbeat.Size = new System.Drawing.Size(75, 23);
			this.btnSwitchHeartbeat.TabIndex = 17;
			this.btnSwitchHeartbeat.Text = "确认";
			this.btnSwitchHeartbeat.UseVisualStyleBackColor = true;
			// 
			// txtHeartbeat
			// 
			this.txtHeartbeat.Location = new System.Drawing.Point(260, 130);
			this.txtHeartbeat.Name = "txtHeartbeat";
			this.txtHeartbeat.Size = new System.Drawing.Size(122, 21);
			this.txtHeartbeat.TabIndex = 16;
			this.txtHeartbeat.Text = "1000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(141, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 12);
			this.label1.TabIndex = 15;
			this.label1.Text = "设置心跳包周期(ms)";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 590);
			this.Controls.Add(this.gbSendExplanation);
			this.Controls.Add(this.gbSendData);
			this.Controls.Add(this.gbReceiveExplanation);
			this.Controls.Add(this.gbControl);
			this.Controls.Add(this.gbStatusLog);
			this.Controls.Add(this.gbReceiveData);
			this.Controls.Add(this.gbPortSet);
			this.Name = "MainForm";
			this.Text = "IV曲线仪通讯测试";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.gbPortSet.ResumeLayout(false);
			this.gbPortSet.PerformLayout();
			this.gbStatusLog.ResumeLayout(false);
			this.gbControl.ResumeLayout(false);
			this.tpHeartbeat.ResumeLayout(false);
			this.tpHeartbeat.PerformLayout();
			this.tcControl.ResumeLayout(false);
			this.tpTesterID.ResumeLayout(false);
			this.tpTesterID.PerformLayout();
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
		private System.Windows.Forms.GroupBox gbStatusLog;
		private System.Windows.Forms.GroupBox gbControl;
		private System.Windows.Forms.ListBox lbStatusLog;
		private System.Windows.Forms.GroupBox gbReceiveExplanation;
		private System.Windows.Forms.GroupBox gbSendData;
		private System.Windows.Forms.GroupBox gbSendExplanation;
		private System.Windows.Forms.TabControl tcControl;
		private System.Windows.Forms.TabPage tpTesterID;
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
	}
}