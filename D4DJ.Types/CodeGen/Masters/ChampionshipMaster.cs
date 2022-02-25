using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ChampionshipMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public int[] __ConditionsPrimaryKey__ { get; set; }
		[Key(3)]
		public string Summary { get; set; }
		[Key(4)]
		public string LeagueSummary { get; set; }
		[Key(5)]
		public string Schedule { get; set; }
		[Key(6)]
		public string EntryDescription { get; set; }
		[Key(7)]
		public string URL { get; set; }
		[Key(8)]
		public string EntryURL { get; set; }
		[Key(9)]
		public DateTime StartDate { get; set; }
		[Key(10)]
		public DateTime EndDate { get; set; }
		[Key(11)]
		public int MaxPassNumber { get; set; }
	}
}

