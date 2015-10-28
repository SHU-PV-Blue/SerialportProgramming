using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVCurvometerTestTool
{
	public class Command
	{
		public Command(string open, int files, byte[] array)
		{
			this.Open = open;
			this.Files = files;
			this.Array = array;
		}
		public string Open { set; get; }
		public int Files { set; get; }
		public byte[] Array { set; get; }

	}
}
