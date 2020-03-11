using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingApp
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
}
