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

		public enum RecipeType
		{ 
			Breakfast,
			OldFavourites,
			QuickAndEasy,
			Healthy,
			SharingWithFriends
		}

		List<Recipe> recipes = new List<Recipe>();
		Random random;
		int lastRecipe = -1;
		Image missing;

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

		public Window()
		{
			//set up random seed
			random = new Random(DateTime.Now.Hour + DateTime.Now.Second);
			missing = Image.FromFile("Images/Missing.png");

			//set up window
			InitializeComponent();
			//set up recipes
			InitRecipes();
		}

		private void nextRecipe_Click(object sender, EventArgs e)
		{
			NewRecipe();
		}

		void NewRecipe()
		{
			//get a random item
			int select = random.Next(0, recipes.Count);

			//if none are checked
			if(!checkBoxBreakfast.Checked && !checkBoxOldFavourites.Checked && !checkBoxQuickAndEasy.Checked && !checkBoxHealthy.Checked && !checkBoxSharingWithFriends.Checked)
			{
				//set missing
				recipeText.Text = "Please check some filters!";

				//reset selection
				lastRecipe = -1;

				return;
			}

			//check if filtered recipe
			switch(recipes[select].type)
			{
				case RecipeType.Breakfast:
					if(!checkBoxBreakfast.Checked)
					{
						NewRecipe();
						return;
					}
					break;
				case RecipeType.OldFavourites:
					if(!checkBoxOldFavourites.Checked)
					{
						NewRecipe();
						return;
					}
					break;
				case RecipeType.QuickAndEasy:
					if(!checkBoxQuickAndEasy.Checked)
					{
						NewRecipe();
						return;
					}
					break;
				case RecipeType.Healthy:
					if(!checkBoxHealthy.Checked)
					{
						NewRecipe();
						return;
					}
					break;
				case RecipeType.SharingWithFriends:
					if(!checkBoxSharingWithFriends.Checked)
					{
						NewRecipe();
						return;
					}
					break;
			}

			//this is to prevent the same item from being picked;
			if(lastRecipe == select)
			{
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

		//Ingredients Button Click
		private void button1_Click(object sender, EventArgs e)
		{
			if(lastRecipe != -1)
				descriptionText.Text = recipes[lastRecipe].ingredients;
		}

		//Method Button Click
		private void button2_Click(object sender, EventArgs e)
		{
			if(lastRecipe != -1)
				descriptionText.Text = recipes[lastRecipe].method;
		}
	}
}