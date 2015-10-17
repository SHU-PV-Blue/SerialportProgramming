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
		//public static string strPortName = "";
		bool IsSended = false;
		Timer AutoSendTimer = new Timer();
		


		private void Form1_Load(object sender, EventArgs e)
		{
			//InitParam();
			AutoSendTimer.Tick  += new EventHandler(AutoSend);
		}

		private void btnSetParam_Click(object sender, EventArgs e)
		{
			InitParam();
		}
		private void InitParam()
		{
			strPortName = cmbPorts.Text;
			strBaudRate = cmbBaudRate.Text;
			strDataBits = cmbDataBit.Text;
			strStopBits = cmbStopBit.Text;

			sp.PortName = strPortName;
			sp.BaudRate = Convert.ToInt32(strBaudRate);
			sp.DataBits = Convert.ToByte(strDataBits);
			sp.StopBits = StopBits.One;
		}
		private void btnOpen_Click(object sender, EventArgs e)
		{
			try
			{
				sp.Open();
			}
			catch (Exception ex)
			{
				txtRecive.AppendText("异常: " + ex.Message + "\r\n");
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			sp.Close();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			sp.Close();
			this.Close();
		}

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
					sp.Write(txtSend.Text);
					ReciveData();
				}
		}
		private void AutoSend(object sender, EventArgs e) 
		{
			sp.Write(txtSend.Text);
			ReciveData();
		}

		private void btnInit_Click(object sender, EventArgs e)
		{
			try
			{
				string[] ports = SerialPort.GetPortNames();
				foreach (string p in ports) { cmbPorts.Items.Add(p); }
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

		private void btnRecive_Click(object sender, EventArgs e)
		{
			if (sp.IsOpen)
			{
				ReciveData();
			}
			
		}

		private void ReciveData()
		{
			try
			{
				DateTime dt = DateTime.Now;
				string strRecivel = sp.ReadExisting();
				txtRecive.AppendText(dt.ToString() + strRecivel);
				txtRecive.AppendText("\n");
				FileStream fs = new FileStream(@"E:\光伏\串口\Data\"  + "1.txt", FileMode.OpenOrCreate, FileAccess.Write);
				fs.Position = fs.Length;                  //将待写入内容追加到文件末尾  
				StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);//(fs, System.Text.Encoding.GetEncoding("GB2312"));
				sw.Flush();
				sw.BaseStream.Seek(fs.Position, SeekOrigin.Begin);
				sw.WriteLine(dt.ToString() + strRecivel);
				sw.Flush();
				sw.Close();
			}
			catch(Exception ex)
			{
				txtRecive.AppendText("异常: " + ex.Message + "\r\n");
			}
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

	}
}
