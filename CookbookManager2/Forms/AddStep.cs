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
    public partial class AddStep : Form
    {
        public string NewStep { get; set; }
        public ErrorProvider error = new ErrorProvider();
        public AddStep()
        {
            NewStep = "";
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {

            NewStep = richTextBox1.Text.ToString();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void richTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                richTextBox1.Focus();

                error.SetError(richTextBox1, "Please enter a valid step");

                e.Cancel = true;
            }
            else
            {
                error.SetError(richTextBox1, "");

                e.Cancel = false;
            }
        }
    }
}
