﻿namespace CookbookManager2.Forms
{
    partial class CreateRecipe
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
            RecipeNameTextBox = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            RemoveIngredient = new Button();
            IngredientsListView = new ListView();
            IngredientName = new ColumnHeader();
            Quantity = new ColumnHeader();
            CancelButton = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            SaveButton = new Button();
            label3 = new Label();
            AddStepButton = new Button();
            RemoveStepButton = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            StepsListView = new ListView();
            StepNumberHeader = new ColumnHeader();
            StepHeader = new ColumnHeader();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 0;
            label1.Text = "Create A New Recipe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 3);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(121, 30);
            label2.TabIndex = 1;
            label2.Text = "Ingredients";
            label2.Click += label2_Click;
            // 
            // RecipeNameTextBox
            // 
            RecipeNameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RecipeNameTextBox.Location = new Point(27, 72);
            RecipeNameTextBox.Margin = new Padding(3, 16, 3, 16);
            RecipeNameTextBox.Name = "RecipeNameTextBox";
            RecipeNameTextBox.PlaceholderText = "Recipe Name";
            RecipeNameTextBox.Size = new Size(251, 35);
            RecipeNameTextBox.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(RecipeNameTextBox);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(24);
            flowLayoutPanel1.Size = new Size(907, 147);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(RemoveIngredient);
            flowLayoutPanel2.Location = new Point(27, 153);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(24, 0, 0, 0);
            flowLayoutPanel2.Size = new Size(430, 42);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(159, 8);
            button1.Margin = new Padding(8);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 2;
            button1.Text = "Add Ingredient";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RemoveIngredient
            // 
            RemoveIngredient.Location = new Point(281, 8);
            RemoveIngredient.Margin = new Padding(8);
            RemoveIngredient.Name = "RemoveIngredient";
            RemoveIngredient.Size = new Size(136, 23);
            RemoveIngredient.TabIndex = 3;
            RemoveIngredient.Text = "Remove Ingredient";
            RemoveIngredient.UseVisualStyleBackColor = true;
            RemoveIngredient.Click += button2_Click;
            // 
            // IngredientsListView
            // 
            IngredientsListView.Columns.AddRange(new ColumnHeader[] { IngredientName, Quantity });
            IngredientsListView.Location = new Point(27, 201);
            IngredientsListView.Margin = new Padding(24, 3, 3, 3);
            IngredientsListView.Name = "IngredientsListView";
            IngredientsListView.Size = new Size(417, 237);
            IngredientsListView.TabIndex = 7;
            IngredientsListView.UseCompatibleStateImageBehavior = false;
            IngredientsListView.View = View.Details;
            // 
            // IngredientName
            // 
            IngredientName.Text = "Ingredient Name";
            IngredientName.Width = 150;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.Width = 150;
            // 
            // CancelButton
            // 
            CancelButton.AutoSize = true;
            CancelButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.Location = new Point(7, 7);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(157, 35);
            CancelButton.TabIndex = 8;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(CancelButton);
            flowLayoutPanel3.Controls.Add(SaveButton);
            flowLayoutPanel3.Location = new Point(564, 480);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(4);
            flowLayoutPanel3.Size = new Size(339, 48);
            flowLayoutPanel3.TabIndex = 9;
            // 
            // SaveButton
            // 
            SaveButton.AutoSize = true;
            SaveButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Location = new Point(170, 7);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(157, 35);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 3);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(64, 30);
            label3.TabIndex = 1;
            label3.Text = "Steps";
            // 
            // AddStepButton
            // 
            AddStepButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddStepButton.Location = new Point(102, 8);
            AddStepButton.Margin = new Padding(8);
            AddStepButton.Name = "AddStepButton";
            AddStepButton.Size = new Size(106, 23);
            AddStepButton.TabIndex = 2;
            AddStepButton.Text = "Add Step";
            AddStepButton.UseVisualStyleBackColor = true;
            AddStepButton.Click += AddStepButton_Click;
            // 
            // RemoveStepButton
            // 
            RemoveStepButton.Location = new Point(224, 8);
            RemoveStepButton.Margin = new Padding(8);
            RemoveStepButton.Name = "RemoveStepButton";
            RemoveStepButton.Size = new Size(136, 23);
            RemoveStepButton.TabIndex = 3;
            RemoveStepButton.Text = "Remove Step";
            RemoveStepButton.UseVisualStyleBackColor = true;
            RemoveStepButton.Click += RemoveStepButton_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label3);
            flowLayoutPanel4.Controls.Add(AddStepButton);
            flowLayoutPanel4.Controls.Add(RemoveStepButton);
            flowLayoutPanel4.Location = new Point(537, 153);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(24, 0, 0, 0);
            flowLayoutPanel4.Size = new Size(430, 42);
            flowLayoutPanel4.TabIndex = 10;
            // 
            // StepsListView
            // 
            StepsListView.Columns.AddRange(new ColumnHeader[] { StepNumberHeader, StepHeader });
            StepsListView.Location = new Point(564, 201);
            StepsListView.Margin = new Padding(24, 3, 3, 3);
            StepsListView.Name = "StepsListView";
            StepsListView.Size = new Size(333, 237);
            StepsListView.TabIndex = 11;
            StepsListView.UseCompatibleStateImageBehavior = false;
            StepsListView.View = View.Details;
            // 
            // StepNumberHeader
            // 
            StepNumberHeader.Text = "No.";
            StepNumberHeader.Width = 150;
            // 
            // StepHeader
            // 
            StepHeader.Text = "Step";
            // 
            // CreateRecipe
            // 
            AcceptButton = SaveButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelButton;
            ClientSize = new Size(907, 540);
            Controls.Add(StepsListView);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(IngredientsListView);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "CreateRecipe";
            Text = "Create Recipe";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox RecipeNameTextBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button RemoveIngredient;
        private ListView IngredientsListView;
        private Button CancelButton;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button SaveButton;
        private ColumnHeader IngredientName;
        private ColumnHeader Quantity;
        private Label label3;
        private Button AddStepButton;
        private Button RemoveStepButton;
        private FlowLayoutPanel flowLayoutPanel4;
        private ListView StepsListView;
        private ColumnHeader StepNumberHeader;
        private ColumnHeader StepHeader;
    }
}