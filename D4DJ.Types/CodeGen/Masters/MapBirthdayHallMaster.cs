using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class MapBirthdayHallMaster
	{
		[Key(0)]
		public int __CharacterPrimaryKey__ { get; set; }
		[Key(1)]
		public DateTime StartDate { get; set; }
		[Key(2)]
		public DateTime EndDate { get; set; }
		[Key(3)]
		public int TowerId { get; set; }
	}
}

