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
		Thread _thread;
		bool _ifSet = false;
		List<Command> commands;
		public MainForm()
		{
			InitializeComponent();
		}

		void WritePort(byte[] data)
		{
			if (_serialPort == null || !_serialPort.IsOpen)
			{
				MessageBox.Show("请先配置打开串口", "失败");
				return;
			}
			_serialPort.Write(data, 0, data.Length);
			DateTime dt = DateTime.Now;
			string showData = Transfer.BaToS(data);

			this.Invoke((EventHandler)(delegate
			{
				lbSendData.Items.Add(dt.TimeOfDay + "###" + showData);
				lbSendData.SelectedIndex = lbSendData.Items.Count - 1;
			}));
			WriteData.SendLog(dt,showData);
		}

		private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
		{
			byte[] readbyte = new byte[_serialPort.BytesToRead];

			_serialPort.Read(readbyte, 0, readbyte.Length);
			DateTime dt = DateTime.Now;
			string showData = Transfer.BaToS(readbyte);

			this.Invoke((EventHandler)(delegate
			{
				lbReceiveData.Items.Add(dt.TimeOfDay + "###" + showData);
				lbReceiveData.SelectedIndex = lbReceiveData.Items.Count - 1;
			}));
			WriteData.ReciveLog(dt, showData);
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
			_serialPort = new SerialPort();
			_serialPort.DataReceived += DataReceivedHandler;
			tmrDateTime.Start();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_serialPort != null && _serialPort.IsOpen)
				_serialPort.Close();
			if (_thread != null && _thread.IsAlive)
				_thread.Abort();
		}

		private void btnSwitchPort_Click(object sender, EventArgs e)
		{
			_ifSet = true;
			_serialPort.PortName = cbPortName.Text;
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
			btnSwitchPort.Enabled = false;
			lblTip.Text = "每天六点整时，程序将自动按下启动按钮";
			lblTip.ForeColor = Color.Green;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (!_ifSet)
			{
				MessageBox.Show("请先配置串口参数");
				return;
			}
			_thread = new Thread(new ThreadStart(Work));
			commands = Translate.Translation();
			if (commands == null)
				return;
			lblTimesToDo.Text = Convert.ToInt32(txtTimes.Text).ToString();
			btnStart.Enabled = false;
			txtTimes.Enabled = false;
			_thread.Start();
		}

		void Work()
		{
			while (Convert.ToInt32(lblTimesToDo.Text) > 0)
			{
				lblTimesToDo.Text = (Convert.ToInt32(lblTimesToDo.Text) - 1).ToString();
				foreach(Command c in commands)
				{
					switch(c.Open)
					{
						case "open":
							{
								_serialPort.BaudRate = c.Files;
								try
								{
									_serialPort.Open();
								}
								catch(Exception ex)
								{
									MessageBox.Show(ex.Message);
									Application.Exit();
								}
								break;
							}
						case"close":
							{
								_serialPort.Close();
								break;
							}
						case "send":
							{
								WritePort(c.Array);
								break;
							}
						case "sleep":
							{
								Thread.Sleep(c.Files);
								break;
							}
					}
				}
			}
			btnStart.Enabled = true;
			txtTimes.Enabled = true;
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			lblTimesToDo.Text = "0";
		}

		private void cbBaudRate_MouseUp(object sender, MouseEventArgs e)
		{
			MessageBox.Show("请使用Open [波特率] 命令");
		}

		private void tmrDateTime_Tick(object sender, EventArgs e)
		{
			lalDateTime.Text = DateTime.Now.ToString();
			if (DateTime.Now.Hour == 6 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0 && btnStart.Enabled && _ifSet)
			{
				btnStart_Click(sender, e);
			}
		}

	}
}
