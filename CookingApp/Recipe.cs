namespace CookingApp
{
	public class Recipe
	{
		public string name { get; set; }
		public int page { get; set; }
		public RecipeType type { get; set; }
		public string[] ingredients { get; set; }
		public string[] method { get; set; }

		public Recipe() 
		{

		}

		public Recipe(int Page, RecipeType RecipeType, string Name, string[] Ingredients, string[] Method)
		{
			name = Name;
			page = Page;
			type = RecipeType;
			ingredients = Ingredients;
			method = Method;
		}
	}
}