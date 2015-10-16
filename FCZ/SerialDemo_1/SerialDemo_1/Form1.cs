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


		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void btnSetParam_Click(object sender, EventArgs e)
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
				Timer AutoSendTimer = new Timer();
			}
			else
			{

			}
			
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
				txtRecive.AppendText("异常:" + ex.Message + Environment.NewLine);
			}
		}

		private void btnRecive_Click(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Now;
			string strRecivel = sp.ReadExisting();
			txtRecive.AppendText(dt.ToString() + strRecivel + Environment.NewLine);

			SaveData(dt, strRecivel);
		}

		private void SaveData(DateTime dt, string strRecive)
		{
			try
			{
				FileStream fs = new FileStream(@"E:\光伏\串口\Data\"  + "1.txt", FileMode.OpenOrCreate, FileAccess.Write);
				StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.GetEncoding("GB2312"));
				sw.Flush();
				sw.BaseStream.Seek(0, SeekOrigin.Begin);
				sw.WriteLine(strRecive);
				sw.Flush();
				sw.Close();
			}
			catch(Exception ex)
			{
				txtRecive.AppendText("异常: " + ex.Message + Environment.NewLine);
			}
		}

		private void ckbAutoSend_CheckedChanged(object sender, EventArgs e)
		{
			if(ckbAutoSend.Checked)
			{
				txtTimeCell.ReadOnly = false;
			}
			else
			{
				txtTimeCell.ReadOnly = true;
			}
		}

	}
}
