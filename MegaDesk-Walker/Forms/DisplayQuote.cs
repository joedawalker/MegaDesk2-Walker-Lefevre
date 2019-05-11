using System.Windows.Forms;
using System.Linq;
using MegaDesk_Walker.Classes;
using System.ComponentModel;
using System;

namespace MegaDesk_Walker.Forms
{
	public partial class DisplayQuote : Form
	{
		//public DeskQuote Quote { get; }
		
		public DisplayQuote( DeskQuote quote )
		{
			InitializeComponent();
			//Quote = quote;
			fullNameOutput.Text = quote.CustomerName;
			widthOutput.Text = $"{quote.Desk.Width}in";
			depthOutput.Text = $"{quote.Desk.Depth}in";
			numberOfDrawersOutput.Text = quote.Desk.NumberOfDrawers.ToString();
			surfaceMaterialOutput.Text = quote.Desk.SurfaceMaterial.ToString();
			rushOrderOutput.Text = ( Attribute.GetCustomAttribute( quote.ProductionType.GetType().GetField( quote.ProductionType.ToString() ), typeof( DescriptionAttribute ) ) as DescriptionAttribute )?.Description
			                       ?? quote.ProductionType.ToString();
			dateOutput.Text = quote.Date.ToShortDateString();
			quotePriceOutput.Text = $"${quote.QuotePrice}";
		}
	}
}
