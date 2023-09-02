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
            label1 = new Label();
            RecipeListView = new ListView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            CookbookNameLabel = new Label();
            CookbookRecipesTotalLabel = new Label();
            AddRecipeToCookbookButton = new Button();
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
            splitContainer1.Panel2.Controls.Add(label1);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 207);
            label1.Margin = new Padding(4, 16, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 2;
            label1.Text = "Recipes:";
            label1.Visible = false;
            // 
            // RecipeListView
            // 
            RecipeListView.Location = new Point(7, 235);
            RecipeListView.Name = "RecipeListView";
            RecipeListView.Size = new Size(656, 245);
            RecipeListView.TabIndex = 1;
            RecipeListView.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.Controls.Add(CookbookNameLabel);
            flowLayoutPanel1.Controls.Add(CookbookRecipesTotalLabel);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(229, 105);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // CookbookNameLabel
            // 
            CookbookNameLabel.AutoSize = true;
            CookbookNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            CookbookNameLabel.Location = new Point(4, 8);
            CookbookNameLabel.Margin = new Padding(4, 8, 3, 3);
            CookbookNameLabel.Name = "CookbookNameLabel";
            CookbookNameLabel.Size = new Size(83, 32);
            CookbookNameLabel.TabIndex = 0;
            CookbookNameLabel.Text = "label1";
            CookbookNameLabel.Visible = false;
            // 
            // CookbookRecipesTotalLabel
            // 
            CookbookRecipesTotalLabel.AutoSize = true;
            CookbookRecipesTotalLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CookbookRecipesTotalLabel.Location = new Point(4, 59);
            CookbookRecipesTotalLabel.Margin = new Padding(4, 16, 3, 0);
            CookbookRecipesTotalLabel.Name = "CookbookRecipesTotalLabel";
            CookbookRecipesTotalLabel.Size = new Size(64, 25);
            CookbookRecipesTotalLabel.TabIndex = 1;
            CookbookRecipesTotalLabel.Text = "label2";
            CookbookRecipesTotalLabel.Visible = false;
            // 
            // AddRecipeToCookbookButton
            // 
            AddRecipeToCookbookButton.Enabled = false;
            AddRecipeToCookbookButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddRecipeToCookbookButton.Location = new Point(529, 36);
            AddRecipeToCookbookButton.Name = "AddRecipeToCookbookButton";
            AddRecipeToCookbookButton.Size = new Size(134, 35);
            AddRecipeToCookbookButton.TabIndex = 0;
            AddRecipeToCookbookButton.Text = "Add Recipe";
            AddRecipeToCookbookButton.UseVisualStyleBackColor = true;
            AddRecipeToCookbookButton.Visible = false;
            AddRecipeToCookbookButton.Click += AddRecipeToCookbookButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 536);
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
        private Label label1;
        private ListView RecipeListView;
    }
}