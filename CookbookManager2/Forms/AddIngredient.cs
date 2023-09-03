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
    public partial class AddIngredient : Form
    {
        public Ingredient NewIngredient { get; set; }
        public ErrorProvider error = new ErrorProvider();
        public AddIngredient()

        {
            NewIngredient = new Ingredient();
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            if(string.IsNullOrWhiteSpace(IngredientNameTextBox.Text))
            {
                error.SetError(IngredientNameTextBox, "Please enter a valid ingredient name");
                return;

            }

            if(string.IsNullOrWhiteSpace(QuantityTextBox.Text))
            {
                error.SetError(QuantityTextBox, "Please enter a valid quantity");
                return;
            }

            NewIngredient = new Ingredient(_name: IngredientNameTextBox.Text, _quantity: QuantityTextBox.Text);

            DialogResult = DialogResult.OK;

            Close();

        }

        private void IngredientNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IngredientNameTextBox.Text))
            {
                IngredientNameTextBox.Focus();

                error.SetError(IngredientNameTextBox, "Please enter a valid ingredient name");

            }

        }

        private void QuantityTextBox_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(QuantityTextBox.Text))
            {
                QuantityTextBox.Focus();
                error.SetError(QuantityTextBox, "Please enter a valid quantity");

            }

        }
    }
}
