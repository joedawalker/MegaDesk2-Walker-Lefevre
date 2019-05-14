using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MegaDesk_Walker.Classes;
using MegaDesk_Walker.Properties;

namespace MegaDesk_Walker.Forms
{
	public partial class AddQuote : Form
	{
		public AddQuote()
		{
			InitializeComponent();
			nameRequiredErrorMessage.Text = string.Empty;
			materialSelect.DataSource = Enum.GetValues( typeof( DesktopMaterial ) );
			rushOrderSelect.DataSource = Enum.GetValues( typeof( ProductionType ) ).Cast<Enum>()
				.Select( p => new
				{
					Description = ( Attribute.GetCustomAttribute( p.GetType().GetField( p.ToString() ), typeof( DescriptionAttribute ) ) as DescriptionAttribute )?.Description
								  ?? p.ToString(),
					Value = p
				} ).ToList();
			rushOrderSelect.DisplayMember = "Description";
			rushOrderSelect.ValueMember = "Value";
			dateLabel.Text = DateTime.Today.ToShortDateString();
		}

		private void AddQuote_FormClosed( object sender, FormClosedEventArgs e )
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
		}

		private void GetQuoteButton_Click( object sender, EventArgs e )
		{
			if ( string.IsNullOrWhiteSpace( fullNameInput.Text ) )
			{
				nameRequiredErrorMessage.Text = Resources.Required;
				return;
			}

			Desk desk = new Desk()
			{
				Depth = (int)depthUpDown.Value,
				Width = (int)widthUpDown.Value,
				NumberOfDrawers = (int)numberOfDrawersUpDown.Value,
				SurfaceMaterial = (DesktopMaterial)materialSelect.SelectedItem
			};

			DeskQuote quote = new DeskQuote()
			{
				CustomerName = fullNameInput.Text,
				Desk = desk,
				ProductionType = (ProductionType)rushOrderSelect.SelectedValue,
				Date = DateTime.Now
			};

			quote.QuotePrice = quote.GetQuote();

			DisplayQuote displayQuote = new DisplayQuote( quote );
			displayQuote.ShowDialog();
		}
	}
}
