using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class RatingMusicMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __RatingPrimaryKey__ { get; set; }
		[Key(2)]
		public int __MusicPrimaryKey__ { get; set; }
	}
}

