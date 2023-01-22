using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventRaveMusicTrendGroupMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public int PickUpTrendCount { get; set; }
		[Key(3)]
		public int HintMusicCount { get; set; }
		[Key(4)]
		public int EffectValue { get; set; }
		[Key(5)]
		public int PenaltyLine { get; set; }
	}
}

