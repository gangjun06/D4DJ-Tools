using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventRaveMemberTrendGroupMaster
	{
		[Key(0)]
		public RaveMemberTrendGroupCategory Category { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public int Rate { get; set; }
	}
}

