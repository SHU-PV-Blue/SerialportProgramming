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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
			this.btnReset = new System.Windows.Forms.Button();
			this.btnReHistoryWeather = new System.Windows.Forms.Button();
			this.btnPassWord = new System.Windows.Forms.Button();
			this.btnHistoryWeather = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tbpSysConfig = new System.Windows.Forms.TabPage();
			this.txtSaveTime = new System.Windows.Forms.TextBox();
			this.btnSetSystemConfig = new System.Windows.Forms.Button();
			this.cmbDay = new System.Windows.Forms.ComboBox();
			this.cmbMinute = new System.Windows.Forms.ComboBox();
			this.cmbMonth = new System.Windows.Forms.ComboBox();
			this.cmbLang = new System.Windows.Forms.ComboBox();
			this.cmbHour = new System.Windows.Forms.ComboBox();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbpSetPsw = new System.Windows.Forms.TabPage();
			this.btnPsw3 = new System.Windows.Forms.Button();
			this.btnPsw6 = new System.Windows.Forms.Button();
			this.btnPsw0 = new System.Windows.Forms.Button();
			this.btnPswBack = new System.Windows.Forms.Button();
			this.btnPsw2 = new System.Windows.Forms.Button();
			this.btnPsw5 = new System.Windows.Forms.Button();
			this.btnPsw8 = new System.Windows.Forms.Button();
			this.btnPsw1 = new System.Windows.Forms.Button();
			this.btnPsw4 = new System.Windows.Forms.Button();
			this.btnPsw7 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSetPsw = new System.Windows.Forms.Button();
			this.txtPsw = new System.Windows.Forms.TextBox();
			this.btnPsw9 = new System.Windows.Forms.Button();
			this.btnPswClear = new System.Windows.Forms.Button();
			this.tbpSendString = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTimeCell = new System.Windows.Forms.TextBox();
			this.ckbAutoSend = new System.Windows.Forms.CheckBox();
			this.txtSend = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.btnSysConfig = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tbpReadInfo.SuspendLayout();
			this.tbpSysConfig.SuspendLayout();
			this.tbpSetPsw.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tbpSendString.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			resources.ApplyResources(this.groupBox1, "groupBox1");
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
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// btnInit
			// 
			resources.ApplyResources(this.btnInit, "btnInit");
			this.btnInit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInit.FlatAppearance.BorderSize = 0;
			this.btnInit.Name = "btnInit";
			this.btnInit.UseVisualStyleBackColor = true;
			this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
			// 
			// cmbParity
			// 
			resources.ApplyResources(this.cmbParity, "cmbParity");
			this.cmbParity.FormattingEnabled = true;
			this.cmbParity.Items.AddRange(new object[] {
            resources.GetString("cmbParity.Items")});
			this.cmbParity.Name = "cmbParity";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// cmbStopBit
			// 
			resources.ApplyResources(this.cmbStopBit, "cmbStopBit");
			this.cmbStopBit.FormattingEnabled = true;
			this.cmbStopBit.Items.AddRange(new object[] {
            resources.GetString("cmbStopBit.Items")});
			this.cmbStopBit.Name = "cmbStopBit";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// cmbDataBit
			// 
			resources.ApplyResources(this.cmbDataBit, "cmbDataBit");
			this.cmbDataBit.FormattingEnabled = true;
			this.cmbDataBit.Items.AddRange(new object[] {
            resources.GetString("cmbDataBit.Items"),
            resources.GetString("cmbDataBit.Items1"),
            resources.GetString("cmbDataBit.Items2"),
            resources.GetString("cmbDataBit.Items3")});
			this.cmbDataBit.Name = "cmbDataBit";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// cmbBaudRate
			// 
			resources.ApplyResources(this.cmbBaudRate, "cmbBaudRate");
			this.cmbBaudRate.FormattingEnabled = true;
			this.cmbBaudRate.Items.AddRange(new object[] {
            resources.GetString("cmbBaudRate.Items"),
            resources.GetString("cmbBaudRate.Items1"),
            resources.GetString("cmbBaudRate.Items2"),
            resources.GetString("cmbBaudRate.Items3"),
            resources.GetString("cmbBaudRate.Items4"),
            resources.GetString("cmbBaudRate.Items5")});
			this.cmbBaudRate.Name = "cmbBaudRate";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// cmbPorts
			// 
			resources.ApplyResources(this.cmbPorts, "cmbPorts");
			this.cmbPorts.FormattingEnabled = true;
			this.cmbPorts.Name = "cmbPorts";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// btnSetParam
			// 
			resources.ApplyResources(this.btnSetParam, "btnSetParam");
			this.btnSetParam.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSetParam.FlatAppearance.BorderSize = 0;
			this.btnSetParam.Name = "btnSetParam";
			this.btnSetParam.UseVisualStyleBackColor = true;
			this.btnSetParam.Click += new System.EventHandler(this.btnSetParam_Click);
			// 
			// txtRecive
			// 
			resources.ApplyResources(this.txtRecive, "txtRecive");
			this.txtRecive.Name = "txtRecive";
			// 
			// btnClose
			// 
			resources.ApplyResources(this.btnClose, "btnClose");
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.Name = "btnClose";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnExit
			// 
			resources.ApplyResources(this.btnExit, "btnExit");
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.Name = "btnExit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// groupBox2
			// 
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Controls.Add(this.btnReciveClear);
			this.groupBox2.Controls.Add(this.txtRecive);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// btnReciveClear
			// 
			resources.ApplyResources(this.btnReciveClear, "btnReciveClear");
			this.btnReciveClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnReciveClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReciveClear.FlatAppearance.BorderSize = 0;
			this.btnReciveClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnReciveClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnReciveClear.ForeColor = System.Drawing.Color.Turquoise;
			this.btnReciveClear.Name = "btnReciveClear";
			this.btnReciveClear.UseVisualStyleBackColor = false;
			this.btnReciveClear.Click += new System.EventHandler(this.btnReciveClear_Click);
			// 
			// groupBox3
			// 
			resources.ApplyResources(this.groupBox3, "groupBox3");
			this.groupBox3.Controls.Add(this.btnSetParam);
			this.groupBox3.Controls.Add(this.btnExit);
			this.groupBox3.Controls.Add(this.btnClose);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.TabStop = false;
			// 
			// tabControl1
			// 
			resources.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.Controls.Add(this.tbpReadInfo);
			this.tabControl1.Controls.Add(this.tbpSysConfig);
			this.tabControl1.Controls.Add(this.tbpSetPsw);
			this.tabControl1.Controls.Add(this.tbpSendString);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			// 
			// tbpReadInfo
			// 
			resources.ApplyResources(this.tbpReadInfo, "tbpReadInfo");
			this.tbpReadInfo.Controls.Add(this.btnReset);
			this.tbpReadInfo.Controls.Add(this.btnReHistoryWeather);
			this.tbpReadInfo.Controls.Add(this.btnPassWord);
			this.tbpReadInfo.Controls.Add(this.btnHistoryWeather);
			this.tbpReadInfo.Controls.Add(this.btnSysConfig);
			this.tbpReadInfo.Controls.Add(this.button1);
			this.tbpReadInfo.Name = "tbpReadInfo";
			this.tbpReadInfo.UseVisualStyleBackColor = true;
			// 
			// btnReset
			// 
			resources.ApplyResources(this.btnReset, "btnReset");
			this.btnReset.BackColor = System.Drawing.Color.LightGray;
			this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReset.FlatAppearance.BorderSize = 0;
			this.btnReset.Name = "btnReset";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnReHistoryWeather
			// 
			resources.ApplyResources(this.btnReHistoryWeather, "btnReHistoryWeather");
			this.btnReHistoryWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnReHistoryWeather.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReHistoryWeather.FlatAppearance.BorderSize = 0;
			this.btnReHistoryWeather.Name = "btnReHistoryWeather";
			this.btnReHistoryWeather.UseVisualStyleBackColor = false;
			this.btnReHistoryWeather.Click += new System.EventHandler(this.btnReHistoryWeather_Click);
			// 
			// btnPassWord
			// 
			resources.ApplyResources(this.btnPassWord, "btnPassWord");
			this.btnPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnPassWord.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPassWord.FlatAppearance.BorderSize = 0;
			this.btnPassWord.Name = "btnPassWord";
			this.btnPassWord.UseVisualStyleBackColor = false;
			this.btnPassWord.Click += new System.EventHandler(this.btnPassWord_Click);
			// 
			// btnHistoryWeather
			// 
			resources.ApplyResources(this.btnHistoryWeather, "btnHistoryWeather");
			this.btnHistoryWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnHistoryWeather.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHistoryWeather.FlatAppearance.BorderSize = 0;
			this.btnHistoryWeather.Name = "btnHistoryWeather";
			this.btnHistoryWeather.UseVisualStyleBackColor = false;
			this.btnHistoryWeather.Click += new System.EventHandler(this.btnHistoryWeather_Click);
			// 
			// button1
			// 
			resources.ApplyResources(this.button1, "button1");
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbpSysConfig
			// 
			resources.ApplyResources(this.tbpSysConfig, "tbpSysConfig");
			this.tbpSysConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
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
			this.tbpSysConfig.Name = "tbpSysConfig";
			// 
			// txtSaveTime
			// 
			resources.ApplyResources(this.txtSaveTime, "txtSaveTime");
			this.txtSaveTime.Name = "txtSaveTime";
			// 
			// btnSetSystemConfig
			// 
			resources.ApplyResources(this.btnSetSystemConfig, "btnSetSystemConfig");
			this.btnSetSystemConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.btnSetSystemConfig.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSetSystemConfig.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
			this.btnSetSystemConfig.Name = "btnSetSystemConfig";
			this.btnSetSystemConfig.UseVisualStyleBackColor = false;
			this.btnSetSystemConfig.Click += new System.EventHandler(this.btnSetSystemConfig_Click);
			// 
			// cmbDay
			// 
			resources.ApplyResources(this.cmbDay, "cmbDay");
			this.cmbDay.FormattingEnabled = true;
			this.cmbDay.Name = "cmbDay";
			// 
			// cmbMinute
			// 
			resources.ApplyResources(this.cmbMinute, "cmbMinute");
			this.cmbMinute.FormattingEnabled = true;
			this.cmbMinute.Name = "cmbMinute";
			// 
			// cmbMonth
			// 
			resources.ApplyResources(this.cmbMonth, "cmbMonth");
			this.cmbMonth.FormattingEnabled = true;
			this.cmbMonth.Name = "cmbMonth";
			// 
			// cmbLang
			// 
			resources.ApplyResources(this.cmbLang, "cmbLang");
			this.cmbLang.FormattingEnabled = true;
			this.cmbLang.Name = "cmbLang";
			// 
			// cmbHour
			// 
			resources.ApplyResources(this.cmbHour, "cmbHour");
			this.cmbHour.FormattingEnabled = true;
			this.cmbHour.Name = "cmbHour";
			// 
			// cmbYear
			// 
			resources.ApplyResources(this.cmbYear, "cmbYear");
			this.cmbYear.FormattingEnabled = true;
			this.cmbYear.Name = "cmbYear";
			// 
			// label11
			// 
			resources.ApplyResources(this.label11, "label11");
			this.label11.Name = "label11";
			// 
			// label10
			// 
			resources.ApplyResources(this.label10, "label10");
			this.label10.Name = "label10";
			// 
			// label9
			// 
			resources.ApplyResources(this.label9, "label9");
			this.label9.Name = "label9";
			// 
			// label18
			// 
			resources.ApplyResources(this.label18, "label18");
			this.label18.Name = "label18";
			// 
			// label16
			// 
			resources.ApplyResources(this.label16, "label16");
			this.label16.Name = "label16";
			// 
			// label17
			// 
			resources.ApplyResources(this.label17, "label17");
			this.label17.Name = "label17";
			// 
			// label14
			// 
			resources.ApplyResources(this.label14, "label14");
			this.label14.Name = "label14";
			// 
			// label15
			// 
			resources.ApplyResources(this.label15, "label15");
			this.label15.Name = "label15";
			// 
			// label13
			// 
			resources.ApplyResources(this.label13, "label13");
			this.label13.Name = "label13";
			// 
			// label12
			// 
			resources.ApplyResources(this.label12, "label12");
			this.label12.Name = "label12";
			// 
			// label8
			// 
			resources.ApplyResources(this.label8, "label8");
			this.label8.Name = "label8";
			// 
			// tbpSetPsw
			// 
			resources.ApplyResources(this.tbpSetPsw, "tbpSetPsw");
			this.tbpSetPsw.Controls.Add(this.btnPsw3);
			this.tbpSetPsw.Controls.Add(this.btnPsw6);
			this.tbpSetPsw.Controls.Add(this.btnPsw0);
			this.tbpSetPsw.Controls.Add(this.btnPswBack);
			this.tbpSetPsw.Controls.Add(this.btnPsw2);
			this.tbpSetPsw.Controls.Add(this.btnPsw5);
			this.tbpSetPsw.Controls.Add(this.btnPsw8);
			this.tbpSetPsw.Controls.Add(this.btnPsw1);
			this.tbpSetPsw.Controls.Add(this.btnPsw4);
			this.tbpSetPsw.Controls.Add(this.btnPsw7);
			this.tbpSetPsw.Controls.Add(this.panel1);
			this.tbpSetPsw.Controls.Add(this.btnPsw9);
			this.tbpSetPsw.Controls.Add(this.btnPswClear);
			this.tbpSetPsw.Name = "tbpSetPsw";
			this.tbpSetPsw.UseVisualStyleBackColor = true;
			// 
			// btnPsw3
			// 
			resources.ApplyResources(this.btnPsw3, "btnPsw3");
			this.btnPsw3.BackColor = System.Drawing.Color.Gainsboro;
			this.btnPsw3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnPsw3.Name = "btnPsw3";
			this.btnPsw3.UseVisualStyleBackColor = false;
			this.btnPsw3.Click += new System.EventHandler(this.btnPsw3_Click);
			// 
			// btnPsw6
			// 
			resources.ApplyResources(this.btnPsw6, "btnPsw6");
			this.btnPsw6.BackColor = System.Drawing.Color.Gainsboro;
			this.btnPsw6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnPsw6.Name = "btnPsw6";
			this.btnPsw6.UseVisualStyleBackColor = false;
			this.btnPsw6.Click += new System.EventHandler(this.btnPsw6_Click);
			// 
			// btnPsw0
			// 
			resources.ApplyResources(this.btnPsw0, "btnPsw0");
			this.btnPsw0.BackColor = System.Drawing.Color.Gainsboro;
			this.btnPsw0.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnPsw0.Name = "btnPsw0";
			this.btnPsw0.UseVisualStyleBackColor = false;
			this.btnPsw0.Click += new System.EventHandler(this.btnPsw0_Click);
			// 
			// btnPswBack
			// 
			resources.ApplyResources(this.btnPswBack, "btnPswBack");
			this.btnPswBack.BackColor = System.Drawing.Color.Gainsboro;
			this.btnPswBack.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnPswBack.Name = "btnPswBack";
			this.btnPswBack.UseVisualStyleBackColor = false;
			this.btnPswBack.Click += new System.EventHandler(this.btnPswBack_Click);
			// 
			// btnPsw2
			// 
			resources.ApplyResources(this.btnPsw2, "btnPsw2");
			this.btnPsw2.BackColor = System.Drawing.Color.Gainsboro;
			this.btnPsw2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnPsw2.Name = "btnPsw2";
			this.btnPsw2.UseVisualStyleBackColor = false;
			this.btnPsw2.Click += new System.EventHandler(this.btnPsw2_Click);
			// 
			// btnPsw5
			// 
			resources.ApplyResources(this.btnPsw5, "btnPsw5");
			this.btnPsw5.BackColor = System.Drawing.Color.Gainsboro;
			this.btnPsw5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnPsw5.Name = "btnPsw5";
			this.btnPsw5.UseVisualStyleBackColor = false;
			this.btnPsw5.Click += new System.EventHandler(this.btnPsw5_Click);
			// 
			// btnPsw8
			// 
			resources.ApplyResources(this.btnPsw8, "btnPsw8");
			this.btnPsw8.BackColor = System.Drawing.Color.Gainsboro;
			this.btnPsw8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnPsw8.Name = "btnPsw8";
			this.btnPsw8.UseVisualStyleBackColor = false;
			this.btnPsw8.Click += new System.EventHandler(this.btnPsw8_Click);
			// 
			// btnPsw1
			// 
			resources.ApplyResources(this.btnPsw1, "btnPsw1");
			this.btnPsw1.BackColor = System.Drawing.Color.Gainsboro;
			this.btnPsw1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnPsw1.Name = "btnPsw1";
			this.btnPsw1.UseVisualStyleBackColor = false;
			this.btnPsw1.Click += new System.EventHandler(this.btnPsw1_Click);
			// 
			// btnPsw4
			// 
			resources.ApplyResources(this.btnPsw4, "btnPsw4");
			this.btnPsw4.BackColor = System.Drawing.Color.Gainsboro;
			this.btnPsw4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnPsw4.Name = "btnPsw4";
			this.btnPsw4.UseVisualStyleBackColor = false;
			this.btnPsw4.Click += new System.EventHandler(this.btnPsw4_Click);
			// 
			// btnPsw7
			// 
			resources.ApplyResources(this.btnPsw7, "btnPsw7");
			this.btnPsw7.BackColor = System.Drawing.Color.Gainsboro;
			this.btnPsw7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnPsw7.FlatAppearance.BorderSize = 0;
			this.btnPsw7.Name = "btnPsw7";
			this.btnPsw7.UseVisualStyleBackColor = false;
			this.btnPsw7.Click += new System.EventHandler(this.btnPsw7_Click);
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.btnSetPsw);
			this.panel1.Controls.Add(this.txtPsw);
			this.panel1.Name = "panel1";
			// 
			// btnSetPsw
			// 
			resources.ApplyResources(this.btnSetPsw, "btnSetPsw");
			this.btnSetPsw.BackColor = System.Drawing.Color.PaleGreen;
			this.btnSetPsw.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSetPsw.FlatAppearance.BorderSize = 0;
			this.btnSetPsw.Name = "btnSetPsw";
			this.btnSetPsw.UseVisualStyleBackColor = false;
			this.btnSetPsw.Click += new System.EventHandler(this.btnSetPsw_Click);
			// 
			// txtPsw
			// 
			resources.ApplyResources(this.txtPsw, "txtPsw");
			this.txtPsw.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtPsw.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPsw.Name = "txtPsw";
			this.txtPsw.ReadOnly = true;
			// 
			// btnPsw9
			// 
			resources.ApplyResources(this.btnPsw9, "btnPsw9");
			this.btnPsw9.BackColor = System.Drawing.Color.Gainsboro;
			this.btnPsw9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnPsw9.Name = "btnPsw9";
			this.btnPsw9.UseVisualStyleBackColor = false;
			this.btnPsw9.Click += new System.EventHandler(this.btnPsw9_Click);
			// 
			// btnPswClear
			// 
			resources.ApplyResources(this.btnPswClear, "btnPswClear");
			this.btnPswClear.BackColor = System.Drawing.Color.Gainsboro;
			this.btnPswClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnPswClear.Name = "btnPswClear";
			this.btnPswClear.UseVisualStyleBackColor = false;
			this.btnPswClear.Click += new System.EventHandler(this.btnPswClear_Click);
			// 
			// tbpSendString
			// 
			resources.ApplyResources(this.tbpSendString, "tbpSendString");
			this.tbpSendString.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tbpSendString.Controls.Add(this.label7);
			this.tbpSendString.Controls.Add(this.label6);
			this.tbpSendString.Controls.Add(this.txtTimeCell);
			this.tbpSendString.Controls.Add(this.ckbAutoSend);
			this.tbpSendString.Controls.Add(this.txtSend);
			this.tbpSendString.Controls.Add(this.btnSend);
			this.tbpSendString.Name = "tbpSendString";
			// 
			// label7
			// 
			resources.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// txtTimeCell
			// 
			resources.ApplyResources(this.txtTimeCell, "txtTimeCell");
			this.txtTimeCell.Name = "txtTimeCell";
			// 
			// ckbAutoSend
			// 
			resources.ApplyResources(this.ckbAutoSend, "ckbAutoSend");
			this.ckbAutoSend.Name = "ckbAutoSend";
			this.ckbAutoSend.UseVisualStyleBackColor = true;
			// 
			// txtSend
			// 
			resources.ApplyResources(this.txtSend, "txtSend");
			this.txtSend.Name = "txtSend";
			// 
			// btnSend
			// 
			resources.ApplyResources(this.btnSend, "btnSend");
			this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSend.Name = "btnSend";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// btnSysConfig
			// 
			resources.ApplyResources(this.btnSysConfig, "btnSysConfig");
			this.btnSysConfig.BackColor = System.Drawing.Color.Turquoise;
			this.btnSysConfig.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSysConfig.FlatAppearance.BorderSize = 0;
			this.btnSysConfig.Name = "btnSysConfig";
			this.btnSysConfig.UseVisualStyleBackColor = false;
			this.btnSysConfig.Click += new System.EventHandler(this.btnSysConfig_Click);
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
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
			this.tbpSetPsw.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
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
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSetPsw;
		private System.Windows.Forms.TextBox txtPsw;
		private System.Windows.Forms.Button btnPsw3;
		private System.Windows.Forms.Button btnPsw6;
		private System.Windows.Forms.Button btnPsw9;
		private System.Windows.Forms.Button btnPsw0;
		private System.Windows.Forms.Button btnPswBack;
		private System.Windows.Forms.Button btnPsw2;
		private System.Windows.Forms.Button btnPsw5;
		private System.Windows.Forms.Button btnPsw8;
		private System.Windows.Forms.Button btnPsw1;
		private System.Windows.Forms.Button btnPsw4;
		private System.Windows.Forms.Button btnPsw7;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnReHistoryWeather;
		private System.Windows.Forms.Button btnPswClear;
		private System.Windows.Forms.Button btnSysConfig;
	}
}

