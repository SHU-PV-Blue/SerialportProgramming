using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialDemo_1
{
	static class InfoDictionary
	{
		public static Dictionary<byte, int> dicYear;
		public static Dictionary<byte, int> dicMonth;
		public static Dictionary<byte, int> dicDay;
		public static Dictionary<byte, int> dicHour;
		public static Dictionary<byte, int> dicMinute;
		public static Dictionary<byte, string> dicLang;

		static InfoDictionary()
		{
			int i;
			byte j;

			dicYear =	new Dictionary<byte,int>();
			dicMonth  =	new Dictionary<byte,int>();
			dicDay =	new Dictionary<byte,int>();
			dicHour =	new Dictionary<byte,int>();
			dicMinute =	new Dictionary<byte,int>();
			dicLang =	new Dictionary<byte, string>();

			for(i=2000, j = 0x00; i<2016; i++,j++)
			{
				dicYear.Add(j, i);
			}
			for (i = 1, j = 0x00; i <= 12; i++, j++)
			{
				dicMonth.Add(j, i);
			}
			for (i = 1, j = 0x00; i < 31; i++, j++)
			{
				dicDay.Add(j, i);
			}
			for (i = 0, j = 0x00; i <= 23; i++, j++)
			{
				dicHour.Add(j, i);
			}
			for (i = 0, j = 0x00; i <= 59; i++, j++)
			{
				dicMinute.Add(j, i);
			}
			dicLang.Add(0, "中文");
			dicLang.Add(1, "英文");
		}
	}
}
