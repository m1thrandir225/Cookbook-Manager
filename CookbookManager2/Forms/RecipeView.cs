using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookbookManager2.Forms
{
    public partial class RecipeView : Form
    {
        public Recipe Recipe { get; set; }

        public RecipeView(Recipe _recipe)

        {
            Recipe = _recipe;
            InitializeComponent();


        }

        private void RecipeView_Load(object sender, EventArgs e)
        {
            this.Text = Recipe.Name;
            RecipeNameLabel.Text = Recipe.Name;

            RecipePictureBox.ImageLocation = Recipe.Image;
            RecipePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            foreach (var ingredient in Recipe.Ingredients)
            {
                IngredientsListView.Items.Add(new ListViewItem(new string[] { ingredient.Name, ingredient.Quantity.ToString() }));
            }

            foreach (var step in Recipe.Steps)
            {
                StepsListView.Items.Add(new ListViewItem(new string[] { (Recipe.Steps.IndexOf(step) + 1).ToString(), step }));
            }
        }
    }
}
