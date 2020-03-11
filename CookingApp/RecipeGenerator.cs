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
		public RecipeGenerator()
		{
			InitializeComponent();
		}

		void RefocusControls()
		{
			buttonFocusStealer2.Focus();
		}

		private void buttonMethod_Click(object sender, EventArgs e)
		{
			RefocusControls();
		}

		private void buttonRandomRecipe_Click(object sender, EventArgs e)
		{
			RefocusControls();
		}

		private void buttonIngredients_Click(object sender, EventArgs e)
		{
			RefocusControls();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			RefocusControls();
		}

		private void buttonAddRecipe_Click(object sender, EventArgs e)
		{
			RefocusControls();

		}
	}
}
