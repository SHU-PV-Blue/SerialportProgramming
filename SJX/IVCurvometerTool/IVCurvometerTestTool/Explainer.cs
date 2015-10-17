using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVCurvometerTestTool
{
	static class Explainer
	{
		static public string Explain(byte[] inputBytes)
		{
			if (inputBytes.Length < 5
				|| inputBytes[0] != 0xAA
				|| inputBytes[inputBytes.Length - 4] != 0xCC
				|| inputBytes[inputBytes.Length - 3] != 0x33
				|| inputBytes[inputBytes.Length - 2] != 0xC3
				|| inputBytes[inputBytes.Length - 1] != 0x3C
				)
			{
				return "解析失败:格式错误";
			}
			string result = Convert.ToString(inputBytes[1], 16);
			if (result.Length < 2)
				result = "0" + result;
			result = result.ToUpper();
			result = "测试仪" + result + ":";
			switch (inputBytes[2])
			{

				case 0x01:
					{
						result += "系统命令确认:";
						string str;
						if(CodeCommadPair.系统操作.TryGetValue(inputBytes[3],out str))
							result += str;
						else
							result += "无法解析的操作";
						break;
					}


				case 0x14:
					{
						result += "页面类型:";
						string str;
						if (CodeCommadPair.页面类型.TryGetValue(inputBytes[4], out str))
							result += str = ":";
						else
							result += "无法解析的页面类型";
						if (CodeCommadPair.页面编号.TryGetValue(inputBytes[3], out str))
							result += str = ":";
						else
							result += "页面编号";
						break;
					}
				

				default:
					{
						result += "无法解析的命令";
					}
					break;
			}

			return result;
		}
	}
}
