using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class OverrideDefinedGameTextMaster
	{
		[Key(0)]
		public string Type { get; set; }
		[Key(1)]
		public string Text { get; set; }
	}
}
