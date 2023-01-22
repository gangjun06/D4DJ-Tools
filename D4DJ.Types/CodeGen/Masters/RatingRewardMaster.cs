using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class RatingRewardMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __RatingPrimaryKey__ { get; set; }
		[Key(2)]
		public int __RankPrimaryKey__ { get; set; }
		[Key(3)]
		public MileageRank MileageRank { get; set; }
		[Key(4)]
		public int RequireRating { get; set; }
		[Key(5)]
		public int __RewardPrimaryKey__ { get; set; }
	}
}

