namespace CookbookManager2
{
    partial class WelcomeScreen
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
            label1 = new Label();
            label2 = new Label();
            CookbookNameTextBox = new TextBox();
            button1 = new Button();
            CookbookDescriptionTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(470, 45);
            label1.Name = "label1";
            label1.Size = new Size(237, 65);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(343, 110);
            label2.Name = "label2";
            label2.Size = new Size(531, 32);
            label2.TabIndex = 1;
            label2.Text = "To get started, enter your first cookbook's name:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CookbookNameTextBox
            // 
            CookbookNameTextBox.BackColor = Color.White;
            CookbookNameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CookbookNameTextBox.Location = new Point(343, 180);
            CookbookNameTextBox.Name = "CookbookNameTextBox";
            CookbookNameTextBox.PlaceholderText = "Your first cookbook";
            CookbookNameTextBox.Size = new Size(531, 33);
            CookbookNameTextBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1004, 301);
            button1.Name = "button1";
            button1.Size = new Size(179, 32);
            button1.TabIndex = 3;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CookbookDescriptionTextBox
            // 
            CookbookDescriptionTextBox.BackColor = Color.White;
            CookbookDescriptionTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CookbookDescriptionTextBox.Location = new Point(343, 242);
            CookbookDescriptionTextBox.Name = "CookbookDescriptionTextBox";
            CookbookDescriptionTextBox.PlaceholderText = "Cookbook Description";
            CookbookDescriptionTextBox.Size = new Size(531, 33);
            CookbookDescriptionTextBox.TabIndex = 4;
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 396);
            Controls.Add(CookbookDescriptionTextBox);
            Controls.Add(button1);
            Controls.Add(CookbookNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WelcomeScreen";
            Text = "WelcomeScreen";
            Load += WelcomeScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CookbookNameTextBox;
        private Button button1;
        private TextBox CookbookDescriptionTextBox;
    }
}