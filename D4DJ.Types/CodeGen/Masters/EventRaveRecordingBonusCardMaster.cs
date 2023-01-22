using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventRaveRecordingBonusCardMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int BonusId { get; set; }
		[Key(2)]
		public int __CardPrimaryKey__ { get; set; }
	}
}

