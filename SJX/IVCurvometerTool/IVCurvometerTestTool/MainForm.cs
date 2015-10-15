using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using Microsoft.VisualBasic.Devices;

namespace IVCurvometerTestTool
{
	public partial class MainForm : Form
	{

		SerialPort _serialPort;

		public MainForm()
		{
			InitializeComponent();
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
		}

		private void btnSwitchPort_Click(object sender, EventArgs e)
		{
			if(btnSwitchPort.Text == "关闭串口")
			{
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
	}
}
