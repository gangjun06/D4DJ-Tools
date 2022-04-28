using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class SlotSpecficBonusMaster
	{
		[Key(0)]
		public int __EventPrimaryKey__ { get; set; }
		[Key(1)]
		public int[] BonusCardIds { get; set; }
	}
}

