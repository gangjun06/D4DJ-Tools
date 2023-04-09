using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class CardHomeDisplayOverwriteMaster
	{
		[Key(0)]
		public int __CardPrimaryKey__ { get; set; }
		[Key(1)]
		public float[] CardIllustHeadDistanceY { get; set; }
		[Key(2)]
		public float[] CardIllustCenterDistanceX { get; set; }
	}
}

