using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.RegularExpressions;

namespace IVCurvometerTestTool
{
    public class Translate
    {
		public static List<Command> Translation()
		{
			
			List<Command> list = new List<Command>();
			string strReader = null;
			string open = null;
			int files = 0;
			byte[] array = null;
			StreamReader sr = new StreamReader("code.txt");
			while ((strReader = sr.ReadLine()) != null)
			{
				if (strReader.StartsWith("open:"))
					
				{
					open = "open";
					files = Convert.ToInt32(strReader.Substring(5, strReader.Length-5));
				}
				else if (strReader.StartsWith("close:"))
				{
					open = "close";
				}
				else if (strReader.StartsWith("send:"))
				{
					open = "send";
					array = Transfer.SToBa(strReader.Substring(5, strReader.Length-5));
				}
				else if (strReader.StartsWith("sleep:"))
				{
					open = "sleep";
					files = Convert.ToInt32(strReader.Substring(6, strReader.Length-6));
				}
				else
				{
					MessageBox.Show(strReader+"\r\n数据有错误");
					return null;
				}
				list.Add(new Command(open, files, array));
			}
			sr.Close();
			return list;
		}
    }
}
