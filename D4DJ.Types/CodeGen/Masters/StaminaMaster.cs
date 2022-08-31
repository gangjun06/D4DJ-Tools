using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class StaminaMaster
	{
		[Key(0)]
		public StaminaCategory Category { get; set; }
		[Key(1)]
		public string Name { get; set; }
		[Key(2)]
		public int MaxCount { get; set; }
		[Key(3)]
		public int MaxAllowCount { get; set; }
		[Key(4)]
		public int RecoverySeconds { get; set; }
		[Key(5)]
		public DateTime StartDate { get; set; }
		[Key(6)]
		public DateTime EndDate { get; set; }
		[Key(7)]
		public EventType EventType { get; set; }
	}
}

