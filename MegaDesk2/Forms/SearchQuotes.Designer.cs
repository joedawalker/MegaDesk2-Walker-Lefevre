namespace MegaDesk_Walker.Forms
{
	partial class SearchQuotes
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.searchQuotesGridView = new System.Windows.Forms.DataGridView();
			this.surfaceMaterialLabel = new System.Windows.Forms.Label();
			this.surfaceMaterialComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.searchQuotesGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// searchQuotesGridView
			// 
			this.searchQuotesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.searchQuotesGridView.Location = new System.Drawing.Point(0, 84);
			this.searchQuotesGridView.Name = "searchQuotesGridView";
			this.searchQuotesGridView.Size = new System.Drawing.Size(849, 361);
			this.searchQuotesGridView.TabIndex = 1;
			// 
			// surfaceMaterialLabel
			// 
			this.surfaceMaterialLabel.AutoSize = true;
			this.surfaceMaterialLabel.Location = new System.Drawing.Point(12, 30);
			this.surfaceMaterialLabel.Name = "surfaceMaterialLabel";
			this.surfaceMaterialLabel.Size = new System.Drawing.Size(169, 25);
			this.surfaceMaterialLabel.TabIndex = 2;
			this.surfaceMaterialLabel.Text = "Surface Material";
			// 
			// surfaceMaterialComboBox
			// 
			this.surfaceMaterialComboBox.FormattingEnabled = true;
			this.surfaceMaterialComboBox.Location = new System.Drawing.Point(175, 27);
			this.surfaceMaterialComboBox.Name = "surfaceMaterialComboBox";
			this.surfaceMaterialComboBox.Size = new System.Drawing.Size(121, 33);
			this.surfaceMaterialComboBox.TabIndex = 3;
			this.surfaceMaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.SurfaceMaterialComboBox_SelectedIndexChanged);
			// 
			// SearchQuotes
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(848, 450);
			this.Controls.Add(this.surfaceMaterialComboBox);
			this.Controls.Add(this.surfaceMaterialLabel);
			this.Controls.Add(this.searchQuotesGridView);
			this.Name = "SearchQuotes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search Quotes";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.searchQuotesGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView searchQuotesGridView;
		private System.Windows.Forms.Label surfaceMaterialLabel;
		private System.Windows.Forms.ComboBox surfaceMaterialComboBox;
	}
}