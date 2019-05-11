using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Walker.Classes
{
	public class DeskQuote
	{
		public string CustomerName { get; set; }
		public ProductionType ProductionType { get; set; }
		public Desk Desk { get; set; }
		public decimal QuotePrice { get; set; }

		public decimal GetQuote()
		{
			decimal finalPrice = 0;

			return finalPrice;
		}
	}
}
