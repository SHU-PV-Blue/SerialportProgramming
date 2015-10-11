using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
	public class Menu
	{
		string _name;
		List<Command> _commands;
		string _help;
		List<string> _reservedCommands;

		public Menu(string name, string help = "")
		{
			_name = name;
			_help = help;
			_commands = new List<Command>();
			_reservedCommands = new List<string>();
			_reservedCommands.Add("help");
			_reservedCommands.Add("exit");
		}

		public void AddCommand(string name, Function function, string help = "")
		{
			foreach (var com in _commands)
			{
				if (com._name == name)
					throw new Exception("不同添加同名的命令:" + name);
			}
			foreach (var com in _reservedCommands)
			{
				if (com == name)
					throw new Exception("不同添加保留的命令:" + name);
			}
			Command c = new Command(name, function, help);
			_commands.Add(c);
		}

		public void Start()
		{
			Welcome();
			string command;
			while (true)
			{
				Console.Write(">");
				command = Console.ReadLine();
				if (command == "")
					continue;
				char[] chars = new char[1];
				chars[0] = ' ';
				string[] commandDetail = command.Split(chars, 100, StringSplitOptions.RemoveEmptyEntries);
				if (commandDetail[0] == "exit")
					break;
				if (commandDetail[0] == "help")
				{
					Help();
					continue;
				}
				List<string> args = new List<string>();
				for (int i = 0 + 1; i < commandDetail.Length; ++i)
				{
					args.Add(commandDetail[i]);
				}
				Process(commandDetail[0], args);
			}
			Bye();
		}

		void Process(string name, List<string> args)
		{
			foreach (var com in _commands)
			{
				if (com._name == name)
				{
					com.Run(args);
					return;
				}
			}
			Console.WriteLine("找不到命令:" + name);
		}


		void Welcome()
		{
			Console.WriteLine("欢迎使用" + _name + "!");
		}

		void Help()
		{
			Console.WriteLine("有以下下命令可用:");
			foreach (var com in _commands)
			{
				Console.WriteLine(com._name);
			}
		}

		void Bye()
		{
			Console.WriteLine("再见!");
		}

	}

	public delegate void Function(List<string> listStr);
	class Command
	{
		public string _name;
		Function _function;
		string _help;
		public Command(string name, Function function, string help = "")
		{
			_name = name;
			_function = function;
			_help = help;
		}
		public void Run(List<string> listStr)
		{
			_function(listStr);
		}
	}
}
