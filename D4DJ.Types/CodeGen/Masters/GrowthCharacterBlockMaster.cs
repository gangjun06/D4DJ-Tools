using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthCharacterBlockMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int Sequence { get; set; }
		[Key(2)]
		public int __CharacterIdPrimaryKey__ { get; set; }
		[Key(3)]
		public GrowthBlockEffectType CharacterEffectType { get; set; }
		[Key(4)]
		public int[] EffectValues { get; set; }
		[Key(5)]
		public EffectTypeOperator EffectTypeOperator { get; set; }
		[Key(6)]
		public int ClothId { get; set; }
	}
}

