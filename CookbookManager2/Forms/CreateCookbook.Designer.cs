namespace CookbookManager2.Forms
{
    partial class CreateCookbook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CookbookNameTextBox = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            CookbookDescriptionTextBox = new TextBox();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // CookbookNameTextBox
            // 
            CookbookNameTextBox.BackColor = Color.White;
            CookbookNameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CookbookNameTextBox.Location = new Point(16, 16);
            CookbookNameTextBox.Margin = new Padding(16);
            CookbookNameTextBox.Name = "CookbookNameTextBox";
            CookbookNameTextBox.PlaceholderText = "Cookbook Name";
            CookbookNameTextBox.Size = new Size(496, 33);
            CookbookNameTextBox.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(CookbookNameTextBox);
            flowLayoutPanel1.Controls.Add(CookbookDescriptionTextBox);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(537, 182);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // CookbookDescriptionTextBox
            // 
            CookbookDescriptionTextBox.BackColor = Color.White;
            CookbookDescriptionTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CookbookDescriptionTextBox.Location = new Point(16, 81);
            CookbookDescriptionTextBox.Margin = new Padding(16);
            CookbookDescriptionTextBox.Name = "CookbookDescriptionTextBox";
            CookbookDescriptionTextBox.PlaceholderText = "Cookbook Description";
            CookbookDescriptionTextBox.Size = new Size(496, 33);
            CookbookDescriptionTextBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(8, 138);
            button1.Margin = new Padding(8);
            button1.Name = "button1";
            button1.Size = new Size(522, 25);
            button1.TabIndex = 5;
            button1.Text = "Create Cookbook";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CreateCookbook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 182);
            Controls.Add(flowLayoutPanel1);
            Name = "CreateCookbook";
            Text = "Create a new cookbook";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox CookbookNameTextBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox CookbookDescriptionTextBox;
        private Button button1;
    }
}