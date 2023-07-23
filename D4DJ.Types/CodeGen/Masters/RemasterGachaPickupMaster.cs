using MessagePack;
using System;

namespace D4DJ_Tools.Masters
{
	[MessagePackObject]
	public class RemasterGachaPickupMaster
	{
		[Key(0)]
		public int __IdPrimaryKey__ { get; set; }
		[Key(1)]
		public int __ConfirmedExplanationWordPrimaryKey__ { get; set; }
		[Key(2)]
		public int Amount { get; set; }
		[Key(3)]
		public int SelectedCardsRate { get; set; }
		[Key(4)]
		public int OtherCardsRate { get; set; }
	}
}

