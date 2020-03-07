using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingApp
{
	public partial class Window : Form
	{
		public class Recipe
		{
			public string name;
			public int page;
			public RecipeType type;
			public string ingredients;
			public string method;

			public Recipe(int Page, RecipeType RecipeType, string Name, string Ingredients, string Method)
			{
				name = Name;
				page = Page;
				type = RecipeType;
				ingredients = Ingredients;
				method = Method;
			}
		}

		public class RecipeToggle
		{
			public string name;
			public bool set;

			public RecipeToggle(string Name)
			{
				name = Name;
			}
			public RecipeToggle(string Name, bool Set)
			{
				name = Name;
				set = Set;
			}
		}

		public enum RecipeType
		{
			Breakfast,
			OldFavourites,
			QuickAndEasy,
			Healthy,
			SharingWithFriends
		}

		List<Recipe> recipes = new List<Recipe>();
		List<RecipeToggle> buttonToggles = new List<RecipeToggle>();

		Random random;
		
		Image missing;
		int lastRecipe = -1;
		Form activeSubForm = null;

		public Window()
		{
			//set up random seed
			random = new Random(DateTime.Now.Hour * DateTime.Now.Second * DateTime.Now.Minute);
			missing = Image.FromFile("Images/Missing.png");

			//set up window
			InitializeComponent();

			//Init Bool matrix
			InitBoolMatrix();

			//set up recipes
			InitRecipes();
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

		void NewRecipe()
		{
			//get a random item
			int select = random.Next(0, recipes.Count);

			//cycle all filters
			bool none = true;
			foreach(RecipeToggle r in buttonToggles)
			{
				if(r.set)
				{
					none = false;

					//check if the filter matches out recipe
					if(r.name == recipes[select].type.ToString())
					{
						if(r.set)
						{
							Console.WriteLine(lastRecipe + " : " + select + " : " + r.name + " : " + r.set + " : " + recipes[select].name);
							none = false;
							break;
						}
						else
						{
							NewRecipe();
							return;
						}
					}
				}
			}

			//if no filters were active
			if(none)
			{
				Console.WriteLine("No filters found!");

				//set missing
				recipeText.Text = "Nothing filters found! Please check some filters!";

				//reset selection
				lastRecipe = -1;

				return;
			}

			//this is to prevent the same item from being picked;
			if(lastRecipe == select)
			{
				Console.WriteLine("Same recipe! Getting a new one!" + lastRecipe + "/" + select);

				NewRecipe();
				return;
			}

			//load image
			Image loaded;
			try
			{
				loaded = Image.FromFile("Images/" + recipes[select].name + ".png");
			}
			catch
			{
				loaded = missing;
			}

			//try set image
			recipeImage.Image = loaded;

			//set recipe information
			recipeText.Text = recipes[select].name + "\nPG: " + recipes[select].page + "\nType: " + recipes[select].type.ToString();
			descriptionText.Text = recipes[select].ingredients;

			//remember selection
			lastRecipe = select;
		}

		void OpenSubMenu(Form form)
		{
			if(activeSubForm != null)
			{
				activeSubForm.Close();
			}

			activeSubForm = form;
		}

		//New Recipe Button
		private void button1_Click_1(object sender, EventArgs e)
		{
			Console.WriteLine("|||||||||||||||||||||||");
			NewRecipe();
		}

		//Ingredients Button
		private void button5_Click(object sender, EventArgs e)
		{
			if(lastRecipe != -1)
				descriptionText.Text = recipes[lastRecipe].ingredients;
		}

		//Method Button Click
		private void button4_Click(object sender, EventArgs e)
		{
			if(lastRecipe != -1)
				descriptionText.Text = recipes[lastRecipe].method;
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

		#region Filter Buttons
		private void buttonHealth_Click(object sender, EventArgs e)
		{
			ToggleFilter(sender);
		}

		private void buttonOldFavourites_Click(object sender, EventArgs e)
		{
			ToggleFilter(sender);
		}

		private void buttonQuickAndEasy_Click(object sender, EventArgs e)
		{
			ToggleFilter(sender);
		}

		private void buttonBreakfast_Click(object sender, EventArgs e)
		{
			ToggleFilter(sender);
		}

		private void buttonSharingWithFriends_Click(object sender, EventArgs e)
		{
			ToggleFilter(sender);
		}
		#endregion

	}
}