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
			string[] ports = SerialPort.GetPortNames();
            cmbPorts.Items.AddRange(ports);
			cmbPorts.SelectedIndex = 0;
			cmbBaudRate.SelectedIndex = 0;
			cmbDataBit.SelectedIndex = 0;
			cmbParity.SelectedIndex = 0;
			cmbStopBit.SelectedIndex = 0;
		}

		private void btnSetParam_Click(object sender, EventArgs e)
		{
			sp.PortName = cmbPorts.Text;
			sp.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
			sp.DataBits = Convert.ToByte(cmbDataBit.Text);
            sp.Parity = Parity.None;
            sp.StopBits = StopBits.One;
         
			//sp.ReadTimeout = 500;
		}

        private void showData(object sender, SerialDataReceivedEventArgs e)
        {

            string strRecivel = sp.ReadExisting();
            txtRecive.AppendText(strRecivel);
        }

		private void btnOpen_Click(object sender, EventArgs e)
		{
			try
            {
                sp.DataReceived += showData;
				sp.Open();
                txtRecive.AppendText("端口" + sp.PortName + "已打开。\n");
			}
			catch (Exception ex)
			{
				txtRecive.AppendText("异常: " + ex.Message + "\r\n");
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			sp.Close();
            txtRecive.AppendText("端口" + sp.PortName + "已关闭。\n");
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			sp.Close();
			this.Close();
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			sp.Write(txtSend.Text);
		}

        private void cmbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
	}
}
