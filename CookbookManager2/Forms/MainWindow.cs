using CookbookManager2.DataClasses;
using CookbookManager2.Forms;

namespace CookbookManager2
{
    public partial class MainWindow : Form
    {
        public List<Cookbook> Cookbooks { get; set; }

        public List<Recipe> Recipes { get; set; }

        public MainWindow(List<DataClasses.Cookbook> _cookbooks)
        {
            Cookbooks = _cookbooks;

            Recipes = new List<Recipe>();

            

            InitializeComponent();

            foreach (var cookbook in Cookbooks)
            {
                TreeNode cookbookNode = new TreeNode(cookbook.Name);
                CookbooksTreeView.Nodes.Add(cookbookNode);
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void CookbookTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (CookbookRecipesTotalLabel.Visible == false)
            {
                CookbookRecipesTotalLabel.Visible = true;
            }

            if (CookbookNameLabel.Visible == false)
            {
                CookbookNameLabel.Visible = true;
            }

            RecipeListView.Items.Clear();

            

            Recipes = Cookbooks.Find(cookbook => cookbook.Name == e.Node.Text).Recipes;

            Recipes.ForEach(recipe => RecipeListView.Items.Add(recipe.Name));

            CookbookNameLabel.Text = e.Node.Text;

            CookbookRecipesTotalLabel.Text = $"Total Recipes: {Recipes.Count}";

            if (AddRecipeToCookbookButton.Visible == false)
            {
                AddRecipeToCookbookButton.Visible = true;

            }

            if (AddRecipeToCookbookButton.Enabled == false)
            {
                AddRecipeToCookbookButton.Enabled = true;
            }
        }

        private void AddRecipeToCookbookButton_Click(object sender, EventArgs e)
        {
            CreateRecipe NewRecipeForm = new Forms.CreateRecipe();

            var result = NewRecipeForm.ShowDialog();

            if (result == DialogResult.OK)
            {

                Recipe recipe = new Recipe(Guid.NewGuid(), NewRecipeForm.recipeName, "", NewRecipeForm.ingredients, NewRecipeForm.steps);

                var selectedCookbook = Cookbooks.Find(cookbook => cookbook.Name == CookbookNameLabel.Text);  

                if(selectedCookbook != null)
                {
                    selectedCookbook.Recipes.Add(recipe);
                    Recipes.Add(recipe);
                    RecipeListView.Items.Add(recipe.Name);
                } 
            }


        }

        private void CreateCookbookButton_Click(object sender, EventArgs e)
        {
            Form NewCookbookForm = new Forms.CreateCookbook();

            NewCookbookForm.Show();
        }
    }
}