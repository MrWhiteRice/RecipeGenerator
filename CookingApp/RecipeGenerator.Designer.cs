namespace CookingApp
{
	partial class RecipeGenerator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeGenerator));
			this.recipeImage = new System.Windows.Forms.PictureBox();
			this.panelMain = new System.Windows.Forms.Panel();
			this.descriptionText = new System.Windows.Forms.Label();
			this.recipeText = new System.Windows.Forms.Label();
			this.labelFoodName = new System.Windows.Forms.Label();
			this.buttonMethod = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonIngredients = new System.Windows.Forms.Button();
			this.buttonRandomRecipe = new System.Windows.Forms.Button();
			this.panelBackPanel = new System.Windows.Forms.Panel();
			this.panelSideBar = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.recipeImage)).BeginInit();
			this.panelMain.SuspendLayout();
			this.panelBackPanel.SuspendLayout();
			this.panelSideBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// recipeImage
			// 
			this.recipeImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.recipeImage.Image = ((System.Drawing.Image)(resources.GetObject("recipeImage.Image")));
			this.recipeImage.Location = new System.Drawing.Point(0, 0);
			this.recipeImage.Margin = new System.Windows.Forms.Padding(0);
			this.recipeImage.Name = "recipeImage";
			this.recipeImage.Size = new System.Drawing.Size(200, 200);
			this.recipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.recipeImage.TabIndex = 3;
			this.recipeImage.TabStop = false;
			// 
			// panelMain
			// 
			this.panelMain.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panelMain.Controls.Add(this.descriptionText);
			this.panelMain.Controls.Add(this.recipeText);
			this.panelMain.Location = new System.Drawing.Point(200, 0);
			this.panelMain.Margin = new System.Windows.Forms.Padding(0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(489, 441);
			this.panelMain.TabIndex = 24;
			// 
			// descriptionText
			// 
			this.descriptionText.AutoSize = true;
			this.descriptionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.descriptionText.Location = new System.Drawing.Point(4, 83);
			this.descriptionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.descriptionText.Name = "descriptionText";
			this.descriptionText.Size = new System.Drawing.Size(25, 13);
			this.descriptionText.TabIndex = 9;
			this.descriptionText.Text = "123";
			// 
			// recipeText
			// 
			this.recipeText.AutoSize = true;
			this.recipeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.recipeText.Location = new System.Drawing.Point(4, 4);
			this.recipeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.recipeText.Name = "recipeText";
			this.recipeText.Size = new System.Drawing.Size(184, 13);
			this.recipeText.TabIndex = 1;
			this.recipeText.Text = "Please click the \'New Recipe\' button!";
			// 
			// labelFoodName
			// 
			this.labelFoodName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.labelFoodName.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.labelFoodName.Location = new System.Drawing.Point(0, 0);
			this.labelFoodName.Margin = new System.Windows.Forms.Padding(0);
			this.labelFoodName.Name = "labelFoodName";
			this.labelFoodName.Size = new System.Drawing.Size(689, 40);
			this.labelFoodName.TabIndex = 0;
			this.labelFoodName.Text = "Food Name";
			this.labelFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonMethod
			// 
			this.buttonMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.buttonMethod.FlatAppearance.BorderSize = 0;
			this.buttonMethod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.buttonMethod.Location = new System.Drawing.Point(0, 200);
			this.buttonMethod.Margin = new System.Windows.Forms.Padding(0);
			this.buttonMethod.Name = "buttonMethod";
			this.buttonMethod.Size = new System.Drawing.Size(200, 35);
			this.buttonMethod.TabIndex = 20;
			this.buttonMethod.Text = "Method";
			this.buttonMethod.UseVisualStyleBackColor = false;
			// 
			// buttonEdit
			// 
			this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.buttonEdit.FlatAppearance.BorderSize = 0;
			this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.buttonEdit.Location = new System.Drawing.Point(638, 0);
			this.buttonEdit.Margin = new System.Windows.Forms.Padding(0);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(51, 40);
			this.buttonEdit.TabIndex = 21;
			this.buttonEdit.Text = "...";
			this.buttonEdit.UseVisualStyleBackColor = false;
			// 
			// buttonIngredients
			// 
			this.buttonIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.buttonIngredients.FlatAppearance.BorderSize = 0;
			this.buttonIngredients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonIngredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.buttonIngredients.Location = new System.Drawing.Point(0, 235);
			this.buttonIngredients.Margin = new System.Windows.Forms.Padding(0);
			this.buttonIngredients.Name = "buttonIngredients";
			this.buttonIngredients.Size = new System.Drawing.Size(200, 35);
			this.buttonIngredients.TabIndex = 21;
			this.buttonIngredients.Text = "Ingredients";
			this.buttonIngredients.UseVisualStyleBackColor = false;
			// 
			// buttonRandomRecipe
			// 
			this.buttonRandomRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.buttonRandomRecipe.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonRandomRecipe.FlatAppearance.BorderSize = 0;
			this.buttonRandomRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonRandomRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRandomRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRandomRecipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.buttonRandomRecipe.Location = new System.Drawing.Point(0, 481);
			this.buttonRandomRecipe.Margin = new System.Windows.Forms.Padding(0);
			this.buttonRandomRecipe.Name = "buttonRandomRecipe";
			this.buttonRandomRecipe.Size = new System.Drawing.Size(689, 80);
			this.buttonRandomRecipe.TabIndex = 20;
			this.buttonRandomRecipe.Text = "Random Recipe!";
			this.buttonRandomRecipe.UseVisualStyleBackColor = false;
			// 
			// panelBackPanel
			// 
			this.panelBackPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panelBackPanel.Controls.Add(this.panelMain);
			this.panelBackPanel.Controls.Add(this.panelSideBar);
			this.panelBackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBackPanel.Location = new System.Drawing.Point(0, 40);
			this.panelBackPanel.Name = "panelBackPanel";
			this.panelBackPanel.Size = new System.Drawing.Size(689, 441);
			this.panelBackPanel.TabIndex = 0;
			// 
			// panelSideBar
			// 
			this.panelSideBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panelSideBar.Controls.Add(this.recipeImage);
			this.panelSideBar.Controls.Add(this.buttonIngredients);
			this.panelSideBar.Controls.Add(this.buttonMethod);
			this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSideBar.Location = new System.Drawing.Point(0, 0);
			this.panelSideBar.Name = "panelSideBar";
			this.panelSideBar.Size = new System.Drawing.Size(200, 441);
			this.panelSideBar.TabIndex = 0;
			// 
			// RecipeGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(689, 561);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.panelBackPanel);
			this.Controls.Add(this.labelFoodName);
			this.Controls.Add(this.buttonRandomRecipe);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RecipeGenerator";
			this.Text = "RecipeGenerator";
			((System.ComponentModel.ISupportInitialize)(this.recipeImage)).EndInit();
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.panelBackPanel.ResumeLayout(false);
			this.panelSideBar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox recipeImage;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Label descriptionText;
		private System.Windows.Forms.Label recipeText;
		private System.Windows.Forms.Label labelFoodName;
		private System.Windows.Forms.Button buttonMethod;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonIngredients;
		private System.Windows.Forms.Button buttonRandomRecipe;
		private System.Windows.Forms.Panel panelBackPanel;
		private System.Windows.Forms.Panel panelSideBar;
	}
}