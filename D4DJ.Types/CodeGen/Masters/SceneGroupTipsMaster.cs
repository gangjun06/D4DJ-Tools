using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class SceneGroupTipsMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string SceneName { get; set; }
		[Key(2)]
		public int[] GroupIds { get; set; }
	}
}

