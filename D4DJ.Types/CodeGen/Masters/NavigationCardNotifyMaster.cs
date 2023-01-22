using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class NavigationCardNotifyMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __CardPrimaryKey__ { get; set; }
		[Key(2)]
		public PushNotificationType Categories { get; set; }
		[Key(3)]
		public string Text { get; set; }
		[Key(4)]
		public DateTime StartDate { get; set; }
		[Key(5)]
		public DateTime EndDate { get; set; }
	}
}

