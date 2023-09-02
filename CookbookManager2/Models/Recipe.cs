using CookbookManager2.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

interface IRecipe {
    Guid Id { get; set; }

    String Name { get; set; }
    List<Ingredient> Ingredients { get; set; }
   
    List<String> Steps { get; set; }

    String Image {  get; set; }

    Ingredient getIngredientByIndex(int i);

    Ingredient getIngredientByName(String name);

}

namespace CookbookManager2
{
    public class Recipe : IRecipe
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public List<String> Steps { get; set; }

        public String Image { get; set; }

        public Recipe(Guid _id, String _name, String _image, List<Ingredient> _ingredients, List<String> _steps) {
            Id = _id;
            Name = _name;
            Image = _image;
            Ingredients = _ingredients;
            Steps = _steps;
        }
        

        public Ingredient getIngredientByIndex(int i)
        {
            return Ingredients.ElementAt(i);
        }

        public Ingredient getIngredientByName(String name)
        {
            return Ingredients.Single(ingredient => ingredient.Name == name);
        }


        public List<Ingredient> addNewIngredient(Ingredient newIngredient)
        {
            Ingredients.Add(newIngredient);

            return Ingredients;
        }

        public List<Ingredient> removeIngredient(Ingredient ingredient)
        {
            Ingredients.Remove(ingredient);

            return Ingredients;
        }

        public List<String> addStep(String step)
        {
            Steps.Add(step);

            return Steps;
        }

        public List<String> removeStep(String step)
        {
            Steps.Remove(step);

            return Steps;
        }

        
    }

}
