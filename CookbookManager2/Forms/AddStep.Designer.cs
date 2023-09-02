namespace CookbookManager2.Forms
{
    partial class AddStep
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
            richTextBox1 = new RichTextBox();
            ContinueButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(363, 32);
            label1.TabIndex = 0;
            label1.Text = "Add a step";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 84);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(339, 154);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.Validating += richTextBox1_Validating;
            // 
            // ContinueButton
            // 
            ContinueButton.AutoSize = true;
            ContinueButton.Dock = DockStyle.Bottom;
            ContinueButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContinueButton.Location = new Point(0, 354);
            ContinueButton.Margin = new Padding(16);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.RightToLeft = RightToLeft.No;
            ContinueButton.Size = new Size(363, 31);
            ContinueButton.TabIndex = 3;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = true;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // AddStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 385);
            Controls.Add(ContinueButton);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "AddStep";
            Text = "AddStep";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Button ContinueButton;
    }
}