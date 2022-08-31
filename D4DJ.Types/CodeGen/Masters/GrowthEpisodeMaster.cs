using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class GrowthEpisodeMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __EventPrimaryKey__ { get; set; }
		[Key(2)]
		public GrowthBlockCategory MapBlockCatgory { get; set; }
		[Key(3)]
		public int ExtraValue { get; set; }
	}
}

