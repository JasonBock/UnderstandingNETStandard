using System;
using UnderstandingNETStandard.Producer;

namespace UnderstandingNETStandard.NETCore
{
	class Program
	{
		static void Main(string[] args)
		{
			var service = new NETCoreIdentifierService();
			var printer = new PrintIdentifiers(service);
			printer.Print(Console.Out);
		}
	}
}
