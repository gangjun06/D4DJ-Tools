using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventRaveNPCMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int ClubId { get; set; }
		[Key(2)]
		public string Name { get; set; }
		[Key(3)]
		public int AudienceCount { get; set; }
		[Key(4)]
		public int DeckId { get; set; }
		[Key(5)]
		public int MusicTableId { get; set; }
		[Key(6)]
		public int ScoreRate { get; set; }
	}
}

