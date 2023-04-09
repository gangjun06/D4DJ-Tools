using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class FesGachaBuffEffectMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public FesGachaBuffEffectType EffectType { get; set; }
		[Key(2)]
		public int[] Targets { get; set; }
		[Key(3)]
		public int[] EffectAmounts { get; set; }
	}
}

