using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class CharacterMissionMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int CharacterId { get; set; }
		[Key(2)]
		public string Title { get; set; }
		[Key(3)]
		public string Description { get; set; }
		[Key(4)]
		public int ConditionId { get; set; }
		[Key(5)]
		public int[] ConditionValues { get; set; }
		[Key(6)]
		public int RewardPoint { get; set; }
		[Key(7)]
		public int __CommandMasterPrimaryKey__ { get; set; }
		[Key(8)]
		public string CommandArgument { get; set; }
		[Key(9)]
		public bool IsHidden { get; set; }
		[Key(10)]
		public AchievementNotifyType NotifyType { get; set; }
	}
}

