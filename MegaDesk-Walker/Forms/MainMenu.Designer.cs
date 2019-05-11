namespace MegaDesk_Walker
{
	partial class MainMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
			this.addNewQuoteButton = new System.Windows.Forms.Button();
			this.viewQuotesButton = new System.Windows.Forms.Button();
			this.searchQuotesButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// addNewQuoteButton
			// 
			this.addNewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNewQuoteButton.Location = new System.Drawing.Point(92, 78);
			this.addNewQuoteButton.Name = "addNewQuoteButton";
			this.addNewQuoteButton.Size = new System.Drawing.Size(313, 99);
			this.addNewQuoteButton.TabIndex = 0;
			this.addNewQuoteButton.Text = "Add New Quote";
			this.addNewQuoteButton.UseVisualStyleBackColor = true;
			// 
			// viewQuotesButton
			// 
			this.viewQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.viewQuotesButton.Location = new System.Drawing.Point(92, 225);
			this.viewQuotesButton.Name = "viewQuotesButton";
			this.viewQuotesButton.Size = new System.Drawing.Size(313, 99);
			this.viewQuotesButton.TabIndex = 1;
			this.viewQuotesButton.Text = "View Quotes";
			this.viewQuotesButton.UseVisualStyleBackColor = true;
			// 
			// searchQuotesButton
			// 
			this.searchQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchQuotesButton.Location = new System.Drawing.Point(92, 365);
			this.searchQuotesButton.Name = "searchQuotesButton";
			this.searchQuotesButton.Size = new System.Drawing.Size(313, 99);
			this.searchQuotesButton.TabIndex = 2;
			this.searchQuotesButton.Text = "Search Quotes";
			this.searchQuotesButton.UseVisualStyleBackColor = true;
			// 
			// exitButton
			// 
			this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.Location = new System.Drawing.Point(92, 509);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(313, 99);
			this.exitButton.TabIndex = 3;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(513, 120);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(496, 456);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1112, 684);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.searchQuotesButton);
			this.Controls.Add(this.viewQuotesButton);
			this.Controls.Add(this.addNewQuoteButton);
			this.Name = "MainMenu";
			this.Text = "Main Menu";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addNewQuoteButton;
		private System.Windows.Forms.Button viewQuotesButton;
		private System.Windows.Forms.Button searchQuotesButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

