using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthActionCardLevelValueMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int Rate { get; set; }
	}
}

