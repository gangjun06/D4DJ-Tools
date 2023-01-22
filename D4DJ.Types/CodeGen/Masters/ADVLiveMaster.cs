using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ADVLiveMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int MusicId { get; set; }
		[Key(2)]
		public ChartSectionType ChartSection { get; set; }
		[Key(3)]
		public int DeckId { get; set; }
		[Key(4)]
		public int ClubDeckId { get; set; }
		[Key(5)]
		public int ClubFormationId { get; set; }
		[Key(6)]
		public int __OptionPrimaryKey__ { get; set; }
		[Key(7)]
		public bool IsAuto { get; set; }
		[Key(8)]
		public bool IsMVOn { get; set; }
	}
}

