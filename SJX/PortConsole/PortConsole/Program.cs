using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;//用于调用串口类函数
using Microsoft.VisualBasic.Devices;//需要引用Microsoft.VisualBasic

using ConsoleMenu;

namespace PortConsole
{
	class Program
	{
		static SerialPort serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);//定义一个串口类的串口变量
		static void Main(string[] args)
		{
			Menu menu = new Menu("串口通信示例");
			menu.AddCommand("status", new Function(ShowStatus));
			menu.AddCommand("switch", new Function(SwitchPort));
			menu.AddCommand("set", new Function(SetPort));
			menu.AddCommand("send", new Function(SendData));
			menu.Start();
		}

		static void ShowStatus(List<string> args)
		{
			Computer com = new Computer();
			bool isFirst = true;
			bool isZero = true;
			foreach (string str in com.Ports.SerialPortNames)
			{
				if (isFirst)
				{
					Console.WriteLine("系统可用的串口有:");
					isFirst = false;
					isZero = false;
				}
				Console.WriteLine(str);
			}
			if (isZero)
			{
				Console.WriteLine("系统没有可用的串口");
			}
			if(serialPort.IsOpen)
				Console.WriteLine("当前串口处于打开状态:");
			else
				Console.WriteLine("当前串口处于关闭状态:");
			Console.WriteLine("串口名称:   " + serialPort.PortName);
			Console.WriteLine("波特率:     " + serialPort.BaudRate);
			Console.WriteLine("奇偶校验位: " + serialPort.Parity);
			Console.WriteLine("数据位:     " + serialPort.DataBits);
			Console.WriteLine("停止位:     " + serialPort.StopBits);
		}

		static void SwitchPort(List<string> args)
		{
			if (serialPort.IsOpen)
			{
				try
				{
					serialPort.Close();
				}
				catch(Exception ex)
				{
					Console.WriteLine("串口关闭失败:" + ex.Message);
					return;
				}
				Console.WriteLine("串口被关闭");
			}
			else
			{
				try
				{
					serialPort.Open();
				}
				catch (Exception ex)
				{
					Console.WriteLine("串口开启失败:" + ex.Message);
					return;
				}
				Console.WriteLine("串口被开启");
			}
			
		}

		static void SendData(List<string> args)
		{
			while(true)
			{
				Console.Write("输入要发送的字符串(q退出):");
				string data = Console.ReadLine();
				if (data == "q")
					return;
				try
				{
					serialPort.Write(data);
					Console.WriteLine("成功发送数据:" + data);
				}
				catch (Exception ex)
				{
					Console.WriteLine("成功失败:" + ex.Message);
				}
			}
			
		}

		static void SetPort(List<string> args)
		{
			if (serialPort.IsOpen)
			{
				Console.WriteLine("请先关闭端口");
				return;
			}
			Console.WriteLine("串口名称当前为:" + serialPort.PortName);
			Console.Write("修改为:");
			serialPort.PortName = Console.ReadLine();

			Console.WriteLine("波特率当前为:" + serialPort.BaudRate);
			Console.Write("修改为:");
			serialPort.BaudRate = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("奇偶校验位当前为:" + serialPort.Parity + ",可用值有 None Odd Even Mark Space");
			Console.Write("修改为:");
			{
				string temp = Console.ReadLine();
				switch(temp)
				{
					case "None":
						serialPort.Parity = Parity.None;
						break;
					case "Odd":
						serialPort.Parity = Parity.Odd;
						break;
					case "Even":
						serialPort.Parity = Parity.Even;
						break;
					case "Mark":
						serialPort.Parity = Parity.Mark;
						break;
					case "Space":
						serialPort.Parity = Parity.Space;
						break;
					default:
						Console.WriteLine("输入有误!");
						return;
				}
			}

			Console.WriteLine("数据位当前为:" + serialPort.DataBits + ",可用值有 5 6 7 8");
			Console.Write("修改为:");
			{
				string temp = Console.ReadLine();
				if (Convert.ToInt32(temp) > 8 || Convert.ToInt32(temp) < 5)
				{
					Console.WriteLine("输入有误!");
					return;
				}
				serialPort.DataBits = Convert.ToInt32(temp);
			}
			
			Console.WriteLine("停止位当前为:" + serialPort.StopBits + ",可用值有 0 1 2 1.5");
			Console.Write("修改为:");
			{
				string temp = Console.ReadLine();
				switch (temp)
				{
					case "0":
						serialPort.StopBits = StopBits.None;
						break;
					case "1":
						serialPort.StopBits = StopBits.One;
						break;
					case "2":
						serialPort.StopBits = StopBits.Two;
						break;
					case "1.5":
						serialPort.StopBits = StopBits.OnePointFive;
						break;
					default:
						Console.WriteLine("输入有误!");
						return;
				}
			}
		}
	}
}
