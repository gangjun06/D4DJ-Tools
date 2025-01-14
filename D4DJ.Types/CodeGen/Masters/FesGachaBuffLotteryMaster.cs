using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class FesGachaBuffLotteryMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int Rate { get; set; }
		[Key(2)]
		public int[] __EffectsPrimaryKey__ { get; set; }
		[Key(3)]
		public string Name { get; set; }
		[Key(4)]
		public bool HasPrizeEffect { get; set; }
	}
}

