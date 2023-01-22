using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class EventRaveClubTierMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int ClubId { get; set; }
		[Key(2)]
		public RAVEClubTierType Type { get; set; }
		[Key(3)]
		public int AudienceCount { get; set; }
		[Key(4)]
		public int TopUserBorder { get; set; }
		[Key(5)]
		public int MatchingTypeId { get; set; }
	}
}

