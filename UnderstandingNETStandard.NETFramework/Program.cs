using System;
using UnderstandingNETStandard.Producer;

namespace UnderstandingNETStandard.NETFramework
{
	class Program
	{
		static void Main(string[] args)
		{
			var service = new NETFrameworkIdentifierService();
			var printer = new PrintIdentifiers(service);
			printer.Print(Console.Out);
		}
	}
}
