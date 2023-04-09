using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventRaidResourceOverwriteMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int EventId { get; set; }
		[Key(2)]
		public RaidResourceType ResourceType { get; set; }
		[Key(3)]
		public string OverwriteFileName { get; set; }
	}
}

