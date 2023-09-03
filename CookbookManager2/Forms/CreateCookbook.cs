using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookbookManager2.DataClasses;

namespace CookbookManager2.Forms
{
    public partial class CreateCookbook : Form
    {
        public Cookbook Cookbook { get; set; }
        public CreateCookbook()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            Cookbook = new Cookbook(Guid.NewGuid(), CookbookNameTextBox.Text, CookbookDescriptionTextBox.Text);

            var result = await Controllers.CookbookController.CreateCookbook(Cookbook);

            if (result != null)
            {
                DialogResult = DialogResult.OK;

                Close();
            } else
            {
                DialogResult = DialogResult.Abort;
                Close();
            }


        }
    }
}
