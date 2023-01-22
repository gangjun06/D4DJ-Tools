using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventRaveSeasonMaster
	{
		[Key(0)]
		public int SeasonId { get; set; }
		[Key(1)]
		public int __EventPrimaryKey__ { get; set; }
		[Key(2)]
		public bool IsFinalEvent { get; set; }
	}
}

