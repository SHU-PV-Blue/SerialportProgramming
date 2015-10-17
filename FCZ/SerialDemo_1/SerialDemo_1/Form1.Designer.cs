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
			this.btnInit = new System.Windows.Forms.Button();
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
			this.btnSetParam = new System.Windows.Forms.Button();
			this.txtRecive = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnReciveClear = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tbpReadInfo = new System.Windows.Forms.TabPage();
			this.btnPassWord = new System.Windows.Forms.Button();
			this.btnHistoryWeather = new System.Windows.Forms.Button();
			this.btnSysConfig = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tbpSysConfig = new System.Windows.Forms.TabPage();
			this.cmbDay = new System.Windows.Forms.ComboBox();
			this.cmbMonth = new System.Windows.Forms.ComboBox();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbpSetPsw = new System.Windows.Forms.TabPage();
			this.tbpSendString = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTimeCell = new System.Windows.Forms.TextBox();
			this.ckbAutoSend = new System.Windows.Forms.CheckBox();
			this.txtSend = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.cmbHour = new System.Windows.Forms.ComboBox();
			this.cmbMinute = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.cmbLang = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.btnSetSystemConfig = new System.Windows.Forms.Button();
			this.txtSaveTime = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tbpReadInfo.SuspendLayout();
			this.tbpSysConfig.SuspendLayout();
			this.tbpSendString.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnInit);
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
			this.groupBox1.Location = new System.Drawing.Point(0, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(177, 227);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "设置";
			// 
			// btnInit
			// 
			this.btnInit.FlatAppearance.BorderSize = 0;
			this.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnInit.Location = new System.Drawing.Point(33, 30);
			this.btnInit.Name = "btnInit";
			this.btnInit.Size = new System.Drawing.Size(107, 30);
			this.btnInit.TabIndex = 2;
			this.btnInit.Text = "重新加载参数";
			this.btnInit.UseVisualStyleBackColor = true;
			this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
			// 
			// cmbParity
			// 
			this.cmbParity.FormattingEnabled = true;
			this.cmbParity.Items.AddRange(new object[] {
            "无"});
			this.cmbParity.Location = new System.Drawing.Point(82, 182);
			this.cmbParity.Name = "cmbParity";
			this.cmbParity.Size = new System.Drawing.Size(82, 20);
			this.cmbParity.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(14, 182);
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
			this.cmbStopBit.Location = new System.Drawing.Point(82, 156);
			this.cmbStopBit.Name = "cmbStopBit";
			this.cmbStopBit.Size = new System.Drawing.Size(82, 20);
			this.cmbStopBit.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(14, 156);
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
			this.cmbDataBit.Location = new System.Drawing.Point(82, 130);
			this.cmbDataBit.Name = "cmbDataBit";
			this.cmbDataBit.Size = new System.Drawing.Size(82, 20);
			this.cmbDataBit.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(14, 130);
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
			this.cmbBaudRate.Location = new System.Drawing.Point(82, 104);
			this.cmbBaudRate.Name = "cmbBaudRate";
			this.cmbBaudRate.Size = new System.Drawing.Size(82, 20);
			this.cmbBaudRate.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(14, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "波特率 : ";
			// 
			// cmbPorts
			// 
			this.cmbPorts.FormattingEnabled = true;
			this.cmbPorts.Location = new System.Drawing.Point(82, 78);
			this.cmbPorts.Name = "cmbPorts";
			this.cmbPorts.Size = new System.Drawing.Size(82, 20);
			this.cmbPorts.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(14, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "串口号 : ";
			// 
			// btnSetParam
			// 
			this.btnSetParam.Location = new System.Drawing.Point(20, 20);
			this.btnSetParam.Name = "btnSetParam";
			this.btnSetParam.Size = new System.Drawing.Size(141, 29);
			this.btnSetParam.TabIndex = 2;
			this.btnSetParam.Text = "打开串口";
			this.btnSetParam.UseVisualStyleBackColor = true;
			this.btnSetParam.Click += new System.EventHandler(this.btnSetParam_Click);
			// 
			// txtRecive
			// 
			this.txtRecive.Location = new System.Drawing.Point(6, 30);
			this.txtRecive.Multiline = true;
			this.txtRecive.Name = "txtRecive";
			this.txtRecive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtRecive.Size = new System.Drawing.Size(346, 192);
			this.txtRecive.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(20, 56);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(141, 29);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "关闭串口";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(20, 97);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(141, 29);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "退出";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnReciveClear);
			this.groupBox2.Controls.Add(this.txtRecive);
			this.groupBox2.Location = new System.Drawing.Point(183, 16);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(352, 245);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "数据发送/接收";
			// 
			// btnReciveClear
			// 
			this.btnReciveClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnReciveClear.FlatAppearance.BorderSize = 0;
			this.btnReciveClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReciveClear.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnReciveClear.ForeColor = System.Drawing.Color.Turquoise;
			this.btnReciveClear.Location = new System.Drawing.Point(260, 187);
			this.btnReciveClear.Name = "btnReciveClear";
			this.btnReciveClear.Size = new System.Drawing.Size(74, 35);
			this.btnReciveClear.TabIndex = 10;
			this.btnReciveClear.Text = "清空";
			this.btnReciveClear.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnReciveClear.UseVisualStyleBackColor = false;
			this.btnReciveClear.Click += new System.EventHandler(this.btnReciveClear_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnSetParam);
			this.groupBox3.Controls.Add(this.btnExit);
			this.groupBox3.Controls.Add(this.btnClose);
			this.groupBox3.Location = new System.Drawing.Point(3, 253);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(174, 138);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "操作";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tbpReadInfo);
			this.tabControl1.Controls.Add(this.tbpSysConfig);
			this.tabControl1.Controls.Add(this.tbpSetPsw);
			this.tabControl1.Controls.Add(this.tbpSendString);
			this.tabControl1.Location = new System.Drawing.Point(189, 273);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(346, 184);
			this.tabControl1.TabIndex = 9;
			// 
			// tbpReadInfo
			// 
			this.tbpReadInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tbpReadInfo.Controls.Add(this.btnPassWord);
			this.tbpReadInfo.Controls.Add(this.btnHistoryWeather);
			this.tbpReadInfo.Controls.Add(this.btnSysConfig);
			this.tbpReadInfo.Controls.Add(this.button1);
			this.tbpReadInfo.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tbpReadInfo.Location = new System.Drawing.Point(4, 22);
			this.tbpReadInfo.Name = "tbpReadInfo";
			this.tbpReadInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tbpReadInfo.Size = new System.Drawing.Size(338, 158);
			this.tbpReadInfo.TabIndex = 0;
			this.tbpReadInfo.Text = "读取信息";
			this.tbpReadInfo.UseVisualStyleBackColor = true;
			// 
			// btnPassWord
			// 
			this.btnPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnPassWord.FlatAppearance.BorderSize = 0;
			this.btnPassWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPassWord.Location = new System.Drawing.Point(169, 79);
			this.btnPassWord.Name = "btnPassWord";
			this.btnPassWord.Size = new System.Drawing.Size(169, 81);
			this.btnPassWord.TabIndex = 3;
			this.btnPassWord.Text = "读取密码";
			this.btnPassWord.UseVisualStyleBackColor = false;
			this.btnPassWord.Click += new System.EventHandler(this.btnPassWord_Click);
			// 
			// btnHistoryWeather
			// 
			this.btnHistoryWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnHistoryWeather.FlatAppearance.BorderSize = 0;
			this.btnHistoryWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHistoryWeather.Location = new System.Drawing.Point(169, 0);
			this.btnHistoryWeather.Name = "btnHistoryWeather";
			this.btnHistoryWeather.Size = new System.Drawing.Size(169, 81);
			this.btnHistoryWeather.TabIndex = 2;
			this.btnHistoryWeather.Text = "历史天气";
			this.btnHistoryWeather.UseVisualStyleBackColor = false;
			this.btnHistoryWeather.Click += new System.EventHandler(this.btnHistoryWeather_Click);
			// 
			// btnSysConfig
			// 
			this.btnSysConfig.BackColor = System.Drawing.Color.Turquoise;
			this.btnSysConfig.FlatAppearance.BorderSize = 0;
			this.btnSysConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSysConfig.Location = new System.Drawing.Point(0, 80);
			this.btnSysConfig.Name = "btnSysConfig";
			this.btnSysConfig.Size = new System.Drawing.Size(169, 81);
			this.btnSysConfig.TabIndex = 1;
			this.btnSysConfig.Text = "系统信息";
			this.btnSysConfig.UseVisualStyleBackColor = false;
			this.btnSysConfig.Click += new System.EventHandler(this.btnSysConfig_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(169, 81);
			this.button1.TabIndex = 0;
			this.button1.Text = "天气信息";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbpSysConfig
			// 
			this.tbpSysConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tbpSysConfig.Controls.Add(this.txtSaveTime);
			this.tbpSysConfig.Controls.Add(this.btnSetSystemConfig);
			this.tbpSysConfig.Controls.Add(this.cmbDay);
			this.tbpSysConfig.Controls.Add(this.cmbMinute);
			this.tbpSysConfig.Controls.Add(this.cmbMonth);
			this.tbpSysConfig.Controls.Add(this.cmbLang);
			this.tbpSysConfig.Controls.Add(this.cmbHour);
			this.tbpSysConfig.Controls.Add(this.cmbYear);
			this.tbpSysConfig.Controls.Add(this.label11);
			this.tbpSysConfig.Controls.Add(this.label10);
			this.tbpSysConfig.Controls.Add(this.label9);
			this.tbpSysConfig.Controls.Add(this.label18);
			this.tbpSysConfig.Controls.Add(this.label16);
			this.tbpSysConfig.Controls.Add(this.label17);
			this.tbpSysConfig.Controls.Add(this.label14);
			this.tbpSysConfig.Controls.Add(this.label15);
			this.tbpSysConfig.Controls.Add(this.label13);
			this.tbpSysConfig.Controls.Add(this.label12);
			this.tbpSysConfig.Controls.Add(this.label8);
			this.tbpSysConfig.Location = new System.Drawing.Point(4, 22);
			this.tbpSysConfig.Name = "tbpSysConfig";
			this.tbpSysConfig.Padding = new System.Windows.Forms.Padding(3);
			this.tbpSysConfig.Size = new System.Drawing.Size(338, 158);
			this.tbpSysConfig.TabIndex = 1;
			this.tbpSysConfig.Text = "系统配置";
			// 
			// cmbDay
			// 
			this.cmbDay.FormattingEnabled = true;
			this.cmbDay.Location = new System.Drawing.Point(250, 23);
			this.cmbDay.Name = "cmbDay";
			this.cmbDay.Size = new System.Drawing.Size(59, 20);
			this.cmbDay.TabIndex = 1;
			// 
			// cmbMonth
			// 
			this.cmbMonth.FormattingEnabled = true;
			this.cmbMonth.Location = new System.Drawing.Point(170, 23);
			this.cmbMonth.Name = "cmbMonth";
			this.cmbMonth.Size = new System.Drawing.Size(57, 20);
			this.cmbMonth.TabIndex = 1;
			// 
			// cmbYear
			// 
			this.cmbYear.FormattingEnabled = true;
			this.cmbYear.Location = new System.Drawing.Point(78, 23);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(69, 20);
			this.cmbYear.TabIndex = 1;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label11.Location = new System.Drawing.Point(37, 123);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(35, 14);
			this.label11.TabIndex = 0;
			this.label11.Text = "语言";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label10.Location = new System.Drawing.Point(9, 92);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 14);
			this.label10.TabIndex = 0;
			this.label10.Text = "存储间隔";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label9.Location = new System.Drawing.Point(37, 61);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 14);
			this.label9.TabIndex = 0;
			this.label9.Text = "时间";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(37, 29);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 14);
			this.label8.TabIndex = 0;
			this.label8.Text = "日期";
			// 
			// tbpSetPsw
			// 
			this.tbpSetPsw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.tbpSetPsw.Location = new System.Drawing.Point(4, 22);
			this.tbpSetPsw.Name = "tbpSetPsw";
			this.tbpSetPsw.Padding = new System.Windows.Forms.Padding(3);
			this.tbpSetPsw.Size = new System.Drawing.Size(338, 158);
			this.tbpSetPsw.TabIndex = 2;
			this.tbpSetPsw.Text = "设置密码";
			this.tbpSetPsw.UseVisualStyleBackColor = true;
			// 
			// tbpSendString
			// 
			this.tbpSendString.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tbpSendString.Controls.Add(this.label7);
			this.tbpSendString.Controls.Add(this.label6);
			this.tbpSendString.Controls.Add(this.txtTimeCell);
			this.tbpSendString.Controls.Add(this.ckbAutoSend);
			this.tbpSendString.Controls.Add(this.txtSend);
			this.tbpSendString.Controls.Add(this.btnSend);
			this.tbpSendString.Location = new System.Drawing.Point(4, 22);
			this.tbpSendString.Name = "tbpSendString";
			this.tbpSendString.Padding = new System.Windows.Forms.Padding(3);
			this.tbpSendString.Size = new System.Drawing.Size(338, 158);
			this.tbpSendString.TabIndex = 3;
			this.tbpSendString.Text = "自定义发送";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(279, 107);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 12);
			this.label7.TabIndex = 21;
			this.label7.Text = "秒";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(161, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 12);
			this.label6.TabIndex = 20;
			this.label6.Text = "时间间隔";
			// 
			// txtTimeCell
			// 
			this.txtTimeCell.Location = new System.Drawing.Point(216, 102);
			this.txtTimeCell.Name = "txtTimeCell";
			this.txtTimeCell.Size = new System.Drawing.Size(57, 21);
			this.txtTimeCell.TabIndex = 19;
			// 
			// ckbAutoSend
			// 
			this.ckbAutoSend.AutoSize = true;
			this.ckbAutoSend.Location = new System.Drawing.Point(39, 104);
			this.ckbAutoSend.Name = "ckbAutoSend";
			this.ckbAutoSend.Size = new System.Drawing.Size(72, 16);
			this.ckbAutoSend.TabIndex = 18;
			this.ckbAutoSend.Text = "自动发送";
			this.ckbAutoSend.UseVisualStyleBackColor = true;
			// 
			// txtSend
			// 
			this.txtSend.Location = new System.Drawing.Point(23, 55);
			this.txtSend.Name = "txtSend";
			this.txtSend.Size = new System.Drawing.Size(231, 21);
			this.txtSend.TabIndex = 16;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(274, 50);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(58, 28);
			this.btnSend.TabIndex = 17;
			this.btnSend.Text = "发送";
			this.btnSend.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label12.Location = new System.Drawing.Point(147, 26);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(21, 14);
			this.label12.TabIndex = 0;
			this.label12.Text = "年";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label13.Location = new System.Drawing.Point(227, 25);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(21, 14);
			this.label13.TabIndex = 0;
			this.label13.Text = "月";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label14.Location = new System.Drawing.Point(315, 25);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(21, 14);
			this.label14.TabIndex = 0;
			this.label14.Text = "日";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label15.Location = new System.Drawing.Point(147, 63);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(21, 14);
			this.label15.TabIndex = 0;
			this.label15.Text = "时";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label16.Location = new System.Drawing.Point(233, 61);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(21, 14);
			this.label16.TabIndex = 0;
			this.label16.Text = "分";
			// 
			// cmbHour
			// 
			this.cmbHour.FormattingEnabled = true;
			this.cmbHour.Location = new System.Drawing.Point(78, 60);
			this.cmbHour.Name = "cmbHour";
			this.cmbHour.Size = new System.Drawing.Size(69, 20);
			this.cmbHour.TabIndex = 1;
			// 
			// cmbMinute
			// 
			this.cmbMinute.FormattingEnabled = true;
			this.cmbMinute.Location = new System.Drawing.Point(170, 60);
			this.cmbMinute.Name = "cmbMinute";
			this.cmbMinute.Size = new System.Drawing.Size(57, 20);
			this.cmbMinute.TabIndex = 1;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label17.Location = new System.Drawing.Point(147, 95);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(35, 14);
			this.label17.TabIndex = 0;
			this.label17.Text = "小时";
			// 
			// cmbLang
			// 
			this.cmbLang.FormattingEnabled = true;
			this.cmbLang.Location = new System.Drawing.Point(78, 122);
			this.cmbLang.Name = "cmbLang";
			this.cmbLang.Size = new System.Drawing.Size(69, 20);
			this.cmbLang.TabIndex = 1;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label18.Location = new System.Drawing.Point(260, 61);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(77, 14);
			this.label18.TabIndex = 0;
			this.label18.Text = "(24小时制)";
			// 
			// btnSetSystemConfig
			// 
			this.btnSetSystemConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnSetSystemConfig.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
			this.btnSetSystemConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetSystemConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSetSystemConfig.Location = new System.Drawing.Point(226, 106);
			this.btnSetSystemConfig.Name = "btnSetSystemConfig";
			this.btnSetSystemConfig.Size = new System.Drawing.Size(104, 44);
			this.btnSetSystemConfig.TabIndex = 2;
			this.btnSetSystemConfig.Text = "确定";
			this.btnSetSystemConfig.UseVisualStyleBackColor = false;
			this.btnSetSystemConfig.Click += new System.EventHandler(this.btnSetSystemConfig_Click);
			// 
			// txtSaveTime
			// 
			this.txtSaveTime.Location = new System.Drawing.Point(78, 89);
			this.txtSaveTime.Name = "txtSaveTime";
			this.txtSaveTime.Size = new System.Drawing.Size(69, 21);
			this.txtSaveTime.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 469);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Name = "Form1";
			this.Text = "气象仪";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tbpReadInfo.ResumeLayout(false);
			this.tbpSysConfig.ResumeLayout(false);
			this.tbpSysConfig.PerformLayout();
			this.tbpSendString.ResumeLayout(false);
			this.tbpSendString.PerformLayout();
			this.ResumeLayout(false);

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
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnInit;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnReciveClear;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tbpReadInfo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage tbpSysConfig;
		private System.Windows.Forms.TabPage tbpSetPsw;
		private System.Windows.Forms.TabPage tbpSendString;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTimeCell;
		private System.Windows.Forms.CheckBox ckbAutoSend;
		private System.Windows.Forms.TextBox txtSend;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Button btnPassWord;
		private System.Windows.Forms.Button btnHistoryWeather;
		private System.Windows.Forms.Button btnSysConfig;
		private System.Windows.Forms.ComboBox cmbDay;
		private System.Windows.Forms.ComboBox cmbMonth;
		private System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbMinute;
		private System.Windows.Forms.ComboBox cmbLang;
		private System.Windows.Forms.ComboBox cmbHour;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnSetSystemConfig;
		private System.Windows.Forms.TextBox txtSaveTime;
	}
}

