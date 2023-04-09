using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventGroupMaster
	{
		[Key(0)]
		public int EventId { get; set; }
		[Key(1)]
		public int GroupId { get; set; }
		[Key(2)]
		public EventGroupDisplayType DisplayType { get; set; }
		[Key(3)]
		public string Argument { get; set; }
	}
}

