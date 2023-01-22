using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventRaveRewardMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __AggregationPrimaryKey__ { get; set; }
		[Key(2)]
		public int ClubId { get; set; }
		[Key(3)]
		public int RequiredPoint { get; set; }
		[Key(4)]
		public RewardCategory Category { get; set; }
		[Key(5)]
		public int RewardId { get; set; }
		[Key(6)]
		public int Amount { get; set; }
	}
}

