using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventRaveMemberTrendMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public RaveMemberTrendGroupCategory Category { get; set; }
		[Key(2)]
		public int TrendValue { get; set; }
		[Key(3)]
		public int EffectValue { get; set; }
		[Key(4)]
		public int Rate { get; set; }
		[Key(5)]
		public string Description { get; set; }
	}
}

