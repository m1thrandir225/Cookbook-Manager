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
            QuantityTextBox_Validating(sender, new CancelEventArgs());

            float quantity = 0;

            if (QuantityTextBox.Text != "")
            {
                quantity = float.Parse(QuantityTextBox.Text);
            }

            NewIngredient = new Ingredient(_name: IngredientNameTextBox.Text, _quantity: quantity);
            
            DialogResult = DialogResult.OK;

            Close();

        }

        private void IngredientNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IngredientNameTextBox.Text))
            {
                IngredientNameTextBox.Focus();

                error.SetError(IngredientNameTextBox, "Please enter a valid ingredient name");

                e.Cancel = false;
            }
            else
            {
                error.SetError(IngredientNameTextBox, "");

                e.Cancel = true;
            }

        }

        private void QuantityTextBox_Validating(object sender, CancelEventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(QuantityTextBox.Text))
            {
                QuantityTextBox.Focus();
                error.SetError(QuantityTextBox, "Please enter a valid quantity");

                e.Cancel = false;
            }
            else
            {
                error.SetError(QuantityTextBox, "");

                e.Cancel = true;
            }

            
        }
    }
}
