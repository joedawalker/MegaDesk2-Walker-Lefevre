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
            allQuotesGridView.DataSource = _quoteFileManager.GetSavedQuotes();
		}

		private void ViewAllQuotes_FormClosed( object sender, FormClosedEventArgs e )
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
		}
	}
}
