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
		Thread _sendHeartbeatThread;
		int _heartbeatCycle;

		public MainForm()
		{
			InitializeComponent();
		}

		void SendHeartbeat()
		{
			while(true)
			{
				byte[] heartbeat = { 0xAA, _testerID, 0x00, 0xCC, 0x33, 0xC3, 0x3C };
				_serialPort.Write(heartbeat, 0, heartbeat.Length);
				Thread.Sleep(_heartbeatCycle);
			}
		}

		void WritePort(byte[] data, string messege)
		{
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
			lbSendData.Items.Add(showData);
			lbSendData.SelectedIndex = lbSendData.Items.Count - 1;
			lbSendExplanation.Items.Add(messege);
			lbSendExplanation.SelectedIndex = lbSendData.Items.Count - 1;
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
			lbReceiveData.Items.Add(showData);
			lbReceiveData.SelectedIndex = lbReceiveData.Items.Count - 1;
			lbReceiveExplanation.Items.Add(Explainer.Explain(readbyte));
			lbReceiveExplanation.SelectedIndex = lbReceiveExplanation.Items.Count - 1;
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
				if (_sendHeartbeatThread != null && _sendHeartbeatThread.IsAlive)
					_sendHeartbeatThread.Abort();
				if (_serialPort.IsOpen)
					_serialPort.Close();
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
			if(_serialPort == null || !_serialPort.IsOpen)
			{
				MessageBox.Show("请先打开串口","失败");
				return;
			}

			if (_sendHeartbeatThread != null && _sendHeartbeatThread.IsAlive)
				_sendHeartbeatThread.Abort();
			if (btnSwitchHeartbeat.Text == "终止")
			{
				btnSwitchHeartbeat.Text = "开始";
				return;
			}
			_heartbeatCycle = Convert.ToInt32(txtHeartbeat.Text);
			_sendHeartbeatThread = new Thread(new ThreadStart(SendHeartbeat));
			_sendHeartbeatThread.Start();
			btnSwitchHeartbeat.Text = "终止";
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_sendHeartbeatThread != null && _sendHeartbeatThread.IsAlive)
				_sendHeartbeatThread.Abort();
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
			byte commandCode;
			switch(cbSystem.Text)
			{
				case "测量命令":
					commandCode = 0x05;
					break;
				case "辐照度测量":
					commandCode = 0x06;
					break;
				case "温度测量":
					commandCode = 0x07;
					break;
				case "电源电压测量":
					commandCode = 0x08;
					break;
				case "IV特性数据":
					commandCode = 0x09;
					break;
				case "IV-STC特性数据":
					commandCode = 0x0A;
					break;
				case "存储命令":
					commandCode = 0x0B;
					break;
				case "电压系数测量":
					commandCode = 0x3D;
					break;
				case "电流系数测量":
					commandCode = 0x3E;
					break;
				case "辐照度系数测量":
					commandCode = 0x3F;
					break;
				case "温度系数测量":
					commandCode = 0x40;
					break;
				case "电源电压系数测量":
					commandCode = 0x42;
					break;
				default:
					MessageBox.Show("请选择操作!", "错误");
					return;
			}
			
			byte[] systemCommand = { 0xAA, _testerID, 0x01, commandCode, 0xCC, 0x33, 0xC3, 0x3C };
			WritePort(systemCommand, "系统命令:" + cbSystem.Text);
		}
	}
}
