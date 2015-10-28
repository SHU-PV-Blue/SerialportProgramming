using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVCurvometerTestTool
{
	class InstructionDict
	{
		private static Dictionary<string, string> dict = new Dictionary<string, string>{
        {"测组件1Y6通","02 0F 00 00 00 08 01 20 BF 58"},
        {"测组件1Y7通","02 0F 00 00 00 08 01 40 BF 70"},
        {"测组件2Y5通","02 0F 00 00 00 08 01 10 BF 4C"},
        {"测组件3Y4通","02 0F 00 00 00 08 01 08 BF 46"},
        {"测组件4Y3通","02 0F 00 00 00 08 01 04 BF 43"},
        {"测组件5Y2通","02 0F 00 00 00 08 01 02 3F 41"},
        {"测组件6Y1通","02 0F 00 00 00 08 01 01 7F 40"},

        {"倾角27/32","01 0F 00 00 00 20 04 02 02 00 00 64 F0"},
        {"倾角32/37","01 0F 00 00 00 20 04 01 01 00 00 94 B4"},
        {"倾角37/32","01 0F 00 00 00 20 04 04 04 00 00 84 79"},
        {"倾角32/27","01 0F 00 00 00 20 04 08 08 00 00 47 2A"},
        {"倾角27/22","01 0F 00 00 00 20 04 04 04 00 00 84 79"},
        {"倾角22/27","01 0F 00 00 00 20 04 01 01 00 00 94 B4"},

        {"方位-10/-5","01 0F 00 00 00 20 04 10 10 00 00 C1 8D"},
        {"方位-5/0","01 0F 00 00 00 20 04 20 20 00 00 CE 82"},
        {"方位0/5","01 0F 00 00 00 20 04 10 10 00 00 C1 8D"},
        {"方位5/0","01 0F 00 00 00 20 04 40 40 00 00 D0 9C"},
        {"方位0/-5","01 0F 00 00 00 20 04 80 80 00 00 EC A0"},
        {"方位-5/-10",""},
        
        {"8继全断","02 0F 00 00 00 08 01 00 BE 80"},
        {"32继全断","01 0F 00 00 00 20 04 00 00 00 00 C4 88"},

        {"读取气象仪的当前数据","03 03 00 00 F0 60"},
        {"读取组件温度","AA 00 01 07 CC 33 C3 3C"},
        {"测试并读取IV曲线","AA 00 01 05 CC 33 C3 3C"}
        };

		public static string GetInstruction(string name)
		{
			if (!dict.ContainsKey(name))
				return null;
			return dict[name];
		}
	}
}
