using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MapBirthdayFlowerMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __CharacterPrimaryKey__ { get; set; }
		[Key(2)]
		public MapBirthdayFlowerType FlowerType { get; set; }
		[Key(3)]
		public int RequiredCardId { get; set; }
		[Key(4)]
		public int AnniversaryId { get; set; }
		[Key(5)]
		public string OverwriteName { get; set; }
		[Key(6)]
		public string OverwriteDescription { get; set; }
		[Key(7)]
		public RewardCategory BonusCategory { get; set; }
		[Key(8)]
		public int BonusRewardId { get; set; }
		[Key(9)]
		public int BonusRewardAmount { get; set; }
	}
}

