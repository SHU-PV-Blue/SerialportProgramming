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
using System.IO;

namespace SerialDemo_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SerialPort sp = new SerialPort();
		public static string strPortName = "";
		public static string strBaudRate = "";
		public static string strDataBits = "";
		public static string strStopBits = "";
		bool IsSended = false;
		Timer AutoSendTimer = new Timer();
		StringBuilder Recivestr = new StringBuilder();
		
		

		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			string[] ports = SerialPort.GetPortNames();
			Array.Sort(ports);
			cmbPorts.Items.AddRange(ports);
			sp.DataReceived += ReciveData;
			InitParam();
			AutoSendTimer.Tick  += new EventHandler(AutoSend);
		}

		/// <summary>
		/// 设置参数,将参数赋值到串口中
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSetParam_Click(object sender, EventArgs e)
		{
			try
			{
				strPortName = cmbPorts.Text;
				strBaudRate = cmbBaudRate.Text;
				strDataBits = cmbDataBit.Text;
				strStopBits = cmbStopBit.Text;

				sp.PortName = strPortName;
				sp.BaudRate = Convert.ToInt32(strBaudRate);
				sp.DataBits = Convert.ToByte(strDataBits);
				sp.StopBits = StopBits.One;
				sp.ReadTimeout = 500;

				sp.Open();
			}
			catch (Exception ex)
			{
				txtRecive.AppendText("异常: " + ex.Message);
				txtRecive.AppendText("\r\n");
			}
		}

		/// <summary>
		/// 初始化参数函数
		/// </summary>
		private void InitParam()
		{
			try
			{
				cmbPorts.SelectedIndex = 0;
				cmbBaudRate.SelectedIndex = 0;
				cmbDataBit.SelectedIndex = 0;
				cmbParity.SelectedIndex = 0;
				cmbStopBit.SelectedIndex = 0;
			}
			catch (Exception ex)
			{
				txtRecive.AppendText("异常:" + ex.Message + "\r\n");
			}
			
		}

		/// <summary>
		/// 关闭串口
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClose_Click(object sender, EventArgs e)
		{
			if(sp.IsOpen)
				sp.Close();
		}

		/// <summary>
		/// 退出程序
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExit_Click(object sender, EventArgs e)
		{
			if(sp.IsOpen)
				sp.Close();
			this.Close();
		}

		/// <summary>
		/// 发送数据
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSend_Click(object sender, EventArgs e)
		{
			
				if (ckbAutoSend.Checked)
				{
					if (!IsSended)
					{
						btnSend.Text = "停止";
						int interval;
						if( ! int.TryParse(txtTimeCell.Text, out interval))
							interval = 1;
						AutoSendTimer.Interval = 1000 * interval;
						AutoSendTimer.Start();
						IsSended = true;
					}
					else
					{
						btnSend.Text = "发送";
						AutoSendTimer.Stop();
						AutoSendTimer.Dispose();
						IsSended = false;
					}
				}
				else
				{
					try 
					{
						Send();
					}
					catch (Exception ex) { txtRecive.AppendText("异常: " + ex.Message + "\r\n"); }
				}
		}


		/// <summary>
		/// 发送数据
		/// </summary>
		private void Send()
		{
			if (sp != null)
			{
				string mess = txtSend.Text.Trim();
				string[] messages = mess.Split(' ');
				byte[] buf = Array.ConvertAll(messages, new Converter<string, byte>(StringToHex));
				sp.Write(buf, 0, buf.Length);
			}
		}
		public static byte StringToHex(string str)
		{
			return Convert.ToByte(str, 16);
		}

		/// <summary>
		/// 自动发送的内容
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AutoSend(object sender, EventArgs e) 
		{
			try 
			{
				Send();
			}
			catch (Exception ex) { txtRecive.AppendText("异常: " + ex.Message + "\r\n"); }
		}

		private void btnInit_Click(object sender, EventArgs e)
		{
			
		}

		/// <summary>
		/// 接收数据线程
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ReciveData(object sender, SerialDataReceivedEventArgs e)
		{
				DateTime dt = DateTime.Now;
				int n = sp.BytesToRead;			//缓冲区中的字节数
				byte[] buffer = new byte[n];
				sp.Read(buffer, 0, n);
				this.Invoke((EventHandler)(delegate
				{
					txtRecive.AppendText(dt.ToString() +" "+ TranString(buffer));
					txtRecive.AppendText("\r\n");
					
				}));
				FileStream fs = new FileStream(@"E:\光伏\串口\Data\" + "1.txt", FileMode.OpenOrCreate, FileAccess.Write);
				fs.Position = fs.Length;                  //将待写入内容追加到文件末尾  
				StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);//(fs, System.Text.Encoding.GetEncoding("GB2312"));
				sw.Flush();
				sw.BaseStream.Seek(fs.Position, SeekOrigin.Begin);
				sw.WriteLine(dt.ToString() + " " + TranString(buffer));
				sw.Flush();
				sw.Close();
		}

		private StringBuilder  TranString(byte[] buffer)
		{
			Recivestr.Clear();
			//依次的拼接出16进制字符串  
			foreach (byte b in buffer)
			{
				Recivestr.Append(b.ToString("X2") + " ");
			}
			return Recivestr;
		}

		private void ckbAutoSend_CheckedChanged(object sender, EventArgs e)
		{
			if(ckbAutoSend.Checked)
			{
				txtTimeCell.ReadOnly = false;
				btnSend.Text = "发送";
				AutoSendTimer.Stop();
				AutoSendTimer.Dispose();
				IsSended = false;
			}
			else
			{
				txtTimeCell.ReadOnly = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			txtRecive.Clear();
		}



	}
}
