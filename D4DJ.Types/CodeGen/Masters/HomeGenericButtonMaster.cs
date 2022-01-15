using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class HomeGenericButtonMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Command { get; set; }
		[Key(2)]
		public DateTime StartDate { get; set; }
		[Key(3)]
		public DateTime EndDate { get; set; }
	}
}

