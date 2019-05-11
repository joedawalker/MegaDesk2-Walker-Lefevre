using System.Windows.Forms;

namespace MegaDesk_Walker.Forms
{
	public partial class SearchQuotes : Form
	{
		public SearchQuotes()
		{
			InitializeComponent();
		}

		private void SearchQuotes_FormClosed( object sender, FormClosedEventArgs e )
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
		}
	}
}
