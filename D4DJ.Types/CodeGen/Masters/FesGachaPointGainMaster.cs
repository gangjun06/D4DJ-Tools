using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class FesGachaPointGainMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __TargetDrawsPrimaryKey__ { get; set; }
		[Key(2)]
		public int GainAmount { get; set; }
	}
}

