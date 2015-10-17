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
		public Form1()
		{
			InitializeComponent();
		}
		SerialPort serialPort = new SerialPort();
		public byte dbit = 8;
		DateTime dt = DateTime.Now;
		System.Timers.Timer tm = new System.Timers.Timer();
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
						string rec = null;
						rec = Encoding.ASCII.GetString(buffer);
						textBox6.AppendText("接收数据：" + rec);
						textBox6.AppendText("\r\n");
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
						byte[] SendMessage = System.Text.Encoding.Default.GetBytes(textBox7.Text);
						serialPort.Write(SendMessage, 0, SendMessage.Length);
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
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message, "信息提示");
			}
		}

		private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string str = "0101000000203DD2";
				byte[] SendMessage = System.Text.Encoding.Default.GetBytes(str);
				serialPort.Write(SendMessage, 0, SendMessage.Length);
				toolStripStatusLabel1.Text = "发送数据成功";
				textBox6.AppendText("发送数据：0101000000203DD2C\r\n");
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
				byte[] SendMessage = System.Text.Encoding.Default.GetBytes(str);
				serialPort.Write(SendMessage, 0, SendMessage.Length);

				toolStripStatusLabel1.Text = "发送数据成功";
				textBox6.AppendText("发送数据：010400000020F1D2\r\n");
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
			//点击button之后，新开线程，用来检测时间，时间到了可以自动触发并发送指令

			DateTime StartTime;
			DateTime.TryParse(comboBox2.Text, out StartTime);
			DateTime OverTime;
			DateTime.TryParse(comboBox3.Text, out OverTime);
			try
			{
			//	if(DateTime.Now == StartTime)
				//{
				tm.Start();
				tm.Elapsed += new ElapsedEventHandler(timer1_Tick);
				tm.Enabled = true;
				tm.Interval = 3000;
					//将当前时间转换成时分秒形式，并每个三十秒输出时间间隔
					
				//}
				textBox6.AppendText("发送信息[电机]：01001010101010");
				textBox6.AppendText("\r\n");
				if(DateTime.Now == OverTime)
				{
					tm.Stop();
					tm.Enabled = false;
				}

			}
			catch(Exception ee)
			{
				MessageBox.Show(ee.Message, "提示信息");
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				//DateTime dt = DateTime.Now;
			//	DateTime StartTime;
			//	DateTime.TryParse(comboBox2.Text, out StartTime);
			//	string NowTime = dt.ToLongTimeString().ToString();
			//	DateTime NewTime;
			//	DateTime.TryParse(NowTime, out NewTime);
				//textBox1.Text = (NewTime - StartTime).ToString();
				//每隔三十秒输出指令
				string str = "01001010101010 ";
				byte[] SendMessage = System.Text.Encoding.Default.GetBytes(str);
				serialPort.Write(SendMessage, 0, SendMessage.Length);
				//textBox6.AppendText("发送信息[电机]：" + str);
			//	textBox6.AppendText("\r\n");
			}
			catch(Exception ee)
			{
				MessageBox.Show(ee.Message,"提示信息");
			}
					
		}
	}
}
		
