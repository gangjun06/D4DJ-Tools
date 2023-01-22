using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthMapLayoutConfigMaster
	{
		[Key(0)]
		public int EventId { get; set; }
		[Key(1)]
		public int[] BlockYPositions { get; set; }
		[Key(2)]
		public int[] BlockYPositionOrders { get; set; }
		[Key(3)]
		public int[] BackgroundChangeBlockIndexes { get; set; }
		[Key(4)]
		public string[] BackgroundPrefabNames { get; set; }
		[Key(5)]
		public string BGMPath { get; set; }
	}
}

