using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingApp
{
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
}
