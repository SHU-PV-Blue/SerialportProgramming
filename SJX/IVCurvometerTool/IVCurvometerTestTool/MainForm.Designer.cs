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
			this.tcControl = new System.Windows.Forms.TabControl();
			this.tpHeartbeat = new System.Windows.Forms.TabPage();
			this.btnSwitchHeartbeat = new System.Windows.Forms.Button();
			this.txtHeartbeat = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tpSystem = new System.Windows.Forms.TabPage();
			this.cbSystem = new System.Windows.Forms.ComboBox();
			this.btnSystem = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tpSTC = new System.Windows.Forms.TabPage();
			this.tpSetI2C = new System.Windows.Forms.TabPage();
			this.tpGetI2C = new System.Windows.Forms.TabPage();
			this.tpSetData = new System.Windows.Forms.TabPage();
			this.txtSetData = new System.Windows.Forms.TextBox();
			this.cbSetData = new System.Windows.Forms.ComboBox();
			this.btnSetData = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.tpGetData = new System.Windows.Forms.TabPage();
			this.cbGetData = new System.Windows.Forms.ComboBox();
			this.btnGetData = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.tpMeasure = new System.Windows.Forms.TabPage();
			this.tpPageTips = new System.Windows.Forms.TabPage();
			this.cbPageOperate = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbPageType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbPageID = new System.Windows.Forms.ComboBox();
			this.btnPageTips = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
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
			this.tmrSendHeartbeat = new System.Windows.Forms.Timer(this.components);
			this.tpTestTime = new System.Windows.Forms.TabPage();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTestTime = new System.Windows.Forms.TextBox();
			this.btnTest = new System.Windows.Forms.Button();
			this.gbPortSet.SuspendLayout();
			this.gbReceiveData.SuspendLayout();
			this.gbControl.SuspendLayout();
			this.tcControl.SuspendLayout();
			this.tpHeartbeat.SuspendLayout();
			this.tpSystem.SuspendLayout();
			this.tpSetData.SuspendLayout();
			this.tpGetData.SuspendLayout();
			this.tpPageTips.SuspendLayout();
			this.gbReceiveExplanation.SuspendLayout();
			this.gbSendData.SuspendLayout();
			this.gbSendExplanation.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tpTestTime.SuspendLayout();
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
			this.cbBaudRate.Text = "115200";
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
			this.lbReceiveData.HorizontalScrollbar = true;
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
			this.tcControl.Controls.Add(this.tpTestTime);
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
			this.btnSwitchHeartbeat.Location = new System.Drawing.Point(372, 83);
			this.btnSwitchHeartbeat.Name = "btnSwitchHeartbeat";
			this.btnSwitchHeartbeat.Size = new System.Drawing.Size(75, 23);
			this.btnSwitchHeartbeat.TabIndex = 17;
			this.btnSwitchHeartbeat.Text = "开始";
			this.btnSwitchHeartbeat.UseVisualStyleBackColor = true;
			this.btnSwitchHeartbeat.Click += new System.EventHandler(this.btnSwitchHeartbeat_Click);
			// 
			// txtHeartbeat
			// 
			this.txtHeartbeat.Location = new System.Drawing.Point(244, 85);
			this.txtHeartbeat.Name = "txtHeartbeat";
			this.txtHeartbeat.Size = new System.Drawing.Size(122, 21);
			this.txtHeartbeat.TabIndex = 16;
			this.txtHeartbeat.Text = "1000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(125, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 12);
			this.label1.TabIndex = 15;
			this.label1.Text = "设置心跳包周期(ms)";
			// 
			// tpSystem
			// 
			this.tpSystem.Controls.Add(this.cbSystem);
			this.tpSystem.Controls.Add(this.btnSystem);
			this.tpSystem.Controls.Add(this.label2);
			this.tpSystem.Location = new System.Drawing.Point(4, 22);
			this.tpSystem.Name = "tpSystem";
			this.tpSystem.Padding = new System.Windows.Forms.Padding(3);
			this.tpSystem.Size = new System.Drawing.Size(727, 179);
			this.tpSystem.TabIndex = 1;
			this.tpSystem.Text = "系统操作";
			this.tpSystem.UseVisualStyleBackColor = true;
			// 
			// cbSystem
			// 
			this.cbSystem.FormattingEnabled = true;
			this.cbSystem.Items.AddRange(new object[] {
            "测量命令",
            "辐照度测量",
            "温度测量",
            "电源电压测量",
            "IV特性数据",
            "IV-STC特性数据",
            "存储命令",
            "电压系数测量",
            "电流系数测量",
            "辐照度系数测量",
            "温度系数测量",
            "电源电压系数测量"});
			this.cbSystem.Location = new System.Drawing.Point(184, 85);
			this.cbSystem.Name = "cbSystem";
			this.cbSystem.Size = new System.Drawing.Size(121, 20);
			this.cbSystem.TabIndex = 21;
			// 
			// btnSystem
			// 
			this.btnSystem.Location = new System.Drawing.Point(311, 83);
			this.btnSystem.Name = "btnSystem";
			this.btnSystem.Size = new System.Drawing.Size(75, 23);
			this.btnSystem.TabIndex = 20;
			this.btnSystem.Text = "发送";
			this.btnSystem.UseVisualStyleBackColor = true;
			this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(125, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 18;
			this.label2.Text = "选择操作";
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
			this.tpSetData.Controls.Add(this.txtSetData);
			this.tpSetData.Controls.Add(this.cbSetData);
			this.tpSetData.Controls.Add(this.btnSetData);
			this.tpSetData.Controls.Add(this.label7);
			this.tpSetData.Location = new System.Drawing.Point(4, 22);
			this.tpSetData.Name = "tpSetData";
			this.tpSetData.Size = new System.Drawing.Size(727, 179);
			this.tpSetData.TabIndex = 5;
			this.tpSetData.Text = "设置数据";
			this.tpSetData.UseVisualStyleBackColor = true;
			// 
			// txtSetData
			// 
			this.txtSetData.Location = new System.Drawing.Point(359, 85);
			this.txtSetData.Name = "txtSetData";
			this.txtSetData.Size = new System.Drawing.Size(92, 21);
			this.txtSetData.TabIndex = 28;
			// 
			// cbSetData
			// 
			this.cbSetData.FormattingEnabled = true;
			this.cbSetData.Items.AddRange(new object[] {
            "电流系数A地址",
            "电流系数B地址",
            "电压系数A地址",
            "电压系数B地址",
            "温度系数A地址",
            "温度系数B地址",
            "照明系数A地址",
            "照明系数B地址",
            "电池系数A地址",
            "电池系数B地址",
            "分流器系数地址",
            "照明仪系数地址",
            "单晶硅电压温度系数",
            "单晶硅电流温度系数",
            "多晶硅电压温度系数",
            "多晶硅电流温度系数",
            "薄膜电压温度系数",
            "薄膜电流温度系数",
            "电池类型选择",
            "单晶硅组件内阻",
            "照度仪选择地址",
            "照度仪系数地址",
            "多晶硅组件内阻",
            "薄膜组件内阻",
            "单晶硅组件内阻温度系数",
            "多晶硅组件内阻温度系数",
            "薄膜组件内阻温度系数",
            "阵列测量序号",
            "被测阵列编号",
            "系统设置密码",
            "系统ID"});
			this.cbSetData.Location = new System.Drawing.Point(187, 85);
			this.cbSetData.Name = "cbSetData";
			this.cbSetData.Size = new System.Drawing.Size(161, 20);
			this.cbSetData.TabIndex = 27;
			// 
			// btnSetData
			// 
			this.btnSetData.Location = new System.Drawing.Point(457, 83);
			this.btnSetData.Name = "btnSetData";
			this.btnSetData.Size = new System.Drawing.Size(75, 23);
			this.btnSetData.TabIndex = 26;
			this.btnSetData.Text = "发送";
			this.btnSetData.UseVisualStyleBackColor = true;
			this.btnSetData.Click += new System.EventHandler(this.btnSetData_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(128, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 12);
			this.label7.TabIndex = 25;
			this.label7.Text = "选择数据";
			// 
			// tpGetData
			// 
			this.tpGetData.Controls.Add(this.cbGetData);
			this.tpGetData.Controls.Add(this.btnGetData);
			this.tpGetData.Controls.Add(this.label6);
			this.tpGetData.Location = new System.Drawing.Point(4, 22);
			this.tpGetData.Name = "tpGetData";
			this.tpGetData.Size = new System.Drawing.Size(727, 179);
			this.tpGetData.TabIndex = 6;
			this.tpGetData.Text = "查询数据";
			this.tpGetData.UseVisualStyleBackColor = true;
			// 
			// cbGetData
			// 
			this.cbGetData.FormattingEnabled = true;
			this.cbGetData.Items.AddRange(new object[] {
            "电流系数A地址",
            "电流系数B地址",
            "电压系数A地址",
            "电压系数B地址",
            "温度系数A地址",
            "温度系数B地址",
            "照明系数A地址",
            "照明系数B地址",
            "电池系数A地址",
            "电池系数B地址",
            "分流器系数地址",
            "照明仪系数地址",
            "单晶硅电压温度系数",
            "单晶硅电流温度系数",
            "多晶硅电压温度系数",
            "多晶硅电流温度系数",
            "薄膜电压温度系数",
            "薄膜电流温度系数",
            "电池类型选择",
            "单晶硅组件内阻",
            "照度仪选择地址",
            "照度仪系数地址",
            "多晶硅组件内阻",
            "薄膜组件内阻",
            "单晶硅组件内阻温度系数",
            "多晶硅组件内阻温度系数",
            "薄膜组件内阻温度系数",
            "阵列测量序号",
            "被测阵列编号",
            "系统设置密码",
            "系统ID",
            "系统硬件型号",
            "系统软件版本",
            "系统硬件编号",
            "系统最大测量电流",
            "系统最大测量电压"});
			this.cbGetData.Location = new System.Drawing.Point(184, 85);
			this.cbGetData.Name = "cbGetData";
			this.cbGetData.Size = new System.Drawing.Size(161, 20);
			this.cbGetData.TabIndex = 24;
			// 
			// btnGetData
			// 
			this.btnGetData.Location = new System.Drawing.Point(351, 83);
			this.btnGetData.Name = "btnGetData";
			this.btnGetData.Size = new System.Drawing.Size(75, 23);
			this.btnGetData.TabIndex = 23;
			this.btnGetData.Text = "发送";
			this.btnGetData.UseVisualStyleBackColor = true;
			this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(125, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 12);
			this.label6.TabIndex = 22;
			this.label6.Text = "选择数据";
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
			this.tpPageTips.Controls.Add(this.cbPageOperate);
			this.tpPageTips.Controls.Add(this.label5);
			this.tpPageTips.Controls.Add(this.cbPageType);
			this.tpPageTips.Controls.Add(this.label4);
			this.tpPageTips.Controls.Add(this.cbPageID);
			this.tpPageTips.Controls.Add(this.btnPageTips);
			this.tpPageTips.Controls.Add(this.label3);
			this.tpPageTips.Location = new System.Drawing.Point(4, 22);
			this.tpPageTips.Name = "tpPageTips";
			this.tpPageTips.Size = new System.Drawing.Size(727, 179);
			this.tpPageTips.TabIndex = 8;
			this.tpPageTips.Text = "页面提示";
			this.tpPageTips.UseVisualStyleBackColor = true;
			// 
			// cbPageOperate
			// 
			this.cbPageOperate.FormattingEnabled = true;
			this.cbPageOperate.Items.AddRange(new object[] {
            "完成",
            "确定",
            "取消"});
			this.cbPageOperate.Location = new System.Drawing.Point(461, 85);
			this.cbPageOperate.Name = "cbPageOperate";
			this.cbPageOperate.Size = new System.Drawing.Size(121, 20);
			this.cbPageOperate.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(426, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 27;
			this.label5.Text = "操作";
			// 
			// cbPageType
			// 
			this.cbPageType.FormattingEnabled = true;
			this.cbPageType.Items.AddRange(new object[] {
            "主页面",
            "信息对话框",
            "信息提示框",
            "故障提示框"});
			this.cbPageType.Location = new System.Drawing.Point(113, 85);
			this.cbPageType.Name = "cbPageType";
			this.cbPageType.Size = new System.Drawing.Size(121, 20);
			this.cbPageType.TabIndex = 26;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(54, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 25;
			this.label4.Text = "页面类型";
			// 
			// cbPageID
			// 
			this.cbPageID.FormattingEnabled = true;
			this.cbPageID.Items.AddRange(new object[] {
            "测量主页面",
            "参数设置主页面",
            "系统检测中...",
            "测量中...",
            "无输入电压",
            "输入电压过高",
            "存储完成",
            "确认删除",
            "存储空间不足",
            "系统故障",
            "系统严重故障",
            "系统故障01",
            "系统故障02",
            "系统温度过高"});
			this.cbPageID.Location = new System.Drawing.Point(299, 85);
			this.cbPageID.Name = "cbPageID";
			this.cbPageID.Size = new System.Drawing.Size(121, 20);
			this.cbPageID.TabIndex = 24;
			// 
			// btnPageTips
			// 
			this.btnPageTips.Location = new System.Drawing.Point(588, 83);
			this.btnPageTips.Name = "btnPageTips";
			this.btnPageTips.Size = new System.Drawing.Size(75, 23);
			this.btnPageTips.TabIndex = 23;
			this.btnPageTips.Text = "发送";
			this.btnPageTips.UseVisualStyleBackColor = true;
			this.btnPageTips.Click += new System.EventHandler(this.btnPageTips_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(240, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 22;
			this.label3.Text = "页面编号";
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
			this.lbReceiveExplanation.HorizontalScrollbar = true;
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
			this.lbSendData.HorizontalScrollbar = true;
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
			this.lbSendExplanation.HorizontalScrollbar = true;
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
			// tmrSendHeartbeat
			// 
			this.tmrSendHeartbeat.Tick += new System.EventHandler(this.tmrSendHeartbeat_Tick);
			// 
			// tpTestTime
			// 
			this.tpTestTime.Controls.Add(this.btnTest);
			this.tpTestTime.Controls.Add(this.txtTestTime);
			this.tpTestTime.Controls.Add(this.label8);
			this.tpTestTime.Location = new System.Drawing.Point(4, 22);
			this.tpTestTime.Name = "tpTestTime";
			this.tpTestTime.Size = new System.Drawing.Size(727, 179);
			this.tpTestTime.TabIndex = 10;
			this.tpTestTime.Text = "测试周期";
			this.tpTestTime.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(11, 92);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(161, 12);
			this.label8.TabIndex = 0;
			this.label8.Text = "发送测量命令的间隔时间(ms)";
			// 
			// txtTestTime
			// 
			this.txtTestTime.Location = new System.Drawing.Point(178, 89);
			this.txtTestTime.Name = "txtTestTime";
			this.txtTestTime.Size = new System.Drawing.Size(100, 21);
			this.txtTestTime.TabIndex = 1;
			this.txtTestTime.Text = "30000";
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(284, 87);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 2;
			this.btnTest.Text = "启动测试";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
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
			this.tpSystem.ResumeLayout(false);
			this.tpSystem.PerformLayout();
			this.tpSetData.ResumeLayout(false);
			this.tpSetData.PerformLayout();
			this.tpGetData.ResumeLayout(false);
			this.tpGetData.PerformLayout();
			this.tpPageTips.ResumeLayout(false);
			this.tpPageTips.PerformLayout();
			this.gbReceiveExplanation.ResumeLayout(false);
			this.gbSendData.ResumeLayout(false);
			this.gbSendExplanation.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tpTestTime.ResumeLayout(false);
			this.tpTestTime.PerformLayout();
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
		private System.Windows.Forms.ComboBox cbSystem;
		private System.Windows.Forms.Button btnSystem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer tmrSendHeartbeat;
		private System.Windows.Forms.ComboBox cbPageOperate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbPageType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbPageID;
		private System.Windows.Forms.Button btnPageTips;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbGetData;
		private System.Windows.Forms.Button btnGetData;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSetData;
		private System.Windows.Forms.ComboBox cbSetData;
		private System.Windows.Forms.Button btnSetData;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TabPage tpTestTime;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.TextBox txtTestTime;
		private System.Windows.Forms.Label label8;
	}
}