using CookbookManager2.DataClasses;
using CookbookManager2.Forms;

namespace CookbookManager2
{
    public partial class MainWindow : Form
    {
        public List<Cookbook> Cookbooks { get; set; }

        public List<Recipe> Recipes { get; set; }

        Cookbook selectedCookbook;

        public MainWindow(List<DataClasses.Cookbook> _cookbooks)
        {
            Cookbooks = _cookbooks;

            selectedCookbook = Cookbooks[0];

            Recipes = new List<Recipe>();
            InitializeComponent();

        }

        /*
         * 
         * On Load
         * 
         */

        private void MainWindow_Load(object sender, EventArgs e)
        {
            foreach (var cookbook in Cookbooks)
            {
                TreeNode cookbookNode = new TreeNode(cookbook.Name);
                CookbooksTreeView.Nodes.Add(cookbookNode);
            }
            RecipeListView.Items.Clear();
        }

        /*
         * 
         * On Node Mouse Click
         * 
         */

        private void CookbookTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            selectedCookbook = Cookbooks.Find(cookbook => cookbook.Name == e.Node.Text);

            if (selectedCookbook == null)
            {
                return;
            }

            if (CookbookRecipesTotalLabel.Visible == false)
            {
                CookbookRecipesTotalLabel.Visible = true;
            }

            if (CookbookNameLabel.Visible == false)
            {
                CookbookNameLabel.Visible = true;
            }
            if (CookbookDescription.Visible == false)
            {
                CookbookDescription.Visible = true;
            }

            if (AddRecipeToCookbookButton.Visible == false)
            {
                AddRecipeToCookbookButton.Visible = true;

            }

            if (AddRecipeToCookbookButton.Enabled == false)
            {
                AddRecipeToCookbookButton.Enabled = true;
            }

            if (DeleteCookbookButton.Visible == false)
            {
                DeleteCookbookButton.Visible = true;
            }



            Recipes = selectedCookbook.Recipes;

            RecipeListView.Items.Clear();


            if (Recipes.Count > 0)
            {
                RecipesTitle.Visible = true;
                viewExplainerLabel.Visible = true;
                RecipeListView.Visible = true;
            }
            else
            {
                RecipesTitle.Visible = false;
                viewExplainerLabel.Visible = false;
                RecipeListView.Visible = false;
            }


            foreach (var recipe in Recipes)
            {
                ListViewItem recipeInListView = new ListViewItem(recipe.Name);
                recipeInListView.Tag = recipe;
                recipeInListView.SubItems.Add(recipe.Ingredients.Count.ToString());
                recipeInListView.SubItems.Add(recipe.Steps.Count.ToString());
                recipeInListView.SubItems.Add(recipe.Image);


                RecipeListView.Items.Add(recipeInListView);
            }


            if (RemoveRecipeButton.Visible == false && RecipeListView.Items.Count > 0)
            {
                RemoveRecipeButton.Visible = true;
                RemoveRecipeButton.Enabled = false;
            }


            CookbookRecipesTotalLabel.Text = $"Total Recipes: {Recipes.Count}";

            CookbookNameLabel.Text = selectedCookbook.Name;

            CookbookDescription.Text = selectedCookbook.Description;

        }

        /*
         * 
         *On Recipe List View Item Selection
         *
         */

        private async void AddRecipeToCookbookButton_Click(object sender, EventArgs e)
        {
            CreateRecipe NewRecipeForm = new Forms.CreateRecipe();

            var result = NewRecipeForm.ShowDialog();

            if (result == DialogResult.OK)
            {

                Recipe recipe = new Recipe(Guid.NewGuid(), NewRecipeForm.recipeName, NewRecipeForm.recipeImage, NewRecipeForm.ingredients, NewRecipeForm.steps);

                if (selectedCookbook != null)
                {
                    selectedCookbook.Recipes.Add(recipe);

                    var response = await Controllers.RecipeController.CreateRecipeForCookbook(selectedCookbook.Id, recipe);

                    if (response == null)
                    {
                        MessageBox.Show("There was an error creating the recipe");
                        return;
                    }

                    Recipes = selectedCookbook.Recipes;

                    ListViewItem newRecipeInListView = new ListViewItem(recipe.Name);

                    newRecipeInListView.SubItems.Add(recipe.Ingredients.Count.ToString());

                    newRecipeInListView.SubItems.Add(recipe.Steps.Count.ToString());

                    newRecipeInListView.SubItems.Add(recipe.Image);

                    RecipeListView.Items.Add(newRecipeInListView);

                    CookbookRecipesTotalLabel.Text = $"Total Recipes: {Recipes.Count}";


                    RecipesTitle.Visible = true;

                    viewExplainerLabel.Visible = true;

                    RecipeListView.Visible = true;


                }
            }


        }
        /*
         * 
         * Creating a new cookbook and adding it to the tree view
         * 
         */

        private void CreateCookbookButton_Click(object sender, EventArgs e)
        {
            CreateCookbook NewCookbookForm = new CreateCookbook();


            var result = NewCookbookForm.ShowDialog();

            if (result == DialogResult.OK)
            {


                Cookbooks.Add(NewCookbookForm.Cookbook);

                TreeNode newCookbookNode = new TreeNode(NewCookbookForm.Cookbook.Name);

                CookbooksTreeView.Nodes.Add(newCookbookNode);

            }
        }

        private void RecipeListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < RecipeListView.Items.Count; i++)
            {
                var rectangle = RecipeListView.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    Recipe recipe = Recipes.Single(r => r.Name == RecipeListView.SelectedItems[0].Text);
                    RecipeView recipeView = new RecipeView(recipe);
                    recipeView.Show();
                }
            }
        }

        private void RecipeListView_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < RecipeListView.Items.Count; i++)
            {
                var rectangle = RecipeListView.GetItemRect(i);

                if (rectangle.Contains(e.Location))
                {
                    Recipe selectedRecipe = Recipes.Single(r => r.Name == RecipeListView.SelectedItems[0].Text);

                    if (selectedRecipe != null)
                    {
                        RemoveRecipeButton.Enabled = true;
                    }

                    else
                    {
                        RemoveRecipeButton.Enabled = false;
                    }
                }
            }
        }

        private async void RemoveRecipeButton_Click(object sender, EventArgs e)
        {
            Recipe selectedRecipe = Recipes.Single(r => r.Name == RecipeListView.SelectedItems[0].Text);

            if (selectedRecipe != null)
            {
                var response = await Controllers.RecipeController.RemoveRecipeFromCookbook(selectedCookbook.Id, selectedRecipe.Id);

                if (response == false)
                {
                    MessageBox.Show("There was an error removing the recipe");
                    return;
                }

                Recipes.Remove(selectedRecipe);

                RecipeListView.Items.Remove(RecipeListView.SelectedItems[0]);





                CookbookRecipesTotalLabel.Text = $"Total Recipes: {Recipes.Count}";


                if (Recipes.Count == 0)
                {
                    RecipesTitle.Visible = false;

                    viewExplainerLabel.Visible = false;

                    RecipeListView.Visible = false;
                }
            }
        }

        private async void DeleteCookbookButton_Click(object sender, EventArgs e)
        {
            var response = await Controllers.CookbookController.RemoveCookbook(selectedCookbook.Id);

            if (response == false)
            {
                MessageBox.Show("There was an error removing the cookbook");
                return;
            }

            Cookbooks.Remove(selectedCookbook);

            CookbooksTreeView.Nodes.Remove(CookbooksTreeView.SelectedNode);

            CookbookNameLabel.Text = "";

            CookbookRecipesTotalLabel.Text = "";

            RecipesTitle.Visible = false;

            viewExplainerLabel.Visible = false;

            RecipeListView.Visible = false;

            CookbookNameLabel.Visible = false;

            AddRecipeToCookbookButton.Visible = false;

            RemoveRecipeButton.Visible = false;

            DeleteCookbookButton.Visible = false;

        }
    }
}