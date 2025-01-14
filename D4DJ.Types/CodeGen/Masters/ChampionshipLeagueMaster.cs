using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ChampionshipLeagueMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public int __ChampionshipPrimaryKey__ { get; set; }
		[Key(2)]
		public string Name { get; set; }
		[Key(3)]
		public string ColorCode { get; set; }
		[Key(4)]
		public int LogoId { get; set; }
		[Key(5)]
		public string TextColorCode { get; set; }
	}
}

