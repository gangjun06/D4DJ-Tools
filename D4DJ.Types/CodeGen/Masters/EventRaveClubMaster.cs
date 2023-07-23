using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventRaveClubMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public int RankingRewardGroupId { get; set; }
		[Key(3)]
		public int PartyCount { get; set; }
		[Key(4)]
		public RAVEClubTierType TierType { get; set; }
		[Key(5)]
		public int NpcRate { get; set; }
		[Key(6)]
		public int RewardRate { get; set; }
		[Key(7)]
		public int[] HiddenMusicTrendGroups { get; set; }
	}
}

