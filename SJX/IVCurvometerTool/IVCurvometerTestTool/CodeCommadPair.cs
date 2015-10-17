using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVCurvometerTestTool
{
	static class CodeCommadPair
	{
		static CodeCommadPair()
		{
			系统操作 = new Dictionary<byte, string>();
			系统操作.Add(0x05, "测量命令");
			系统操作.Add(0x06, "辐照度测量");
			系统操作.Add(0x07, "温度测量");
			系统操作.Add(0x08, "电源电压测量");
			系统操作.Add(0x09, "IV特性数据");
			系统操作.Add(0x0A, "IV-STC特性数据");
			系统操作.Add(0x0B, "存储命令");
			系统操作.Add(0x3D, "电压系数测量");
			系统操作.Add(0x3E, "电流系数测量");
			系统操作.Add(0x3F, "辐照度系数测量");
			系统操作.Add(0x40,"温度系数测量");
			系统操作.Add(0x42,"电源电压系数测量");

			页面类型 = new Dictionary<byte, string>();
			页面类型.Add(0x01, "主页面");
			页面类型.Add(0x02, "信息对话框");
			页面类型.Add(0x03, "信息提示框");
			页面类型.Add(0x04, "故障提示框");

			页面编号 = new Dictionary<byte, string>();
			页面编号.Add(0x01, "测量主页面");
			页面编号.Add(0x02, "参数设置主页面");
			页面编号.Add(0x21, "系统检测中...");
			页面编号.Add(0x24, "测量中...");
			页面编号.Add(0x22, "无输入电压");
			页面编号.Add(0x23, "输入电压过高");
			页面编号.Add(0x25, "存储完成");
			页面编号.Add(0x26, "确认删除");
			页面编号.Add(0x27, "存储空间不足");
			页面编号.Add(0x28, "系统故障");
			页面编号.Add(0x29, "系统严重故障");
			页面编号.Add(0x2A, "系统故障01");
			页面编号.Add(0x2B, "系统故障02");
			页面编号.Add(0x2C, "系统温度过高");

			页面操作 = new Dictionary<byte, string>();
			页面操作.Add(0x00, "完成");
			页面操作.Add(0x01, "确定");
			页面操作.Add(0x02, "取消");

		}
		static public Dictionary<byte, string> 系统操作;
		static public Dictionary<byte, string> 页面类型;
		static public Dictionary<byte, string> 页面编号;
		static public Dictionary<byte, string> 页面操作;
	}
}
