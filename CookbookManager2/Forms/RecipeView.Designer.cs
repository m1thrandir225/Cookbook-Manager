namespace CookbookManager2.Forms
{
    partial class RecipeView
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
            RecipeNameLabel = new Label();
            RecipePictureBox = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            IngredientsLabel = new Label();
            IngredientsListView = new ListView();
            IngredientName = new ColumnHeader();
            Quantity = new ColumnHeader();
            StepsLabel = new Label();
            StepsListView = new ListView();
            StepNumber = new ColumnHeader();
            Step = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // RecipeNameLabel
            // 
            RecipeNameLabel.AutoSize = true;
            RecipeNameLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            RecipeNameLabel.Location = new Point(27, 284);
            RecipeNameLabel.Name = "RecipeNameLabel";
            RecipeNameLabel.Size = new Size(206, 45);
            RecipeNameLabel.TabIndex = 0;
            RecipeNameLabel.Text = "RecipeName";
            // 
            // RecipePictureBox
            // 
            RecipePictureBox.Location = new Point(24, 32);
            RecipePictureBox.Margin = new Padding(0, 8, 0, 8);
            RecipePictureBox.Name = "RecipePictureBox";
            RecipePictureBox.Size = new Size(652, 244);
            RecipePictureBox.TabIndex = 1;
            RecipePictureBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(RecipePictureBox);
            flowLayoutPanel1.Controls.Add(RecipeNameLabel);
            flowLayoutPanel1.Controls.Add(IngredientsLabel);
            flowLayoutPanel1.Controls.Add(IngredientsListView);
            flowLayoutPanel1.Controls.Add(StepsLabel);
            flowLayoutPanel1.Controls.Add(StepsListView);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(24);
            flowLayoutPanel1.Size = new Size(693, 762);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // IngredientsLabel
            // 
            IngredientsLabel.AutoSize = true;
            IngredientsLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            IngredientsLabel.Location = new Point(32, 337);
            IngredientsLabel.Margin = new Padding(8);
            IngredientsLabel.Name = "IngredientsLabel";
            IngredientsLabel.Size = new Size(121, 30);
            IngredientsLabel.TabIndex = 2;
            IngredientsLabel.Text = "Ingredients";
            // 
            // IngredientsListView
            // 
            IngredientsListView.Columns.AddRange(new ColumnHeader[] { IngredientName, Quantity });
            IngredientsListView.Location = new Point(27, 378);
            IngredientsListView.MultiSelect = false;
            IngredientsListView.Name = "IngredientsListView";
            IngredientsListView.Size = new Size(649, 150);
            IngredientsListView.TabIndex = 3;
            IngredientsListView.UseCompatibleStateImageBehavior = false;
            IngredientsListView.View = View.Details;
            // 
            // IngredientName
            // 
            IngredientName.Text = "Name";
            IngredientName.Width = 200;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.Width = 200;
            // 
            // StepsLabel
            // 
            StepsLabel.AutoSize = true;
            StepsLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            StepsLabel.Location = new Point(32, 539);
            StepsLabel.Margin = new Padding(8);
            StepsLabel.Name = "StepsLabel";
            StepsLabel.Size = new Size(64, 30);
            StepsLabel.TabIndex = 4;
            StepsLabel.Text = "Steps";
            // 
            // StepsListView
            // 
            StepsListView.Columns.AddRange(new ColumnHeader[] { StepNumber, Step });
            StepsListView.Location = new Point(24, 585);
            StepsListView.Margin = new Padding(0, 8, 0, 8);
            StepsListView.Name = "StepsListView";
            StepsListView.Size = new Size(649, 150);
            StepsListView.TabIndex = 5;
            StepsListView.UseCompatibleStateImageBehavior = false;
            StepsListView.View = View.Details;
            // 
            // StepNumber
            // 
            StepNumber.Text = "No.";
            StepNumber.Width = 200;
            // 
            // Step
            // 
            Step.Text = "Step";
            Step.Width = 200;
            // 
            // RecipeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 762);
            Controls.Add(flowLayoutPanel1);
            Name = "RecipeView";
            Text = "RecipeView";
            Load += RecipeView_Load;
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label RecipeNameLabel;
        private PictureBox RecipePictureBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label IngredientsLabel;
        private ListView IngredientsListView;
        private Label StepsLabel;
        private ListView StepsListView;
        private ColumnHeader IngredientName;
        private ColumnHeader Quantity;
        private ColumnHeader StepNumber;
        private ColumnHeader Step;
    }
}