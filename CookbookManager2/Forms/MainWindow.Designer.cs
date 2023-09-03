using CookbookManager2.DataClasses;

namespace CookbookManager2
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            createNewCookbookButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            splitContainer1 = new SplitContainer();
            CookbooksTreeView = new TreeView();
            RemoveRecipeButton = new Button();
            viewExplainerLabel = new Label();
            RecipesTitle = new Label();
            RecipeListView = new ListView();
            RecipeName = new ColumnHeader();
            NumberOfIngredients = new ColumnHeader();
            NumberOfSteps = new ColumnHeader();
            ImageName = new ColumnHeader();
            flowLayoutPanel1 = new FlowLayoutPanel();
            CookbookNameLabel = new Label();
            CookbookRecipesTotalLabel = new Label();
            CookbookDescription = new Label();
            AddRecipeToCookbookButton = new Button();
            DeleteCookbookButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // createNewCookbookButton
            // 
            createNewCookbookButton.Location = new Point(12, 501);
            createNewCookbookButton.Name = "createNewCookbookButton";
            createNewCookbookButton.Size = new Size(113, 23);
            createNewCookbookButton.TabIndex = 1;
            createNewCookbookButton.Text = "New Cookbook";
            createNewCookbookButton.UseVisualStyleBackColor = true;
            createNewCookbookButton.Click += CreateCookbookButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(CookbooksTreeView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(RemoveRecipeButton);
            splitContainer1.Panel2.Controls.Add(viewExplainerLabel);
            splitContainer1.Panel2.Controls.Add(RecipesTitle);
            splitContainer1.Panel2.Controls.Add(RecipeListView);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(AddRecipeToCookbookButton);
            splitContainer1.Size = new Size(1005, 483);
            splitContainer1.SplitterDistance = 335;
            splitContainer1.TabIndex = 2;
            // 
            // CookbooksTreeView
            // 
            CookbooksTreeView.Location = new Point(0, 0);
            CookbooksTreeView.Name = "CookbooksTreeView";
            CookbooksTreeView.Size = new Size(332, 483);
            CookbooksTreeView.TabIndex = 0;
            CookbooksTreeView.NodeMouseClick += CookbookTreeView_NodeMouseClick;
            // 
            // RemoveRecipeButton
            // 
            RemoveRecipeButton.AutoSize = true;
            RemoveRecipeButton.Enabled = false;
            RemoveRecipeButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveRecipeButton.Location = new Point(124, 202);
            RemoveRecipeButton.Name = "RemoveRecipeButton";
            RemoveRecipeButton.Size = new Size(122, 27);
            RemoveRecipeButton.TabIndex = 4;
            RemoveRecipeButton.Text = "Remove Recipe";
            RemoveRecipeButton.UseVisualStyleBackColor = true;
            RemoveRecipeButton.Visible = false;
            RemoveRecipeButton.Click += RemoveRecipeButton_Click;
            // 
            // viewExplainerLabel
            // 
            viewExplainerLabel.AutoSize = true;
            viewExplainerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            viewExplainerLabel.ForeColor = Color.DimGray;
            viewExplainerLabel.Location = new Point(499, 215);
            viewExplainerLabel.Name = "viewExplainerLabel";
            viewExplainerLabel.Size = new Size(164, 15);
            viewExplainerLabel.TabIndex = 3;
            viewExplainerLabel.Text = "* double click to view a recipe";
            viewExplainerLabel.Visible = false;
            // 
            // RecipesTitle
            // 
            RecipesTitle.AutoSize = true;
            RecipesTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RecipesTitle.Location = new Point(9, 167);
            RecipesTitle.Margin = new Padding(4, 16, 3, 0);
            RecipesTitle.Name = "RecipesTitle";
            RecipesTitle.Size = new Size(81, 25);
            RecipesTitle.TabIndex = 2;
            RecipesTitle.Text = "Recipes:";
            RecipesTitle.Visible = false;
            // 
            // RecipeListView
            // 
            RecipeListView.Columns.AddRange(new ColumnHeader[] { RecipeName, NumberOfIngredients, NumberOfSteps, ImageName });
            RecipeListView.Location = new Point(7, 235);
            RecipeListView.Name = "RecipeListView";
            RecipeListView.Size = new Size(656, 245);
            RecipeListView.TabIndex = 1;
            RecipeListView.UseCompatibleStateImageBehavior = false;
            RecipeListView.View = View.Details;
            RecipeListView.Visible = false;
            RecipeListView.MouseClick += RecipeListView_MouseClick;
            RecipeListView.MouseDoubleClick += RecipeListView_MouseDoubleClick;
            // 
            // RecipeName
            // 
            RecipeName.Text = "Name";
            RecipeName.Width = 160;
            // 
            // NumberOfIngredients
            // 
            NumberOfIngredients.Text = "No. Ingredients";
            NumberOfIngredients.Width = 120;
            // 
            // NumberOfSteps
            // 
            NumberOfSteps.Text = "No.Steps";
            NumberOfSteps.Width = 120;
            // 
            // ImageName
            // 
            ImageName.Text = "Image";
            ImageName.Width = 120;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.Controls.Add(CookbookNameLabel);
            flowLayoutPanel1.Controls.Add(CookbookRecipesTotalLabel);
            flowLayoutPanel1.Controls.Add(CookbookDescription);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(229, 145);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // CookbookNameLabel
            // 
            CookbookNameLabel.AutoSize = true;
            CookbookNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            CookbookNameLabel.Location = new Point(4, 8);
            CookbookNameLabel.Margin = new Padding(4, 8, 3, 3);
            CookbookNameLabel.Name = "CookbookNameLabel";
            CookbookNameLabel.Size = new Size(81, 32);
            CookbookNameLabel.TabIndex = 0;
            CookbookNameLabel.Text = "Name";
            CookbookNameLabel.Visible = false;
            // 
            // CookbookRecipesTotalLabel
            // 
            CookbookRecipesTotalLabel.AutoSize = true;
            CookbookRecipesTotalLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CookbookRecipesTotalLabel.Location = new Point(4, 59);
            CookbookRecipesTotalLabel.Margin = new Padding(4, 16, 3, 0);
            CookbookRecipesTotalLabel.Name = "CookbookRecipesTotalLabel";
            CookbookRecipesTotalLabel.Size = new Size(53, 25);
            CookbookRecipesTotalLabel.TabIndex = 1;
            CookbookRecipesTotalLabel.Text = "Total";
            CookbookRecipesTotalLabel.Visible = false;
            // 
            // CookbookDescription
            // 
            CookbookDescription.AutoSize = true;
            CookbookDescription.FlatStyle = FlatStyle.Flat;
            CookbookDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CookbookDescription.ForeColor = SystemColors.ControlDarkDark;
            CookbookDescription.Location = new Point(4, 100);
            CookbookDescription.Margin = new Padding(4, 16, 3, 0);
            CookbookDescription.Name = "CookbookDescription";
            CookbookDescription.Size = new Size(74, 17);
            CookbookDescription.TabIndex = 2;
            CookbookDescription.Text = "Description";
            CookbookDescription.Visible = false;
            // 
            // AddRecipeToCookbookButton
            // 
            AddRecipeToCookbookButton.AutoSize = true;
            AddRecipeToCookbookButton.Enabled = false;
            AddRecipeToCookbookButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddRecipeToCookbookButton.Location = new Point(9, 203);
            AddRecipeToCookbookButton.Name = "AddRecipeToCookbookButton";
            AddRecipeToCookbookButton.Size = new Size(109, 27);
            AddRecipeToCookbookButton.TabIndex = 0;
            AddRecipeToCookbookButton.Text = "Add Recipe";
            AddRecipeToCookbookButton.UseVisualStyleBackColor = true;
            AddRecipeToCookbookButton.Visible = false;
            AddRecipeToCookbookButton.Click += AddRecipeToCookbookButton_Click;
            // 
            // DeleteCookbookButton
            // 
            DeleteCookbookButton.Location = new Point(131, 501);
            DeleteCookbookButton.Name = "DeleteCookbookButton";
            DeleteCookbookButton.Size = new Size(107, 23);
            DeleteCookbookButton.TabIndex = 6;
            DeleteCookbookButton.Text = "Delete Cookbook";
            DeleteCookbookButton.UseVisualStyleBackColor = true;
            DeleteCookbookButton.Visible = false;
            DeleteCookbookButton.Click += DeleteCookbookButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 536);
            Controls.Add(DeleteCookbookButton);
            Controls.Add(splitContainer1);
            Controls.Add(createNewCookbookButton);
            Name = "MainWindow";
            Text = "Cookbook Manager";
            Load += MainWindow_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button createNewCookbookButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SplitContainer splitContainer1;
        private TreeView CookbooksTreeView;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label CookbookNameLabel;
        private Label CookbookRecipesTotalLabel;
        private Button AddRecipeToCookbookButton;
        private Label RecipesTitle;
        private ListView RecipeListView;
        private Label viewExplainerLabel;
        private ColumnHeader RecipeName;
        private ColumnHeader NumberOfIngredients;
        private ColumnHeader NumberOfSteps;
        private ColumnHeader ImageName;
        private Button DeleteCookbookButton;
        private Button RemoveRecipeButton;
        private Label CookbookDescription;
    }
}