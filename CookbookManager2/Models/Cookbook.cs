using System;


namespace CookbookManager2.DataClasses
{
    public class Cookbook
    {
        public String Name { get; set; }

        public String? Description { get; set; }

        public List<Recipe> Recipes { get; set; }


        public Cookbook (String _name, String? _description)
        {
            Name = _name;
            Description = _description;

            Recipes = new List<Recipe>();
        }

        public Cookbook(String _name, String? _description, List<Recipe> _recipes)
        {
            Name = _name;
            Description = _description;
            Recipes = _recipes;
        }

        public List<String> getAllRecipesByName()
        {
            List<String> allRecipeNames = new List<String>();

            Recipes.ForEach(recipe => allRecipeNames.Add(recipe.Name));

            return allRecipeNames;
        }



    }
}