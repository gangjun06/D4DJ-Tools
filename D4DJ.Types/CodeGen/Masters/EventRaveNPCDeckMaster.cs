using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventRaveNPCDeckMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int DeckId { get; set; }
		[Key(2)]
		public int Sequence { get; set; }
		[Key(3)]
		public int __CardPrimaryKey__ { get; set; }
		[Key(4)]
		public int Level { get; set; }
		[Key(5)]
		public int LimitBreakCount { get; set; }
		[Key(6)]
		public int StackCount { get; set; }
		[Key(7)]
		public int SkillLevel { get; set; }
	}
}

