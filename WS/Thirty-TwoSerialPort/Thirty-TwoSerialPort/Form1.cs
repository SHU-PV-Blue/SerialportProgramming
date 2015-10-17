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
using System.Timers;

namespace Thirty_TwoSerialPort
{
	public partial class Form1 : Form
	{
		bool isStart = false;
		public Form1()
		{
			InitializeComponent();
		}
		SerialPort serialPort = new SerialPort();
		public byte dbit = 8;
		System.Timers.Timer tm = new System.Timers.Timer();
		System.Timers.Timer TimeGetSencond = new System.Timers.Timer();
		System.Timers.Timer TimeReadSencond = new System.Timers.Timer();
		private StringBuilder builder = new StringBuilder();
		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string[] port = SerialPort.GetPortNames();
			Array.Sort(port);
			comboBox1.Items.AddRange(port);
			if (port.Length != 0)
			{
				comboBox1.SelectedIndex = 0;
			}
			else
			{
				comboBox1.SelectedIndex = -1;
			}
			comboBox2.SelectedIndex = 0;
			comboBox3.SelectedIndex = 0;
			serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
		}
		private delegate void textBox6CallBack();
		void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs ee)
		{
			textBox6CallBack callback = delegate()
			{
				try
				{
					if (serialPort.IsOpen)
					{
						toolStripStatusLabel1.Text = "正在接收数据。。。。";
						int bytes = serialPort.BytesToRead;
						byte[] buffer = new byte[bytes];
						serialPort.Read(buffer, 0, bytes);
						builder.Clear();
						foreach(byte b in buffer)
						{
							builder.Append(b.ToString("X2") + " ");
						}
						textBox6.AppendText("接收数据：" + builder.ToString());
						textBox6.AppendText(Environment.NewLine);
						toolStripStatusLabel1.Text = "数据接收完成。。。。";
					}
					else
					{
						MessageBox.Show("请打开串口！！", "错误提示");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			};
			textBox6.Invoke(callback);
		}
		private void button4_Click(object sender, EventArgs e)
		{
			textBox7.Text = "";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				if (serialPort.IsOpen)
				{
					if (textBox7.Text == "")
					{
						MessageBox.Show("发送数据不能为空");
						return;
					}
					else
					{
						string str = textBox7.Text;
						str = str.Replace(" ", "");
						byte[] Sendbyte = new byte[str.Length / 2];
						for (int i = 0, j = 0; i < str.Length; i = i + 2, j++)
						{
							string mysubstring = str.Substring(i, 2);
							Sendbyte[j] = Convert.ToByte(mysubstring, 16);
						}

						serialPort.Write(Sendbyte, 0, Sendbyte.Length);
						textBox6.AppendText("发送数据: " + textBox7.Text);
						textBox6.AppendText("\r\n");
						toolStripStatusLabel1.Text = "发送数据成功";
					}
				}
				else
				{
					MessageBox.Show("请开启端口", "信息提示");
				}
			}
			catch
			{
				MessageBox.Show("请确保输入的指令正确", "信息提示");
			}
		}

		private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string str = "0101000000203DD2";
				byte[] Sendbyte = new byte[str.Length / 2];
				for (int i = 0, j = 0; i < str.Length; i = i + 2, j++)
				{
					string mysubstring = str.Substring(i, 2);
					Sendbyte[j] = Convert.ToByte(mysubstring, 16);
				}
				serialPort.Write(Sendbyte, 0, Sendbyte.Length);
				toolStripStatusLabel1.Text = "发送数据成功";
				textBox6.AppendText("发送数据：01 01 00 00 00 20 3D D2\r\n");
			}
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message);
			}
		}

		private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string str = "010400000020F1D2";
				byte[] Sendbyte = new byte [str.Length / 2];
				for (int i = 0,j = 0; i < str.Length; i = i +2,j++)
				{
					string mysubstring = str.Substring(i,2);
					Sendbyte[j] = Convert.ToByte(mysubstring,16);
				}

				serialPort.Write(Sendbyte, 0, Sendbyte.Length);
				toolStripStatusLabel1.Text = "发送数据成功";
				textBox6.AppendText("发送数据：01 04 00 00 00 20 F1 D2\r\n");
			}
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message);
			}
		}

		private void 继电器控制命令ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			Parity parity = Parity.None;
			StopBits stopbits = StopBits.One;
			serialPort.PortName = comboBox1.Text;
			serialPort.BaudRate = int.Parse("9600");
			serialPort.DataBits = dbit;
			serialPort.Parity = parity;
			serialPort.StopBits = stopbits;
			try
			{
				if (toolStripButton1.Text == "关闭串口")
				{
					serialPort.Close();
					toolStripButton1.Text = "开启串口";
					toolStripStatusLabel1.Text = "串口成功关闭";

				}
				else
				{
					serialPort.Open();
					toolStripButton1.Text = "关闭串口";
					toolStripStatusLabel1.Text = "串口成功开启,正在准备发送数据... ...";
				}
			}
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message, "信息提示");
			}
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			if (serialPort.IsOpen)
			{
				MessageBox.Show("请关闭端口", "信息提示");
			}
			else
			{
				this.Close();
			}
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			if (serialPort.IsOpen)
			{
				if (toolStripButton3.Text == "打开串口")
				{
					toolStripButton3.Text = "关闭串口";
					MessageBox.Show("已经启动双轴电机", "信息提示");
					if (isStart)
					{
						return;
					}
					isStart = true;
					DateTime dt = DateTime.Now;
					DateTime StartTime;
					DateTime.TryParse(comboBox2.Text, out StartTime);
					DateTime EndTime;
					DateTime.TryParse(comboBox3.Text, out EndTime);
					try
					{
						TimeReadSencond.Start();
						TimeReadSencond.Enabled = true;
						TimeReadSencond.Interval = 1000;
						TimeReadSencond.Elapsed += new ElapsedEventHandler(timer3_Tick);
						//string StrTime = dt.ToLongTimeString().ToString();
						//DateTime NowTime;
						//DateTime.TryParse(StrTime, out NowTime);
						//if (NowTime == EndTime)
						//{
						//	tm.Stop();
						//	tm.Enabled = false;
						//	TimeGetSencond.Stop();
						//	TimeGetSencond.Enabled = false;
						//}
					}
					catch (Exception ee)
					{
						MessageBox.Show(ee.Message, "信息提示");
					}
				}
				if(toolStripButton3.Text == "关闭双轴电机")
				{
					tm.Stop();
					TimeGetSencond.Stop();
				}
			}
			else
			{
				MessageBox.Show("请打开端口", "信息提示");
			}
			}
		private delegate void Combobox2CallBack();
		private void timer1_Tick(object sender, EventArgs e)
		{
			textBox6CallBack callback = delegate()
			{
				try
				{

					string str = "010400000020F1D2";
					byte[] Sendbyte = new byte[str.Length / 2];
					for (int i = 0, j = 0; i < str.Length; i = i + 2, j++)
					{
						string mysubstring = str.Substring(i, 2);
						Sendbyte[j] = Convert.ToByte(mysubstring, 16);
					}
					serialPort.Write(Sendbyte, 0, Sendbyte.Length);

					textBox6.AppendText("发送信息[电机：" + DateTime.Now + "]" + "01 04 00 00 00 20 F1 D2\r\n");
				}
				catch (Exception ee)
				{
					MessageBox.Show(ee.Message, "提示信息");
				}
			};
			textBox6.Invoke(callback);
					
		}
		private void timer2_Tick(object sender,EventArgs e)
		{
			Combobox2CallBack comcalback = delegate()
			{

				try
				{
					DateTime dt = DateTime.Now;
					DateTime StartTime;
					DateTime.TryParse(comboBox2.Text, out StartTime);
					string StrTime = dt.ToLongTimeString().ToString();
					DateTime NowTime;
					DateTime.TryParse(StrTime, out NowTime);
					textBox1.Text = (NowTime - StartTime).ToString();
					toolStripStatusLabel1.Text = "发送成功";
				}
				catch (Exception ee)
				{
					MessageBox.Show(ee.Message, "信息提示");
				}
			};
			comboBox2.Invoke(comcalback);
		}
		private void timer3_Tick(object sender, EventArgs e)
		{
			Combobox2CallBack comcalback = delegate()
			{
				try
				{
					DateTime dt = DateTime.Now;
					string StrTime = dt.ToLongTimeString().ToString();
					DateTime NowTime;
					DateTime.TryParse(StrTime, out NowTime);
					DateTime StartTime;
					DateTime.TryParse(comboBox2.Text, out StartTime);
					DateTime EndTime;
					DateTime.TryParse(comboBox3.Text, out EndTime);
					if (StartTime == NowTime)
					{
						tm.Start();
						tm.Enabled = true;
						tm.Interval = 3000;
						tm.Elapsed += new ElapsedEventHandler(timer1_Tick);
						TimeGetSencond.Start();
						TimeGetSencond.Elapsed += new ElapsedEventHandler(timer2_Tick);
						TimeGetSencond.Enabled = true;
						TimeGetSencond.Interval = 1000;
					}
					if (EndTime == NowTime)
					{
						tm.Stop();
						TimeGetSencond.Stop();
					}
				}
				catch (Exception ee)
				{
					MessageBox.Show(ee.Message);
				}
			};
			comboBox2.Invoke(comcalback);
		}
	}
}
		
