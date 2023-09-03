namespace CookbookManager2.Forms
{
    partial class AddIngredient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIngredient));
            ContinueButton = new Button();
            IngredientNameTextBox = new TextBox();
            label1 = new Label();
            QuantityTextBox = new TextBox();
            SuspendLayout();
            // 
            // ContinueButton
            // 
            ContinueButton.AutoSize = true;
            ContinueButton.Dock = DockStyle.Bottom;
            ContinueButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ContinueButton.Location = new Point(0, 299);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(373, 40);
            ContinueButton.TabIndex = 0;
            ContinueButton.Text = "Add";
            ContinueButton.UseVisualStyleBackColor = true;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // IngredientNameTextBox
            // 
            IngredientNameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            IngredientNameTextBox.Location = new Point(12, 118);
            IngredientNameTextBox.Name = "IngredientNameTextBox";
            IngredientNameTextBox.PlaceholderText = "Ingredient Name";
            IngredientNameTextBox.Size = new Size(349, 35);
            IngredientNameTextBox.TabIndex = 1;
            IngredientNameTextBox.Validating += IngredientNameTextBox_Validating;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(373, 37);
            label1.TabIndex = 2;
            label1.Text = "Add Ingredient";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityTextBox.Location = new Point(12, 173);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.PlaceholderText = "Quantity";
            QuantityTextBox.Size = new Size(349, 35);
            QuantityTextBox.TabIndex = 3;
            QuantityTextBox.Validating += QuantityTextBox_Validating;
            // 
            // AddIngredient
            // 
            AcceptButton = ContinueButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(373, 339);
            Controls.Add(QuantityTextBox);
            Controls.Add(label1);
            Controls.Add(IngredientNameTextBox);
            Controls.Add(ContinueButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddIngredient";
            Text = "Add an ingredient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ContinueButton;
        private TextBox IngredientNameTextBox;
        private Label label1;
        private TextBox QuantityTextBox;
    }
}