using System.ComponentModel;

namespace MegaDesk_Walker.Classes
{
	public enum RushOrderType
	{
		[Description( "14-Day (Normal)" )]
		FourteenDay = 0,
		[Description("3-Day")]
		ThreeDay = 1,
		[Description("5-Day")]
		FiveDay = 2,
		[Description("7-Day")]
		SevenDay = 3
	}
}
