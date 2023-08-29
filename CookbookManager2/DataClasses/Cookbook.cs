using System;


namespace CookbookManager2.DataClasses
{
    internal class Cookbook
    {
        public String Name { get; set; }

        public String? Description { get; set; }

        public List<Recipe> Recipes { get; set; } = new List<Recipe>();


        public Cookbook(String _name, String? _description)
        {
            Name = _name;
            Description = _description;
        }

        public List<String> getAllRecipesByName()
        {
            List<String> allRecipeNames = new List<String>();

            Recipes.ForEach(recipe => allRecipeNames.Add(recipe.Name));

            return allRecipeNames;
        }



    }
}