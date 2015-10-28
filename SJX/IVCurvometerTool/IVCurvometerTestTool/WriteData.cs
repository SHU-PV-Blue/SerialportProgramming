using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IVCurvometerTestTool
{
	static class WriteData
	{
		static public bool SendLog(DateTime time, string data)
		{
			if(Write("SendData", time, data))
				return true;
			return false;
		}

		static public bool ReciveLog(DateTime time, string data)
		{
			if(Write("ReciveData", time, data))
				return true;
			return false;
		}

		static private bool Write(string type, DateTime time, string data)
		{
			try
			{
				FileStream fs = new FileStream(type + "\\" + time.ToLongDateString() + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
				fs.Position = fs.Length;                  //将待写入内容追加到文件末尾  
				StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);//(fs, System.Text.Encoding.GetEncoding("GB2312"));
				sw.Flush();
				sw.BaseStream.Seek(fs.Position, SeekOrigin.Begin);
				sw.WriteLine(time.ToString() + "###" + data);
				sw.Flush();
				sw.Close();
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
