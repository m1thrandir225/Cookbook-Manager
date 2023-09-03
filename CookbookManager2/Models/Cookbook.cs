using System;


namespace CookbookManager2.DataClasses
{
    public class Cookbook
    {
        public Guid Id { get; set; }
        public String Name { get; set; }

        public String? Description { get; set; }

        public List<Recipe> Recipes { get; set; }


        public Cookbook (Guid _id, String _name, String? _description)
        {
            Id = _id;
            Name = _name;
            Description = _description;

            Recipes = new List<Recipe>();
        }

        public Cookbook(Guid _id, String _name, String? _description, List<Recipe> _recipes)
        {
            Id = _id;
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