using Microsoft.Win32;
using System.Globalization;
using UnderstandingNETStandard.Core;

namespace UnderstandingNETStandard.NETFramework
{
	public sealed class NETFrameworkIdentifierService
		: IIdentifierService
	{
		public string Identify() => $".NET Framework - {new RegionInfo("en-US").Name} - {string.Join(", ", Registry.CurrentUser.GetSubKeyNames())}";
	}
}
