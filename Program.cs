using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace git_flow_test
{
	class Program
	{
		static void Main(string[] args)
		{
			
			
			Console.Write("Enter your name: ");
			String name = Console.ReadLine();
			Console.Write("Good day, ");
			Console.Write(name);
			Console.WriteLine("!");
			Console.WriteLine("v.1.1.1");
			Thread.Sleep(2000);
		}
	}
}
