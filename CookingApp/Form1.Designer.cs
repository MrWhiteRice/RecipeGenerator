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
			this.nextRecipe = new System.Windows.Forms.Button();
			this.recipeText = new System.Windows.Forms.Label();
			this.recipeImage = new System.Windows.Forms.PictureBox();
			this.checkBoxBreakfast = new System.Windows.Forms.CheckBox();
			this.checkBoxOldFavourites = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkBoxSharingWithFriends = new System.Windows.Forms.CheckBox();
			this.checkBoxHealthy = new System.Windows.Forms.CheckBox();
			this.checkBoxQuickAndEasy = new System.Windows.Forms.CheckBox();
			this.buttonIngredients = new System.Windows.Forms.Button();
			this.buttonMethod = new System.Windows.Forms.Button();
			this.descriptionText = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.recipeImage)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// nextRecipe
			// 
			this.nextRecipe.Location = new System.Drawing.Point(160, 219);
			this.nextRecipe.Name = "nextRecipe";
			this.nextRecipe.Size = new System.Drawing.Size(100, 30);
			this.nextRecipe.TabIndex = 0;
			this.nextRecipe.Text = "New Recipe";
			this.nextRecipe.UseVisualStyleBackColor = true;
			this.nextRecipe.Click += new System.EventHandler(this.nextRecipe_Click);
			// 
			// recipeText
			// 
			this.recipeText.AutoSize = true;
			this.recipeText.Location = new System.Drawing.Point(157, 13);
			this.recipeText.Name = "recipeText";
			this.recipeText.Size = new System.Drawing.Size(184, 13);
			this.recipeText.TabIndex = 1;
			this.recipeText.Text = "Please click the \'New Recipe\' button!";
			// 
			// recipeImage
			// 
			this.recipeImage.Location = new System.Drawing.Point(13, 13);
			this.recipeImage.Name = "recipeImage";
			this.recipeImage.Size = new System.Drawing.Size(120, 120);
			this.recipeImage.TabIndex = 3;
			this.recipeImage.TabStop = false;
			// 
			// checkBoxBreakfast
			// 
			this.checkBoxBreakfast.AutoSize = true;
			this.checkBoxBreakfast.Location = new System.Drawing.Point(3, 3);
			this.checkBoxBreakfast.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.checkBoxBreakfast.Name = "checkBoxBreakfast";
			this.checkBoxBreakfast.Size = new System.Drawing.Size(71, 17);
			this.checkBoxBreakfast.TabIndex = 4;
			this.checkBoxBreakfast.Text = "Breakfast";
			this.checkBoxBreakfast.UseVisualStyleBackColor = true;
			// 
			// checkBoxOldFavourites
			// 
			this.checkBoxOldFavourites.AutoSize = true;
			this.checkBoxOldFavourites.Location = new System.Drawing.Point(3, 20);
			this.checkBoxOldFavourites.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.checkBoxOldFavourites.Name = "checkBoxOldFavourites";
			this.checkBoxOldFavourites.Size = new System.Drawing.Size(94, 17);
			this.checkBoxOldFavourites.TabIndex = 5;
			this.checkBoxOldFavourites.Text = "Old Favourites";
			this.checkBoxOldFavourites.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.checkBoxSharingWithFriends);
			this.panel1.Controls.Add(this.checkBoxHealthy);
			this.panel1.Controls.Add(this.checkBoxQuickAndEasy);
			this.panel1.Controls.Add(this.checkBoxBreakfast);
			this.panel1.Controls.Add(this.checkBoxOldFavourites);
			this.panel1.Location = new System.Drawing.Point(12, 155);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(120, 94);
			this.panel1.TabIndex = 6;
			// 
			// checkBoxSharingWithFriends
			// 
			this.checkBoxSharingWithFriends.AutoSize = true;
			this.checkBoxSharingWithFriends.Location = new System.Drawing.Point(3, 71);
			this.checkBoxSharingWithFriends.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.checkBoxSharingWithFriends.Name = "checkBoxSharingWithFriends";
			this.checkBoxSharingWithFriends.Size = new System.Drawing.Size(121, 17);
			this.checkBoxSharingWithFriends.TabIndex = 8;
			this.checkBoxSharingWithFriends.Text = "Sharing with Friends";
			this.checkBoxSharingWithFriends.UseVisualStyleBackColor = true;
			// 
			// checkBoxHealthy
			// 
			this.checkBoxHealthy.AutoSize = true;
			this.checkBoxHealthy.Location = new System.Drawing.Point(3, 54);
			this.checkBoxHealthy.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.checkBoxHealthy.Name = "checkBoxHealthy";
			this.checkBoxHealthy.Size = new System.Drawing.Size(62, 17);
			this.checkBoxHealthy.TabIndex = 7;
			this.checkBoxHealthy.Text = "Healthy";
			this.checkBoxHealthy.UseVisualStyleBackColor = true;
			// 
			// checkBoxQuickAndEasy
			// 
			this.checkBoxQuickAndEasy.AutoSize = true;
			this.checkBoxQuickAndEasy.Location = new System.Drawing.Point(3, 37);
			this.checkBoxQuickAndEasy.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.checkBoxQuickAndEasy.Name = "checkBoxQuickAndEasy";
			this.checkBoxQuickAndEasy.Size = new System.Drawing.Size(101, 17);
			this.checkBoxQuickAndEasy.TabIndex = 6;
			this.checkBoxQuickAndEasy.Text = "Quick and Easy";
			this.checkBoxQuickAndEasy.UseVisualStyleBackColor = true;
			// 
			// buttonIngredients
			// 
			this.buttonIngredients.Location = new System.Drawing.Point(160, 60);
			this.buttonIngredients.Name = "buttonIngredients";
			this.buttonIngredients.Size = new System.Drawing.Size(75, 23);
			this.buttonIngredients.TabIndex = 7;
			this.buttonIngredients.Text = "Ingredients";
			this.buttonIngredients.UseVisualStyleBackColor = true;
			this.buttonIngredients.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonMethod
			// 
			this.buttonMethod.Location = new System.Drawing.Point(241, 60);
			this.buttonMethod.Name = "buttonMethod";
			this.buttonMethod.Size = new System.Drawing.Size(75, 23);
			this.buttonMethod.TabIndex = 8;
			this.buttonMethod.Text = "Method";
			this.buttonMethod.UseVisualStyleBackColor = true;
			this.buttonMethod.Click += new System.EventHandler(this.button2_Click);
			// 
			// descriptionText
			// 
			this.descriptionText.AutoSize = true;
			this.descriptionText.Location = new System.Drawing.Point(157, 86);
			this.descriptionText.Name = "descriptionText";
			this.descriptionText.Size = new System.Drawing.Size(0, 13);
			this.descriptionText.TabIndex = 9;
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 261);
			this.Controls.Add(this.descriptionText);
			this.Controls.Add(this.buttonMethod);
			this.Controls.Add(this.buttonIngredients);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.recipeImage);
			this.Controls.Add(this.recipeText);
			this.Controls.Add(this.nextRecipe);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Window";
			this.Text = "Recipe Generator";
			((System.ComponentModel.ISupportInitialize)(this.recipeImage)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button nextRecipe;
		private System.Windows.Forms.Label recipeText;
		private System.Windows.Forms.PictureBox recipeImage;
		private System.Windows.Forms.CheckBox checkBoxBreakfast;
		private System.Windows.Forms.CheckBox checkBoxOldFavourites;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBoxSharingWithFriends;
		private System.Windows.Forms.CheckBox checkBoxHealthy;
		private System.Windows.Forms.CheckBox checkBoxQuickAndEasy;
		private System.Windows.Forms.Button buttonIngredients;
		private System.Windows.Forms.Button buttonMethod;
		private System.Windows.Forms.Label descriptionText;
	}
}

