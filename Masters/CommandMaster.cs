﻿using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
    public class CommandMaster
	{
		[Key(0)]
		public int Id { get; set; }
		[Key(1)]
		public string Title { get; set; }
		[Key(2)]
		public string Command { get; set; }
	}
}
