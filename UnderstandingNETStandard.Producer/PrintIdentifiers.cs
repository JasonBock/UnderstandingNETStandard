using System;
using System.IO;
using UnderstandingNETStandard.Core;

namespace UnderstandingNETStandard.Producer
{
	public sealed class PrintIdentifiers
	{
		private readonly IIdentifierService service;

		public PrintIdentifiers(IIdentifierService service) =>
			this.service = service ?? throw new ArgumentNullException(nameof(service));

		public void Print(TextWriter writer) =>
			writer?.WriteLine($"Indentifier: {this.service.Identify()}");
	}
}