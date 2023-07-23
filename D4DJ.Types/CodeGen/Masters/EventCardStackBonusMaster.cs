using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventCardStackBonusMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public EventType EventType { get; set; }
		[Key(2)]
		public int __RarityPrimaryKey__ { get; set; }
		[Key(3)]
		public int StackCount { get; set; }
		[Key(4)]
		public int CharacterMatchBonusValue { get; set; }
		[Key(5)]
		public int AttributeMatchBonusValue { get; set; }
		[Key(6)]
		public int CardMatchBonusValue { get; set; }
	}
}

