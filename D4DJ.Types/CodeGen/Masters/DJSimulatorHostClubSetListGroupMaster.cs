using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class DJSimulatorHostClubSetListGroupMaster
	{
		[Key(0)]
		public int __UnitPrimaryKey__ { get; set; }
		[Key(1)]
		public int[] GroupIndexes { get; set; }
	}
}

