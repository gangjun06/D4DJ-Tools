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
	}
}

