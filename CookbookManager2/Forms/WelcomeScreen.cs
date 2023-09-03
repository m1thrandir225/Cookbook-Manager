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

namespace CookbookManager2
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();


        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {


            Cookbook cookbook = new Cookbook(Guid.NewGuid(), CookbookNameTextBox.Text, CookbookDescriptionTextBox.Text);

            var result = await Controllers.CookbookController.CreateCookbook(cookbook);

            if(result == null)
            {
                MessageBox.Show("Error creating cookbook");
                return;
            }



            List<Cookbook> cookbooks = new List<Cookbook>
            {
                cookbook
            };

            MainWindow mainWindow = new MainWindow(cookbooks);

            mainWindow.Show();

            Hide();
        }
    }
}
