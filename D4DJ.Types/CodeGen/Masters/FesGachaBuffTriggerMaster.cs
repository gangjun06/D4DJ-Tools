using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class FesGachaBuffTriggerMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __TargetGachaPrimaryKey__ { get; set; }
		[Key(2)]
		public string Name { get; set; }
		[Key(3)]
		public int[] __LotteriesPrimaryKey__ { get; set; }
		[Key(4)]
		public int TriggerAmount { get; set; }
		[Key(5)]
		public bool IsSpecialTrigger { get; set; }
	}
}

