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
	public partial class AddRecipe : Form
	{
		List<Panel> items = new List<Panel>();

		List<string> methods = new List<string>();
		List<string> ingredients = new List<string>();

		enum Toggle
		{ 
			Method,
			Ingredient
		}
		Toggle current;

		int index = 1;

		public AddRecipe()
		{
			InitializeComponent();

			//set list type
			SetToggle(Toggle.Method);

			//add first item
			GenerateItem();

			//init item in other list
			ingredients.Add("");
		}

		void SetToggle(Toggle set)
		{
			//reset index
			index = 1;

			//set toggle
			current = set;

			//update colour of toggle
			buttonMethod.BackColor = current == Toggle.Method ? Color.FromArgb(37, 37, 38) : Color.FromArgb(15, 15, 15);
			buttonIngredients.BackColor = current == Toggle.Ingredient ? Color.FromArgb(37, 37, 38) : Color.FromArgb(15, 15, 15);

			//clear the list
			foreach(Panel p in items)
			{
				p.Dispose();
			}
			items.Clear();

			//generate new list
			foreach(string s in current == Toggle.Method ? methods : ingredients)
			{
				items.Add(AddItem(s));
			}

			UpdateIndex();
		}

		//adds a tile with the text 'info' attached to it
		Panel AddItem(string info)
		{
			Panel p = new Panel();
			p.Name = index.ToString();
			p.Dock = DockStyle.Top;
			p.Height = 40;
			p.BackColor = Color.Red;

			TextBox t = new TextBox();
			t.Name = "TextBox";
			t.Multiline = true;
			t.Text = info;
			t.Dock = DockStyle.Fill;
			t.BackColor = Color.FromArgb(15, 15, 15);
			t.ForeColor = Color.FromArgb(241, 241, 241);
			t.BorderStyle = BorderStyle.None;
			t.TextChanged += new EventHandler(UpdateText);
			p.Controls.Add(t);

			Label l = new Label();
			l.Name = "Index";
			l.Size = new Size(30, 40);
			l.BackColor = Color.DimGray;
			l.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
			l.TextAlign = ContentAlignment.MiddleCenter;
			l.Text = index.ToString();
			l.Dock = DockStyle.Left;
			p.Controls.Add(l);

			Button b = new Button();
			b.Name = "RemoveItem";
			b.Dock = DockStyle.Right;
			b.Text = "-";
			b.FlatStyle = FlatStyle.Flat;
			b.FlatAppearance.BorderSize = 0;
			b.BackColor = Color.DimGray;
			b.ForeColor = Color.FromArgb(15, 15, 15);
			b.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
			b.Size = new Size(35, 4);
			b.Click += new EventHandler(RemoveItem);
			p.Controls.Add(b);

			//items.Add(p);
			panelMain.Controls.Add(p);
			panelMain.Controls.SetChildIndex(p, 1);

			index++;

			//UpdateIndex();

			return p;
		}

		void RemoveItem(object sender, EventArgs e)
		{
			Button b = (Button)sender;

			//finds an object match
			int removeIndex = -1;
			for(int x = 0; x < items.Count; x++)
			{
				if(items[x] == b.Parent)
				{
					removeIndex = x;
					break;
				}
			}
			
			//if we find a match remove the item from the list and destroy
			if(removeIndex != -1)
			{
				items.RemoveAt(removeIndex);
				if(current == Toggle.Method) methods.RemoveAt(removeIndex); else ingredients.RemoveAt(removeIndex);
				b.Parent.Dispose();
				UpdateIndex();
			}
		}

		void UpdateIndex()
		{
			for(int x = 0; x < items.Count; x++)
			{
				foreach(Control c in items[x].Controls)
				{
					if(c.GetType() == typeof(Label) && c.Name == "Index")
					{
						Label l = (Label)c;
						l.Text = "" + (x + 1);
						break;
					}
				}

				if(items.Count == 1)
				{
					if(x == 0)
					{
						foreach(Control c in items[x].Controls)
						{
							if(c.GetType() == typeof(Button) && c.Name == "RemoveItem")
							{
								c.Visible = false;
								break;
							}
						}
					}
				}
				else
				{
					foreach(Control c in items[x].Controls)
					{
						if(c.GetType() == typeof(Button) && c.Name == "RemoveItem")
						{
							c.Visible = true;
						}
					}
				}
			}
		}

		void UpdateText(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;

			for(int x = 0; x < items.Count; x++)
			{
				foreach(Control c in items[x].Controls)
				{
					if(c == t)
					{
						List<string> useList = current == Toggle.Method ? methods : ingredients;
						useList[x] = t.Text;
						return;
					}
				}
			}
		}
		
		void GenerateItem()
		{
			//add panel
			items.Add(AddItem(""));

			//add item to string list
			List<string> useList = current == Toggle.Method ? methods : ingredients;
			useList.Add("");

			//update index
			UpdateIndex();
		}

		void ToggleButton(object sender)
		{
			Button b = (Button)sender;

			if(b.Name == "buttonMethod")
			{
				SetToggle(Toggle.Method);
			}

			if(b.Name == "buttonIngredients")
			{
				SetToggle(Toggle.Ingredient);
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonSaveRecipe_Click(object sender, EventArgs e)
		{
			//Add Recipe
			Close();
		}

		private void buttonMethod_Click(object sender, EventArgs e)
		{
			ToggleButton(sender);
		}

		private void buttonIngredients_Click(object sender, EventArgs e)
		{
			ToggleButton(sender);
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			GenerateItem();
		}
	}
}