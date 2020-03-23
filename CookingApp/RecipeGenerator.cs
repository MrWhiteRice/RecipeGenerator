using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingApp
{
	public partial class RecipeGenerator : Form
	{
		Random random;

		Image missing;
		int lastRecipe = -1;

		public RecipeGenerator()
		{
			InitializeComponent();

			//set up random seed
			random = new Random(DateTime.Now.Hour * DateTime.Now.Second * DateTime.Now.Minute);
			missing = Image.FromFile("Images/Missing.png");

			NewRecipe();
		}

		void NewRecipe()
		{
			//get a random item
			int select = random.Next(0, Window.window.recipes.Count);

			//cycle all filters
			bool none = true;
			bool found = false;
			foreach(RecipeToggle r in Window.window.buttonToggles)
			{
				if(r.set)
				{
					none = false;

					//check if the filter matches out recipe
					if(r.name == Window.window.recipes[select].type.ToString())
					{
						Console.WriteLine("match" + r.name + "|" + Window.window.recipes[select].type.ToString());
						if(r.set)
						{
							Console.WriteLine(lastRecipe + " : " + select + " : " + r.name + " : " + r.set + " : " + Window.window.recipes[select].name);
							found = true;
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

			if(!found && !none || lastRecipe == select)
			{
				NewRecipe();
				return;
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

			//load image
			Image loaded;
			try
			{
				loaded = Image.FromFile("Images/" + Window.window.recipes[select].name + ".png");
			}
			catch
			{
				loaded = missing;
			}

			//try set image
			recipeImage.Image = loaded;

			//set recipe information 
			//TODO: Turn into array
			labelFoodName.Text = Window.window.recipes[select].name;
			recipeText.Text = Window.window.recipes[select].name + "\nPG: " + Window.window.recipes[select].page + "\nType: " + Window.window.recipes[select].type.ToString();
			descriptionText.Text = Window.window.recipes[select].method[0];

			//remember selection
			lastRecipe = select;
		}

		private void buttonMethod_Click(object sender, EventArgs e)
		{
			if(lastRecipe != -1)
			{
				descriptionText.Text = Window.window.recipes[lastRecipe].method[0];
			}
		}

		private void buttonIngredients_Click(object sender, EventArgs e)
		{
			if(lastRecipe != -1)
			{
				descriptionText.Text = Window.window.recipes[lastRecipe].ingredients[0];
			}
		}

		private void buttonRandomRecipe_Click(object sender, EventArgs e)
		{
			NewRecipe();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			
		}
	}
}
