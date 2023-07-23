using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class RemasterGachaMemberMaster
	{
		[Key(0)]
		public int __GachaPrimaryKey__ { get; set; }
		[Key(1)]
		public int __CardPrimaryKey__ { get; set; }
		[Key(2)]
		public bool Selectable { get; set; }
	}
}

