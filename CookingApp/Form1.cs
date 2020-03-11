using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingApp
{
	public enum RecipeType
	{
		Breakfast,
		OldFavourites,
		QuickAndEasy,
		Healthy,
		SharingWithFriends
	}

	public partial class Window : Form
	{
		public List<Recipe> recipes = new List<Recipe>();
		public List<RecipeToggle> buttonToggles = new List<RecipeToggle>();

		Form activeSubForm = null;

		public static Window window;

		public Window()
		{
			window = this;

			//set up window
			InitializeComponent();

			//Init Bool matrix
			InitBoolMatrix();

			//set up recipes
			InitRecipes();

			//toggle a filter so we dont throw an error
			ToggleFilter("QuickAndEasy");

			//Set up first viewport
			OpenSubMenu(new RecipeGenerator());
		}

		//called when window is closed
		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			base.OnFormClosed(e);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if(!msg.HWnd.Equals(this.Handle) && (keyData == Keys.Tab) || (keyData == Keys.Left || keyData == Keys.Right || keyData == Keys.Up || keyData == Keys.Down))
			{
				buttonFocusStealer.Focus();
				return true;
			}

			buttonFocusStealer.Focus();
			return base.ProcessCmdKey(ref msg, keyData);
		}

		void InitBoolMatrix()
		{
			foreach(string e in Enum.GetNames(typeof(RecipeType)))
			{
				buttonToggles.Add(new RecipeToggle(e));
				Console.WriteLine("adding: " + e);
			}
		}

		void InitRecipes()
		{
			//Writer
			if(false)
			{
				JsonSerializer serializer = new JsonSerializer();
				foreach(Recipe r in recipes)
				{
					using(StreamWriter sw = new StreamWriter("Recipes/" + r.name + ".json", false))
					{
						using(JsonWriter writer = new JsonTextWriter(sw))
						{
							serializer.Serialize(writer, r);
						}
					}
				}
			}

			//reader
			if(true)
			{
				string[] files = Directory.GetFiles("Recipes");
				foreach(string s in files)
				{
					using(StreamReader reader = new StreamReader(s))
					{ 
						Recipe recipe = JsonConvert.DeserializeObject<Recipe>(reader.ReadToEnd());
						recipes.Add(recipe);
					}
				}
			}
		}

		void OpenSubMenu(Form form)
		{
			if(activeSubForm != null)
			{
				activeSubForm.Close();
			}

			activeSubForm = form;

			form.TopLevel = false;
			form.FormBorderStyle = FormBorderStyle.None;
			form.Dock = DockStyle.Fill;
			panelViewPort.Controls.Add(form);
			panelViewPort.Tag = form;
			form.BringToFront();
			form.Show();
		}

		void ToggleFilter(object toggle)
		{
			Button b = (Button)toggle;
			string toggleName = b.Name.Replace("button", "");

			foreach(RecipeToggle r in buttonToggles)
			{
				if(r.name == toggleName)
				{
					r.set = !r.set;

					b.BackColor = r.set ? Color.FromArgb(37, 37, 38) : Color.FromArgb(15, 15, 15);
				}
			}
		}

		void ToggleFilter(string toggle)
		{
			Button b = null;
			string toggleName = "";

			foreach(Control c in panelScroll.Controls)
			{
				toggleName = c.Name.Replace("button", "");

				if(toggle == toggleName)
				{
					b = (Button)c;
					Console.WriteLine("found toggle " + toggle + " > " + b.Name);
					
					break;
				}
			}

			if(b == null)
			{
				Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<No Suitable Object Found!");
				return;
			}

			foreach(RecipeToggle r in buttonToggles)
			{
				if(r.name == toggleName)
				{
					Console.WriteLine("Toggling OBject: " + r.name + " > " + b.Name + " > " + toggleName);

					r.set = !r.set;

					b.BackColor = r.set ? Color.FromArgb(37, 37, 38) : Color.FromArgb(15, 15, 15);
					break;
				}
			}
		}

		void RefocusControls()
		{ 
			buttonFocusStealer.Focus();
		}

		#region Filter Buttons
		private void buttonHealth_Click(object sender, EventArgs e)
		{
			RefocusControls();
			ToggleFilter(sender);
		}

		private void buttonOldFavourites_Click(object sender, EventArgs e)
		{
			RefocusControls();
			ToggleFilter(sender);
		}

		private void buttonQuickAndEasy_Click(object sender, EventArgs e)
		{
			RefocusControls();
			ToggleFilter(sender);
		}

		private void buttonBreakfast_Click(object sender, EventArgs e)
		{
			RefocusControls();
			ToggleFilter(sender);
		}

		private void buttonSharingWithFriends_Click(object sender, EventArgs e)
		{
			RefocusControls();
			ToggleFilter(sender);
		}
		#endregion

		private void buttonAddRecipe_Click(object sender, EventArgs e)
		{
			RefocusControls();
		}
	}
}