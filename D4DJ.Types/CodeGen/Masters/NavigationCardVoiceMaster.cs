using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class NavigationCardVoiceMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __CardPrimaryKey__ { get; set; }
		[Key(2)]
		public NavigationCardVoiceCategory Categories { get; set; }
		[Key(3)]
		public int Value1 { get; set; }
		[Key(4)]
		public int Value2 { get; set; }
		[Key(5)]
		public DateTime StartDate { get; set; }
		[Key(6)]
		public DateTime EndDate { get; set; }
	}
}

