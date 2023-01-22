using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventRaveClubRankingRewardMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __AggregationPrimaryKey__ { get; set; }
		[Key(2)]
		public int GroupId { get; set; }
		[Key(3)]
		public int LowestRanking { get; set; }
		[Key(4)]
		public int HighestRanking { get; set; }
		[Key(5)]
		public RewardCategory Category { get; set; }
		[Key(6)]
		public int RewardId { get; set; }
		[Key(7)]
		public int Amount { get; set; }
	}
}

