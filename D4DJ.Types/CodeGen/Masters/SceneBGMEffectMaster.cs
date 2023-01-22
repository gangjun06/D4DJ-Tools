using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class SceneBGMEffectMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string SceneName { get; set; }
		[Key(2)]
		public float Volume { get; set; }
		[Key(3)]
		public float[] BandpassFilterValue { get; set; }
	}
}

