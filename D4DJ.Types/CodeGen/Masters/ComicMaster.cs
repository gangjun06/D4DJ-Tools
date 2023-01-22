using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class ComicMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Title { get; set; }
		[Key(2)]
		public string EpisodeNumber { get; set; }
		[Key(3)]
		public DateTime StartDate { get; set; }
		[Key(4)]
		public DateTime EndDate { get; set; }
	}
}

