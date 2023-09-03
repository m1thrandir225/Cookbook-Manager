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
        public String recipeImage = "";

        ErrorProvider errorProvider = new();


        public CreateRecipe()
        {

            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddIngredient newIngredientForm = new();

            var result = newIngredientForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                ingredients.Add(newIngredientForm.NewIngredient);
                IngredientsListView.Items.Add(new ListViewItem(new string[] { newIngredientForm.NewIngredient.Name, newIngredientForm.NewIngredient.Quantity.ToString() }));

            }
            else
            {
                newIngredientForm.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IngredientsListView.Items.Count == 0)
            {
                errorProvider.SetError(IngredientsListView, "Please add at least one ingredient");
                return;
            }

            if (IngredientsListView.SelectedItems.Count > 0)
            {
                ingredients.RemoveAt(IngredientsListView.SelectedItems[0].Index);
                IngredientsListView.Items.RemoveAt(IngredientsListView.SelectedItems[0].Index);
            }
            else
            {
                var lastItem = IngredientsListView.Items.Count - 1;

                ingredients.RemoveAt(lastItem);

                IngredientsListView.Items.RemoveAt(lastItem);
            }
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
                errorProvider.SetError(StepsListView, "Please add at least one step");
                return;
            }

            if (StepsListView.SelectedItems.Count > 0)
            {
                steps.RemoveAt(StepsListView.SelectedItems[0].Index);
                StepsListView.Items.RemoveAt(StepsListView.SelectedItems[0].Index);
            }
            else
            {
                var lastItem = StepsListView.Items.Count - 1;

                steps.RemoveAt(lastItem);

                StepsListView.Items.RemoveAt(lastItem);
            }


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

            if (string.IsNullOrEmpty(recipeImage))
            {
                errorProvider.SetError(AddImageButton, "Please add a recipe image");

                return;
            }

            recipeName = RecipeNameTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();

        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            Thread t = new Thread((ThreadStart)(() =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RecipePictureBox.Image = new Bitmap(openFileDialog.FileName);

                    recipeImage = openFileDialog.FileName;
                }
            }));

            t.SetApartmentState(ApartmentState.STA);

            t.Start();

            t.Join();

            RecipePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RecipePictureBox.Show();

            RecipePictureBox.Focus();


        }
    }
}
