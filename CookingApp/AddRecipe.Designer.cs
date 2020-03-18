namespace CookingApp
{
	partial class AddRecipe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecipe));
			this.recipeImage = new System.Windows.Forms.PictureBox();
			this.buttonIngredients = new System.Windows.Forms.Button();
			this.panelSideBar = new System.Windows.Forms.Panel();
			this.buttonMethod = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.panelBackPanel = new System.Windows.Forms.Panel();
			this.panelMain = new System.Windows.Forms.Panel();
			this.panelAdd = new System.Windows.Forms.Panel();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonSaveRecipe = new System.Windows.Forms.Button();
			this.textBoxRecipeName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.recipeImage)).BeginInit();
			this.panelSideBar.SuspendLayout();
			this.panelBackPanel.SuspendLayout();
			this.panelMain.SuspendLayout();
			this.panelAdd.SuspendLayout();
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
			// buttonIngredients
			// 
			this.buttonIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.buttonIngredients.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonIngredients.FlatAppearance.BorderSize = 0;
			this.buttonIngredients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonIngredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.buttonIngredients.Location = new System.Drawing.Point(0, 235);
			this.buttonIngredients.Margin = new System.Windows.Forms.Padding(0);
			this.buttonIngredients.Name = "buttonIngredients";
			this.buttonIngredients.Size = new System.Drawing.Size(200, 35);
			this.buttonIngredients.TabIndex = 21;
			this.buttonIngredients.TabStop = false;
			this.buttonIngredients.Text = "Ingredients";
			this.buttonIngredients.UseVisualStyleBackColor = false;
			this.buttonIngredients.Click += new System.EventHandler(this.buttonIngredients_Click);
			// 
			// panelSideBar
			// 
			this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panelSideBar.Controls.Add(this.recipeImage);
			this.panelSideBar.Controls.Add(this.buttonIngredients);
			this.panelSideBar.Controls.Add(this.buttonMethod);
			this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSideBar.Location = new System.Drawing.Point(0, 0);
			this.panelSideBar.Margin = new System.Windows.Forms.Padding(0);
			this.panelSideBar.Name = "panelSideBar";
			this.panelSideBar.Size = new System.Drawing.Size(200, 441);
			this.panelSideBar.TabIndex = 0;
			// 
			// buttonMethod
			// 
			this.buttonMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.buttonMethod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonMethod.FlatAppearance.BorderSize = 0;
			this.buttonMethod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.buttonMethod.Location = new System.Drawing.Point(0, 200);
			this.buttonMethod.Margin = new System.Windows.Forms.Padding(0);
			this.buttonMethod.Name = "buttonMethod";
			this.buttonMethod.Size = new System.Drawing.Size(200, 35);
			this.buttonMethod.TabIndex = 20;
			this.buttonMethod.TabStop = false;
			this.buttonMethod.Text = "Method";
			this.buttonMethod.UseVisualStyleBackColor = false;
			this.buttonMethod.Click += new System.EventHandler(this.buttonMethod_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExit.BackColor = System.Drawing.Color.Red;
			this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonExit.FlatAppearance.BorderSize = 0;
			this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.buttonExit.Location = new System.Drawing.Point(638, 0);
			this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(51, 40);
			this.buttonExit.TabIndex = 26;
			this.buttonExit.TabStop = false;
			this.buttonExit.Text = "X";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
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
			this.panelBackPanel.TabIndex = 23;
			// 
			// panelMain
			// 
			this.panelMain.AutoScroll = true;
			this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.panelMain.Controls.Add(this.panelAdd);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(200, 0);
			this.panelMain.Margin = new System.Windows.Forms.Padding(0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(489, 441);
			this.panelMain.TabIndex = 24;
			this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
			// 
			// panelAdd
			// 
			this.panelAdd.Controls.Add(this.buttonAdd);
			this.panelAdd.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelAdd.Location = new System.Drawing.Point(0, 0);
			this.panelAdd.Name = "panelAdd";
			this.panelAdd.Size = new System.Drawing.Size(489, 35);
			this.panelAdd.TabIndex = 500;
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonAdd.FlatAppearance.BorderSize = 0;
			this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.buttonAdd.Location = new System.Drawing.Point(454, 0);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(35, 35);
			this.buttonAdd.TabIndex = 21;
			this.buttonAdd.TabStop = false;
			this.buttonAdd.Text = "+";
			this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonSaveRecipe
			// 
			this.buttonSaveRecipe.BackColor = System.Drawing.Color.Green;
			this.buttonSaveRecipe.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonSaveRecipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.buttonSaveRecipe.FlatAppearance.BorderSize = 0;
			this.buttonSaveRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.buttonSaveRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSaveRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSaveRecipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.buttonSaveRecipe.Location = new System.Drawing.Point(0, 481);
			this.buttonSaveRecipe.Margin = new System.Windows.Forms.Padding(0);
			this.buttonSaveRecipe.Name = "buttonSaveRecipe";
			this.buttonSaveRecipe.Size = new System.Drawing.Size(689, 80);
			this.buttonSaveRecipe.TabIndex = 25;
			this.buttonSaveRecipe.TabStop = false;
			this.buttonSaveRecipe.Text = "Save Recipe!";
			this.buttonSaveRecipe.UseVisualStyleBackColor = false;
			this.buttonSaveRecipe.Click += new System.EventHandler(this.buttonSaveRecipe_Click);
			// 
			// textBoxRecipeName
			// 
			this.textBoxRecipeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.textBoxRecipeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxRecipeName.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxRecipeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.textBoxRecipeName.Location = new System.Drawing.Point(0, 0);
			this.textBoxRecipeName.Margin = new System.Windows.Forms.Padding(0);
			this.textBoxRecipeName.Name = "textBoxRecipeName";
			this.textBoxRecipeName.Size = new System.Drawing.Size(689, 40);
			this.textBoxRecipeName.TabIndex = 29;
			this.textBoxRecipeName.Text = "Recipe Name";
			this.textBoxRecipeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// AddRecipe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(689, 561);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.panelBackPanel);
			this.Controls.Add(this.buttonSaveRecipe);
			this.Controls.Add(this.textBoxRecipeName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddRecipe";
			this.Text = "AddRecipe";
			((System.ComponentModel.ISupportInitialize)(this.recipeImage)).EndInit();
			this.panelSideBar.ResumeLayout(false);
			this.panelBackPanel.ResumeLayout(false);
			this.panelMain.ResumeLayout(false);
			this.panelAdd.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox recipeImage;
		private System.Windows.Forms.Button buttonIngredients;
		private System.Windows.Forms.Panel panelSideBar;
		private System.Windows.Forms.Button buttonMethod;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Panel panelBackPanel;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Button buttonSaveRecipe;
		private System.Windows.Forms.TextBox textBoxRecipeName;
		private System.Windows.Forms.Panel panelAdd;
		private System.Windows.Forms.Button buttonAdd;
	}
}