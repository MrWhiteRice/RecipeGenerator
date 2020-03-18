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
		int index = 1;
		List<Panel> panels = new List<Panel>();

		public AddRecipe()
		{
			InitializeComponent();
			InitList();
		}

		void InitList()
		{
			//controols.setchildindex(control, int);
			AddItem();
		}

		void AddItem()
		{
			Panel p = new Panel();
			p.Dock = DockStyle.Top;
			p.Height = 40;
			p.BackColor = Color.Red;

			TextBox t = new TextBox();
			t.Multiline = true;
			t.Dock = DockStyle.Fill;
			t.BackColor = Color.FromArgb(15, 15, 15);
			t.ForeColor = Color.FromArgb(241, 241, 241);
			t.BorderStyle = BorderStyle.None;
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

			panels.Add(p);
			this.panelMain.Controls.Add(p);
			panelMain.Controls.SetChildIndex(p, 1);
			
			index++;

			UpdateIndex();
		}

		void RemoveItem(object sender, EventArgs e)
		{
			Button b = (Button)sender;

			int removeIndex = -1;
			for(int x = 0; x < panels.Count; x++)
			{
				if(panels[x] == b.Parent)
				{
					removeIndex = x;
					break;
				}
			}

			if(removeIndex != -1)
			panels.RemoveAt(removeIndex);

			b.Parent.Dispose();

			UpdateIndex();
		}

		void UpdateIndex()
		{
			Console.WriteLine(panels.Count);
			for(int x = 0; x < panels.Count; x++)
			{
				foreach(Control c in panels[x].Controls)
				{
					if(c.GetType() == typeof(Label) && c.Name == "Index")
					{
						Label l = (Label)c;
						l.Text = "" + (x + 1);
						break;
					}
				}

				if(panels.Count == 1)
				{
					if(x == 0)
					{
						foreach(Control c in panels[x].Controls)
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
					foreach(Control c in panels[x].Controls)
					{
						if(c.GetType() == typeof(Button) && c.Name == "RemoveItem")
						{
							c.Visible = true;
						}
					}
				}
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
			
		}

		private void buttonIngredients_Click(object sender, EventArgs e)
		{
			
		}

		private void panelMain_Paint(object sender, PaintEventArgs e)
		{

		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			AddItem();
		}
	}
}
