using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class RewardMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public RewardCategory Category { get; set; }
		[Key(2)]
		public int RewardId { get; set; }
		[Key(3)]
		public int Amount { get; set; }
	}
}

