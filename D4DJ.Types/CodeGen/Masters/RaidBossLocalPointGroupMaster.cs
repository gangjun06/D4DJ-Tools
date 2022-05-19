using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class RaidBossLocalPointGroupMaster
	{
		[Key(0)]
		public int GroupId { get; set; }
		[Key(1)]
		public int[] BossIds { get; set; }
	}
}

