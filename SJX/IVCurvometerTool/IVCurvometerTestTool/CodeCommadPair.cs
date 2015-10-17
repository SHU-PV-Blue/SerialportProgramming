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

			数据地址 = new Dictionary<byte[], string>();
			数据地址.Add(new byte[] { 0x00, 0x00 }, "电流系数A地址");
			数据地址.Add(new byte[] { 0x04, 0x00 }, "电流系数B地址");
			数据地址.Add(new byte[] { 0x08, 0x00 }, "电压系数A地址");
			数据地址.Add(new byte[] { 0x0C, 0x00 }, "电压系数B地址");
			数据地址.Add(new byte[] { 0x10, 0x00 }, "温度系数A地址");
			数据地址.Add(new byte[] { 0x14, 0x00 }, "温度系数B地址");
			数据地址.Add(new byte[] { 0x18, 0x00 }, "照明系数A地址");
			数据地址.Add(new byte[] { 0x1C, 0x00 }, "照明系数B地址");
			数据地址.Add(new byte[] { 0x20, 0x00 }, "电池系数A地址");
			数据地址.Add(new byte[] { 0x24, 0x00 }, "电池系数B地址");
			数据地址.Add(new byte[] { 0x28, 0x00 }, "分流器系数地址");
			数据地址.Add(new byte[] { 0x2C, 0x00 }, "照明仪系数地址");
			数据地址.Add(new byte[] { 0x30, 0x00 }, "单晶硅电压温度系数");
			数据地址.Add(new byte[] { 0x34, 0x00 }, "单晶硅电流温度系数");
			数据地址.Add(new byte[] { 0x38, 0x00 }, "多晶硅电压温度系数");
			数据地址.Add(new byte[] { 0x3C, 0x00 }, "多晶硅电流温度系数");
			数据地址.Add(new byte[] { 0x40, 0x00 }, "薄膜电压温度系数");
			数据地址.Add(new byte[] { 0x44, 0x00 }, "薄膜电流温度系数");
			数据地址.Add(new byte[] { 0x48, 0x00 }, "电池类型选择");
			数据地址.Add(new byte[] { 0x4C, 0x00 }, "单晶硅组件内阻");
			数据地址.Add(new byte[] { 0x50, 0x00 }, "照度仪选择地址");
			数据地址.Add(new byte[] { 0x54, 0x00 }, "照度仪系数地址");
			数据地址.Add(new byte[] { 0x58, 0x00 }, "多晶硅组件内阻");
			数据地址.Add(new byte[] { 0x5C, 0x00 }, "薄膜组件内阻");
			数据地址.Add(new byte[] { 0x60, 0x00 }, "单晶硅组件内阻温度系数");
			数据地址.Add(new byte[] { 0x64, 0x00 }, "多晶硅组件内阻温度系数");
			数据地址.Add(new byte[] { 0x68, 0x00 }, "薄膜组件内阻温度系数");
			数据地址.Add(new byte[] { 0x6C, 0x00 }, "阵列测量序号");
			数据地址.Add(new byte[] { 0x70, 0x00 }, "被测阵列编号");
			数据地址.Add(new byte[] { 0x78, 0x00 }, "系统设置密码");
			数据地址.Add(new byte[] { 0x80, 0x00 }, "系统ID");
			数据地址.Add(new byte[] { 0xD0, 0x7F }, "系统硬件型号");
			数据地址.Add(new byte[] { 0xD8, 0x7F }, "系统软件版本");
			数据地址.Add(new byte[] { 0xE0, 0x7F }, "系统硬件编号");
			数据地址.Add(new byte[] { 0xF0, 0x7F }, "系统最大测量电流");
			数据地址.Add(new byte[] { 0xF4, 0x7F }, "系统最大测量电压");
			数据地址.Add(new byte[] { 0x00, 0x80 }, "所有数据");
			
		}
		static public Dictionary<byte, string> 系统操作;
		static public Dictionary<byte, string> 页面类型;
		static public Dictionary<byte, string> 页面编号;
		static public Dictionary<byte, string> 页面操作;
		static public Dictionary<byte[], string> 数据地址;
	}
}
