using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.IO.Ports;
using Microsoft.VisualBasic.Devices;

namespace IVCurvometerTestTool
{
	public partial class MainForm : Form
	{

		SerialPort _serialPort;
		byte _testerID;

		public MainForm()
		{
			InitializeComponent();
		}

		void WritePort(byte[] data, string messege)
		{
			if (_serialPort == null || !_serialPort.IsOpen)
			{
				MessageBox.Show("请先打开串口", "失败");
				return;
			}
			_serialPort.Write(data, 0, data.Length);
			string showData = "";
			foreach(var b in data)
			{
				string str = Convert.ToString(b, 16);
				str = str.ToUpper();
				if (str.Length == 1)
					str = "0" + str;
				showData += str + " ";
			}
			this.Invoke((EventHandler)(delegate
			{
				lbSendData.Items.Add(showData);
				lbSendData.SelectedIndex = lbSendData.Items.Count - 1;
				lbSendExplanation.Items.Add(messege);
				lbSendExplanation.SelectedIndex = lbSendData.Items.Count - 1;
			}));
		}

		void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
		{
			byte[] readbyte = new byte[_serialPort.BytesToRead];

			_serialPort.Read(readbyte, 0, readbyte.Length);

			string showData = "";
			foreach (var b in readbyte)
			{
				string str = Convert.ToString(b, 16);
				str = str.ToUpper();
				if (str.Length == 1)
					str = "0" + str;
				showData += str + " ";
			}
			this.Invoke((EventHandler)(delegate
			{
				lbReceiveData.Items.Add(showData);
				lbReceiveData.SelectedIndex = lbReceiveData.Items.Count - 1;
				lbReceiveExplanation.Items.Add(Explainer.Explain(readbyte));
				lbReceiveExplanation.SelectedIndex = lbReceiveExplanation.Items.Count - 1;
			}));
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Computer com = new Computer();
			if (com.Ports.SerialPortNames.Count != 0)
			{
				cbPortName.Items.Clear();
				foreach (string str in com.Ports.SerialPortNames)
					cbPortName.Items.Add(str);
			}
			_testerID = Convert.ToByte(txtTesterID.Text, 16);
		}

		private void btnSwitchPort_Click(object sender, EventArgs e)
		{
			if(btnSwitchPort.Text == "关闭串口")
			{
				if (_serialPort.IsOpen)
					_serialPort.Close();
				tmrSendHeartbeat.Stop();
				btnSwitchPort.Text = "打开串口";
				return;
			}

			if (string.IsNullOrEmpty(cbPortName.Text) || cbPortName.Text == "无可用")
			{
				MessageBox.Show("请选择可用串口");
				return;
			}
			_serialPort = new SerialPort(cbPortName.Text, Convert.ToInt32(cbBaudRate.Text));
			switch (cbParity.Text)
			{
				case "None":
					_serialPort.Parity = Parity.None;
					break;
				case "Odd":
					_serialPort.Parity = Parity.Odd;
					break;
				case "Even":
					_serialPort.Parity = Parity.Even;
					break;
				case "Mark":
					_serialPort.Parity = Parity.Mark;
					break;
				case "Space":
					_serialPort.Parity = Parity.Space;
					break;
			}
			_serialPort.DataBits = Convert.ToInt32(cbDataBits.Text);
			switch (cbStopBits.Text)
			{

				case "0":
					_serialPort.StopBits = StopBits.None;
					break;
				case "1":
					_serialPort.StopBits = StopBits.One;
					break;
				case "2":
					_serialPort.StopBits = StopBits.Two;
					break;
				case "1.5":
					_serialPort.StopBits = StopBits.OnePointFive;
					break;
			}
			_serialPort.ReadTimeout = 1;
			_serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
			try
			{
				_serialPort.Open();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"打开串口失败");
				return;
			}
			btnSwitchPort.Text = "关闭串口";
		}

		private void btnSwitchHeartbeat_Click(object sender, EventArgs e)
		{
			if (btnSwitchHeartbeat.Text == "终止")
			{
				tmrSendHeartbeat.Stop();
				btnSwitchHeartbeat.Text = "开始";
				return;
			}
			tmrSendHeartbeat.Interval = Convert.ToInt32(txtHeartbeat.Text);
			tmrSendHeartbeat.Start();
			btnSwitchHeartbeat.Text = "终止";
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_serialPort != null && _serialPort.IsOpen)
				_serialPort.Close();
		}

		private void btnTesterID_Click(object sender, EventArgs e)
		{
			_testerID = Convert.ToByte(txtTesterID.Text, 16);
		}

		private void btnSystem_Click(object sender, EventArgs e)
		{
			if (_serialPort == null || !_serialPort.IsOpen)
			{
				MessageBox.Show("请先打开串口", "失败");
				return;
			}
			byte commandCode = 0;
			bool ifFind = false;
			foreach(var p in CodeCommadPair.系统操作)
			{
				if (p.Value == cbSystem.Text)
				{
					commandCode = p.Key;
					ifFind = true;
					break;
				}
			}
			if (!ifFind)
			{
				MessageBox.Show("请选择操作!", "错误");
				return;
			}
			byte[] systemCommand = { 0xAA, _testerID, 0x01, commandCode, 0xCC, 0x33, 0xC3, 0x3C };
			WritePort(systemCommand, "系统操作:" + cbSystem.Text);
		}

		private void tmrSendHeartbeat_Tick(object sender, EventArgs e)
		{
			byte[] heartbeat = { 0xAA, _testerID, 0x00, 0xCC, 0x33, 0xC3, 0x3C };
			_serialPort.Write(heartbeat, 0, heartbeat.Length);
		}

		private void btnPageTips_Click(object sender, EventArgs e)
		{
			byte pageID = 0;
			byte pageType = 0;
			byte pageOperate = 0;
			bool ifFind;

			ifFind = false;
			foreach (var p in CodeCommadPair.页面类型)
			{
				if (p.Value == cbPageType.Text)
				{
					pageType = p.Key;
					ifFind = true;
				}
			}
			if (!ifFind)
			{
				MessageBox.Show("请选择页面类型", "错误");
				return;
			}

			ifFind = false;
			foreach(var p in CodeCommadPair.页面编号)
			{
				if(p.Value == cbPageID.Text)
				{
					pageID = p.Key;
					ifFind = true;
				}
			}
			if(!ifFind)
			{
				MessageBox.Show("请选择页面编号", "错误");
				return;
			}


			ifFind = false;
			foreach (var p in CodeCommadPair.页面操作)
			{
				if (p.Value == cbPageOperate.Text)
				{
					pageOperate = p.Key;
					ifFind = true;
				}
			}
			if (!ifFind)
			{
				MessageBox.Show("请选择页面操作", "错误");
				return;
			}

			byte[] buffer = { 0xAA, _testerID, 0x14, pageID, pageType, pageOperate, 0xCC, 0x33, 0xC3, 0x3C };
			WritePort(buffer, "页面提示:" + cbPageType.Text + ":" + cbPageID.Text + ":" + cbPageOperate.Text);
		}

		private void btnGetData_Click(object sender, EventArgs e)
		{
			byte[] address = new byte[2];
			bool ifFind = false;

			foreach (var p in CodeCommadPair.数据地址)
			{
				if (p.Value == cbGetData.Text)
				{
					address = p.Key;
					ifFind = true;
				}
			}
			if (!ifFind)
			{
				MessageBox.Show("请选择页面类型", "错误");
				return;
			}
			byte[] buffer = { 0xAA, _testerID, 0x11, address[0], address[1], 0xCC, 0x33, 0xC3, 0x3C };
			WritePort(buffer, "数据查询:" + cbGetData.Text);
		}
	}
}
