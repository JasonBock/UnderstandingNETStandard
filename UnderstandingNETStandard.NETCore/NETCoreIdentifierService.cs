using System.Globalization;
using UnderstandingNETStandard.Core;

namespace UnderstandingNETStandard.NETCore
{
	internal sealed class NETCoreIdentifierService
		: IIdentifierService
	{
		public string Identify() => $".NET Core - {new RegionInfo("en-US").Name}";
	}
}