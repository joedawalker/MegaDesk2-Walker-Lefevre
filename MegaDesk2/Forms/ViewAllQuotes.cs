using System.Linq;
using System.Windows.Forms;
using MegaDesk_Walker.Classes;
using MegaDesk_Walker.Properties;

namespace MegaDesk_Walker.Forms
{
	public partial class ViewAllQuotes : Form
	{
        private readonly QuoteFileManager _quoteFileManager = new QuoteFileManager();
        public ViewAllQuotes()
		{
			InitializeComponent();
			allQuotesGridView.DataSource =  _quoteFileManager.GetSavedQuotes()
				.Select(p =>
				new {
					p.CustomerName,
					p.Desk.Depth,
					p.Desk.Width,
					p.Desk.NumberOfDrawers,
					p.Desk.SurfaceMaterial,
					p.RushOrderType,
					Date = p.Date.ToShortDateString(),
					Price = p.QuotePrice.ToString("C")
					}).OrderByDescending( p => p.Date ).ToList();
		}

		private void ViewAllQuotes_FormClosed( object sender, FormClosedEventArgs e )
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
		}
	}
}
