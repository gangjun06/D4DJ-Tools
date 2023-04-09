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
		[Key(8)]
		public string EnemyName { get; set; }
		[Key(9)]
		public int __AggregationPrimaryKey__ { get; set; }
		[Key(10)]
		public float ImagePositionY { get; set; }
		[Key(11)]
		public GrowthEnemyType EnemyType { get; set; }
		[Key(12)]
		public float MapSDScale { get; set; }
	}
}

