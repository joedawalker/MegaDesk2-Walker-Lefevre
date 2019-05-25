using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MegaDesk_Walker.Classes;

namespace MegaDesk_Walker.Forms
{
	public partial class SearchQuotes : Form
	{
		private static readonly QuoteFileManager _quoteFileManager = new QuoteFileManager();

		public SearchQuotes()
		{
			InitializeComponent();
			surfaceMaterialComboBox.DataSource = Enum.GetValues( typeof( DesktopMaterial ) );
			surfaceMaterialComboBox.SelectedIndex = -1;
			searchQuotesGridView.DataSource = _quoteFileManager.GetSavedQuotes()
			.Select( p => new
			{
				p.CustomerName,
				p.Desk.Depth,
				p.Desk.Width,
				p.Desk.NumberOfDrawers,
				p.Desk.SurfaceMaterial,
				p.RushOrderType,
				Date = p.Date.ToShortDateString(),
				Price = p.QuotePrice.ToString( "C" )
			} )
			.OrderByDescending( p => p.Date ).ToList();
		}

		private void SearchQuotes_FormClosed( object sender, FormClosedEventArgs e )
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
		}

		private void SurfaceMaterialComboBox_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( surfaceMaterialComboBox.SelectedIndex > -1 )
			{
				DesktopMaterial selectedMaterial = (DesktopMaterial)surfaceMaterialComboBox.SelectedValue;
				searchQuotesGridView.DataSource = _quoteFileManager.GetSavedQuotes()
					.Select( p => new
					{
						p.CustomerName,
						p.Desk.Depth,
						p.Desk.Width,
						p.Desk.NumberOfDrawers,
						p.Desk.SurfaceMaterial,
						p.RushOrderType,
						Date = p.Date.ToShortDateString(),
						Price = p.QuotePrice.ToString( "C" )
					} ).ToList()
					.Where( p => p.SurfaceMaterial == selectedMaterial )
					.OrderByDescending( p => p.Date ).ToList();
			}
		}
	}
}
