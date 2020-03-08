namespace CookingApp
{
	partial class Window
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
			this.recipeImage = new System.Windows.Forms.PictureBox();
			this.labelFilters = new System.Windows.Forms.Label();
			this.buttonBreakfast = new System.Windows.Forms.Button();
			this.buttonOldFavourites = new System.Windows.Forms.Button();
			this.buttonQuickAndEasy = new System.Windows.Forms.Button();
			this.buttonHealthy = new System.Windows.Forms.Button();
			this.buttonSharingWithFriends = new System.Windows.Forms.Button();
			this.panelSide = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.recipeText = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.descriptionText = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.recipeImage)).BeginInit();
			this.panelSide.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// recipeImage
			// 
			this.recipeImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.recipeImage.Image = ((System.Drawing.Image)(resources.GetObject("recipeImage.Image")));
			this.recipeImage.Location = new System.Drawing.Point(0, 39);
			this.recipeImage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
			this.recipeImage.Name = "recipeImage";
			this.recipeImage.Size = new System.Drawing.Size(150, 150);
			this.recipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.recipeImage.TabIndex = 3;
			this.recipeImage.TabStop = false;
			// 
			// labelFilters
			// 
			this.labelFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.labelFilters.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.labelFilters.Location = new System.Drawing.Point(0, 0);
			this.labelFilters.Name = "labelFilters";
			this.labelFilters.Size = new System.Drawing.Size(200, 35);
			this.labelFilters.TabIndex = 0;
			this.labelFilters.Text = "Recipe Filters";
			this.labelFilters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonBreakfast
			// 
			this.buttonBreakfast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.buttonBreakfast.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonBreakfast.FlatAppearance.BorderSize = 0;
			this.buttonBreakfast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonBreakfast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBreakfast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.buttonBreakfast.Location = new System.Drawing.Point(0, 35);
			this.buttonBreakfast.Name = "buttonBreakfast";
			this.buttonBreakfast.Size = new System.Drawing.Size(200, 35);
			this.buttonBreakfast.TabIndex = 15;
			this.buttonBreakfast.Text = "Breakfast";
			this.buttonBreakfast.UseVisualStyleBackColor = false;
			this.buttonBreakfast.Click += new System.EventHandler(this.buttonBreakfast_Click);
			// 
			// buttonOldFavourites
			// 
			this.buttonOldFavourites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.buttonOldFavourites.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonOldFavourites.FlatAppearance.BorderSize = 0;
			this.buttonOldFavourites.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonOldFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOldFavourites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.buttonOldFavourites.Location = new System.Drawing.Point(0, 70);
			this.buttonOldFavourites.Name = "buttonOldFavourites";
			this.buttonOldFavourites.Size = new System.Drawing.Size(200, 35);
			this.buttonOldFavourites.TabIndex = 16;
			this.buttonOldFavourites.Text = "Old Favourites";
			this.buttonOldFavourites.UseVisualStyleBackColor = false;
			this.buttonOldFavourites.Click += new System.EventHandler(this.buttonOldFavourites_Click);
			// 
			// buttonQuickAndEasy
			// 
			this.buttonQuickAndEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.buttonQuickAndEasy.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonQuickAndEasy.FlatAppearance.BorderSize = 0;
			this.buttonQuickAndEasy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonQuickAndEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonQuickAndEasy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.buttonQuickAndEasy.Location = new System.Drawing.Point(0, 105);
			this.buttonQuickAndEasy.Name = "buttonQuickAndEasy";
			this.buttonQuickAndEasy.Size = new System.Drawing.Size(200, 35);
			this.buttonQuickAndEasy.TabIndex = 17;
			this.buttonQuickAndEasy.Text = "Quick and Easy";
			this.buttonQuickAndEasy.UseVisualStyleBackColor = false;
			this.buttonQuickAndEasy.Click += new System.EventHandler(this.buttonQuickAndEasy_Click);
			// 
			// buttonHealthy
			// 
			this.buttonHealthy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.buttonHealthy.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonHealthy.FlatAppearance.BorderSize = 0;
			this.buttonHealthy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonHealthy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonHealthy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.buttonHealthy.Location = new System.Drawing.Point(0, 140);
			this.buttonHealthy.Name = "buttonHealthy";
			this.buttonHealthy.Size = new System.Drawing.Size(200, 35);
			this.buttonHealthy.TabIndex = 18;
			this.buttonHealthy.Text = "Healthy";
			this.buttonHealthy.UseVisualStyleBackColor = false;
			this.buttonHealthy.Click += new System.EventHandler(this.buttonHealth_Click);
			// 
			// buttonSharingWithFriends
			// 
			this.buttonSharingWithFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.buttonSharingWithFriends.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonSharingWithFriends.FlatAppearance.BorderSize = 0;
			this.buttonSharingWithFriends.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonSharingWithFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSharingWithFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.buttonSharingWithFriends.Location = new System.Drawing.Point(0, 175);
			this.buttonSharingWithFriends.Name = "buttonSharingWithFriends";
			this.buttonSharingWithFriends.Size = new System.Drawing.Size(200, 35);
			this.buttonSharingWithFriends.TabIndex = 19;
			this.buttonSharingWithFriends.Text = "Sharing with Friends";
			this.buttonSharingWithFriends.UseVisualStyleBackColor = false;
			this.buttonSharingWithFriends.Click += new System.EventHandler(this.buttonSharingWithFriends_Click);
			// 
			// panelSide
			// 
			this.panelSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panelSide.AutoScroll = true;
			this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.panelSide.Controls.Add(this.button6);
			this.panelSide.Controls.Add(this.buttonSharingWithFriends);
			this.panelSide.Controls.Add(this.buttonHealthy);
			this.panelSide.Controls.Add(this.buttonQuickAndEasy);
			this.panelSide.Controls.Add(this.buttonOldFavourites);
			this.panelSide.Controls.Add(this.buttonBreakfast);
			this.panelSide.Controls.Add(this.labelFilters);
			this.panelSide.Location = new System.Drawing.Point(0, 0);
			this.panelSide.Margin = new System.Windows.Forms.Padding(0);
			this.panelSide.Name = "panelSide";
			this.panelSide.Size = new System.Drawing.Size(200, 481);
			this.panelSide.TabIndex = 10;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.button6.Location = new System.Drawing.Point(161, 0);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(39, 35);
			this.button6.TabIndex = 20;
			this.button6.Text = "...";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.button2.Location = new System.Drawing.Point(0, 481);
			this.button2.Margin = new System.Windows.Forms.Padding(0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(200, 80);
			this.button2.TabIndex = 21;
			this.button2.Text = "Add Recipe";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// recipeText
			// 
			this.recipeText.AutoSize = true;
			this.recipeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.recipeText.Location = new System.Drawing.Point(385, 79);
			this.recipeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.recipeText.Name = "recipeText";
			this.recipeText.Size = new System.Drawing.Size(238, 17);
			this.recipeText.TabIndex = 1;
			this.recipeText.Text = "Please click the \'New Recipe\' button!";
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.button3.Location = new System.Drawing.Point(560, 0);
			this.button3.Margin = new System.Windows.Forms.Padding(0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(125, 40);
			this.button3.TabIndex = 21;
			this.button3.Text = "...";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.button1.Location = new System.Drawing.Point(0, 481);
			this.button1.Margin = new System.Windows.Forms.Padding(0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(685, 80);
			this.button1.TabIndex = 20;
			this.button1.Text = "Random Recipe!";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.descriptionText);
			this.panel1.Location = new System.Drawing.Point(0, 189);
			this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(685, 292);
			this.panel1.TabIndex = 24;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.button5.Location = new System.Drawing.Point(340, 0);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(345, 35);
			this.button5.TabIndex = 21;
			this.button5.Text = "Ingredients";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.button4.Location = new System.Drawing.Point(0, 0);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(345, 35);
			this.button4.TabIndex = 20;
			this.button4.Text = "Method";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// descriptionText
			// 
			this.descriptionText.AutoSize = true;
			this.descriptionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.descriptionText.Location = new System.Drawing.Point(4, 38);
			this.descriptionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.descriptionText.Name = "descriptionText";
			this.descriptionText.Size = new System.Drawing.Size(32, 17);
			this.descriptionText.TabIndex = 9;
			this.descriptionText.Text = "123";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(560, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Food Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkCyan;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.recipeImage);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.recipeText);
			this.panel2.Location = new System.Drawing.Point(200, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(685, 561);
			this.panel2.TabIndex = 25;
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panelSide);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(900, 600);
			this.Name = "Window";
			this.Text = "Recipe Generator";
			((System.ComponentModel.ISupportInitialize)(this.recipeImage)).EndInit();
			this.panelSide.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox recipeImage;
		private System.Windows.Forms.Label labelFilters;
		private System.Windows.Forms.Button buttonBreakfast;
		private System.Windows.Forms.Button buttonOldFavourites;
		private System.Windows.Forms.Button buttonQuickAndEasy;
		private System.Windows.Forms.Button buttonHealthy;
		private System.Windows.Forms.Button buttonSharingWithFriends;
		public System.Windows.Forms.Panel panelSide;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label recipeText;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label descriptionText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button6;
	}
}

