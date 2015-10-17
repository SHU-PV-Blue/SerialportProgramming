using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace SerialPortTest01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SerialPort sePort;
        private string[] baudRate = {"300","600","1200","2400","4800","9600","19200","38400","43000","56000","57600","115200" };
        private string[] dataBit = { "5", "6", "7", "8" };
        private string[] parityBit = { "None", "Odd", "Even" };
        private string[] stopBit = { "1", "2" };

        private long received_count = 0;
        private StringBuilder builder = new StringBuilder();
        /// <summary>
        /// Form1加载时一些初始化工作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            
            tsbFlush_Click(sender,e);
            cbBaudRate.Items.AddRange(baudRate);
            cbBaudRate.SelectedIndex = cbBaudRate.Items.IndexOf("9600");
            cbDataBit.Items.AddRange(dataBit);
            cbDataBit.SelectedIndex = cbDataBit.Items.IndexOf("8");
            cbParityBit.Items.AddRange(parityBit);
            cbParityBit.SelectedIndex = cbParityBit.Items.IndexOf("None");
            cbStopBit.Items.AddRange(stopBit);
            cbStopBit.SelectedIndex = cbStopBit.Items.IndexOf("1");
            panelFlag.BackColor = Color.Red;
        }
        /// <summary>
        /// 串口接收数据事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void sePort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = sePort.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致  
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据  
            received_count += n;//增加接收计数  
            sePort.Read(buf, 0, n);//读取缓冲数据  
            builder.Clear();//清除字符串构造器的内容  
            //因为要访问ui资源，所以需要使用invoke方式同步ui。
            this.Invoke((EventHandler)(delegate
            {
                //判断是否是显示为16禁止  
                if (rbReceiveHex.Checked)
                {
                    //依次的拼接出16进制字符串  
                    foreach (byte b in buf)
                    {
                        builder.Append(b.ToString("X2") + " ");
                    }
                }
                else
                {
                    //直接按ASCII规则转换成字符串  
                    builder.Append(Encoding.ASCII.GetString(buf));
                }
                this.txtGet.AppendText(DateTime.Now.ToShortTimeString() + ":    ");
                //追加的形式添加到文本框末端，并滚动到最后。  
                this.txtGet.AppendText(builder.ToString());
                this.txtGet.AppendText(Environment.NewLine);
                //修改接收计数  
                lblGetCount.Text = received_count.ToString();
            }));
        }

        /// <summary>
        /// 窗口关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sePort != null)
            {
                try
                {
                    sePort.Close();    //关闭串口
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// 工具栏刷新事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbFlush_Click(object sender, EventArgs e)
        {
            cbPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            cbPort.Items.AddRange(ports);
            cbPort.SelectedIndex = cbPort.Items.Count > 0 ? 0 : -1;
            if (cbPort.Items.Count == 0)
            {
                lblComStatus.ForeColor = Color.Red;
                lblComStatus.Text = "没有检测到COM";
            }
            else
            {
                    lblComStatus.ForeColor = Color.Black;
                    lblComStatus.Text = "检测到COM";
            }
        }
        /// <summary>
        /// 串口打开函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenPort(object sender, EventArgs e)
        {
            try
            {
                if (sePort != null)
                    sePort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            if (cbPort.Items.Count > 0)
            {
                string sPort = cbPort.SelectedItem.ToString();         //获取串口名
                int sBaudRate = Convert.ToInt32(cbBaudRate.SelectedItem.ToString());  //获取波特率 
                int sDataBit = Convert.ToInt32(cbDataBit.SelectedItem.ToString());   //获取数据位
                string parityStr = cbParityBit.SelectedItem.ToString();             //获取校验位
                Parity sParity;
                if (parityStr.Equals("None"))
                {
                    sParity = Parity.None;
                }
                else if (parityStr.Equals("Odd"))
                {
                    sParity = Parity.Odd;
                }
                else
                {
                    sParity = Parity.Even;
                }
                string stopStr = cbPort.SelectedItem.ToString();            //获取停止位
                StopBits sStop;
                if (stopStr.Equals("1"))
                {
                    sStop = StopBits.One;
                }
                else
                {
                    sStop = StopBits.Two;
                }
             
                try
                {
                    ///////*************
                    sePort = new SerialPort(sPort, sBaudRate, sParity, sDataBit, sStop);

                    sePort.NewLine = Environment.NewLine;
                    //sePort.RtsEnable = true;
                    sePort.DataReceived += sePort_DataReceived;
                    sePort.Open();
                    lblComStatus.ForeColor = Color.Black;
                    lblComStatus.Text = sPort + " 已连接";
                    panelFlag.BackColor = Color.Green;
                }
                catch (Exception ex)
                {
                    lblComStatus.ForeColor = Color.Red;
                    MessageBox.Show(ex.Message);
                    lblComStatus.Text = sPort + " 已被占用";
                }
            }
        }
        /// <summary>
        /// 关闭串口函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClosePort(object sender, EventArgs e)
        {
            if (sePort != null)
            {
                try
                {
                    string name = sePort.PortName;
                    sePort.Close();
                    lblComStatus.ForeColor = Color.Black;
                    lblComStatus.Text = name + " 已释放";
                    panelFlag.BackColor = Color.Red;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// 工具栏开启串口事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRun_Click(object sender, EventArgs e)
        {
            OpenPort(sender,e);
        }

        /// <summary>
        /// 工具栏关闭串口事件 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbStop_Click(object sender, EventArgs e)
        {
            ClosePort(sender, e);
        }
        /// <summary>
        /// 发送消息函数
        /// </summary>
        private void SendMessage()
        {
            if (sePort != null)
            {
                string mess = txtSend.Text.Trim();
                if (!string.IsNullOrEmpty(mess))
                {
                    if (rbSendHex.Checked)      //判断是否十六进制发送
                    {
                        try
                        {
                            string pattern = @"\s+";
                            string[] messages = Regex.Split(mess, pattern);
                            byte[] buf = Array.ConvertAll(messages, new Converter<string, byte>(StringToHex));

                            sePort.Write(buf, 0, buf.Length);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("发送数据格式错误,请检查格式!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        byte[] buf = Encoding.ASCII.GetBytes(mess);
                        sePort.Write(buf,0,buf.Length);
                    }
                }
            }
        }
        public static byte StringToHex(string str)
        {
            try
            {
                return Convert.ToByte(str, 16);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 发送消息按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
        /// <summary>
        /// 计时器事件 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerAuto_Tick(object sender, EventArgs e)
        {
            if (chbAutoSend.Checked)
            {
                SendMessage();
            }
            timerAuto.Interval = (int)numericUpDown1.Value;
        }
        /// <summary>
        /// 清除数据按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGet.Clear();
            received_count = 0;
            lblGetCount.Text = "0";
        }
        /// <summary>
        /// 打开串口按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenPort(sender, e);
        }
        /// <summary>
        /// 关闭按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            ClosePort(sender, e);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 串口助手ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © 2015 PVBlue. All Rights Reserved","关于");
        }
        Process pcalc = null;
        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo Info = new ProcessStartInfo();
            Info.FileName = "calc.exe ";//"calc.exe"为计算器，"notepad.exe"为记事本
            pcalc = Process.Start(Info);
        }
    }
}
