using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthBattleEnemyMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int ConditionValue { get; set; }
		[Key(2)]
		public int[] EnemyCharacterIds { get; set; }
		[Key(3)]
		public int Sequence { get; set; }
		[Key(4)]
		public int[] DebuffThreshold { get; set; }
		[Key(5)]
		public int[] DebuffValue { get; set; }
		[Key(6)]
		public int[] BuffThreshold { get; set; }
		[Key(7)]
		public int[] BuffValue { get; set; }
	}
}

