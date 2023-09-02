using CookbookManager2.DataClasses;
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

    public partial class CreateRecipe : Form
    {
        public List<Ingredient> ingredients = new();
        public List<string> steps = new();
        public String recipeName = "";
        public String recipeDescription = "";

        ErrorProvider errorProvider = new();
        public CreateRecipe()
        {

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddIngredient newIngredientForm = new();

            var result = newIngredientForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                ingredients.Add(newIngredientForm.NewIngredient);
            }

            IngredientsListView.Items.Add(new ListViewItem(new string[] { newIngredientForm.NewIngredient.Name, newIngredientForm.NewIngredient.Quantity.ToString() }));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IngredientsListView.Items.Count == 0)
            {
                return;
            }

            var lastItem = IngredientsListView.Items.Count - 1;

            ingredients.RemoveAt(lastItem);

            IngredientsListView.Items.RemoveAt(lastItem);
        }

        private void AddStepButton_Click(object sender, EventArgs e)
        {
            AddStep newStepForm = new();

            var result = newStepForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                newStepForm.Close();
                steps.Add(newStepForm.NewStep);
                StepsListView.Items.Add(new ListViewItem(new string[] { (StepsListView.Items.Count + 1).ToString(), newStepForm.NewStep }));
            }

        }

        private void RemoveStepButton_Click(object sender, EventArgs e)
        {
            if (StepsListView.Items.Count == 0)
            {
                return;
            }

            var lastItem = StepsListView.Items.Count - 1;

            steps.RemoveAt(lastItem);

            StepsListView.Items.RemoveAt(lastItem);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ingredients.Count == 0)
            {
                errorProvider.SetError(IngredientsListView, "Please add at least one ingredient");
                return;
            }

            if (steps.Count == 0)
            {
                errorProvider.SetError(StepsListView, "Please add at least one step");
                return;
            }

            if (string.IsNullOrWhiteSpace(RecipeNameTextBox.Text))
            {
                errorProvider.SetError(RecipeNameTextBox, "Please enter a valid recipe name");
                return;
            }

            recipeName = RecipeNameTextBox.Text;

            

            DialogResult = DialogResult.OK;

            Close();

        }
    }
}
