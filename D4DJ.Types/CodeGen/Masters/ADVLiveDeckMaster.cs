using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ADVLiveDeckMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public int Order { get; set; }
		[Key(3)]
		public int __CardPrimaryKey__ { get; set; }
		[Key(4)]
		public CardIllustType IllustType { get; set; }
	}
}

