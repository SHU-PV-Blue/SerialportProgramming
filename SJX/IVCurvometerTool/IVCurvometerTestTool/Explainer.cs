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
						switch (inputBytes[3])
						{
							case 0x05:
								result += "测量命令";
								break;
							case 0x06:
								result += "辐照度测量";
								break;
							case 0x07:
								result += "温度测量";
								break;
							case 0x08:
								result += "电源电压测量";
								break;
							case 0x09:
								result += "IV特性数据";
								break;
							case 0x0A:
								result += "IV-STC特性数据";
								break;
							case 0x0B:
								result += "存储命令";
								break;
							case 0x3D:
								result += "电压系数测量";
								break;
							case 0x3E:
								result += "电流系数测量";
								break;
							case 0x3F:
								result += "辐照度系数测量";
								break;
							case 0x40:
								result += "温度系数测量";
								break;
							case 0x42:
								result += "电源电压系数测量";
								break;
							default:
								result += "无法解析的操作";
								break;
						}
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
