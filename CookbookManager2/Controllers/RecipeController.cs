using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookbookManager2.DataClasses;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;
using System.Text.Json;

namespace CookbookManager2.Controllers
{
    internal static class RecipeController
    {
        private static string baseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");

        private static string anonKey = Environment.GetEnvironmentVariable("ANON_KEY");

        private static string uuid = Environment.GetEnvironmentVariable("CLIENT_ID");

        public static async Task<List<Recipe>> GetRecipesForCookbook(Guid cookbookId)
        {
            List<Recipe> recipes = new List<Recipe>();

            using (var httpClient = new HttpClient())
            {
                
                httpClient.BaseAddress  = new Uri(baseUrl + "/rest/v1/");
                httpClient.DefaultRequestHeaders.Add("apiKey", anonKey);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.GetAsync("recipe?cookbook_id=eq." + cookbookId.ToString());

                var json = await response.Content.ReadAsStringAsync();

                JsonArray recipesNode = JsonNode.Parse(json).AsArray();

                if (recipesNode != null)
                {
                    foreach (var recipeNode in recipesNode)
                    {
                        Guid id = Guid.Parse(recipeNode["id"].ToString());

                        String name = recipeNode["name"].ToString();

                        var jsonIngredients = recipeNode["ingredients"].ToString();

                        List<Ingredient> ingredients = JsonSerializer.Deserialize<List<Ingredient>>(jsonIngredients);

                        var jsonSteps = recipeNode["steps"].ToString();

                        List<String> steps = JsonSerializer.Deserialize<List<String>>(jsonSteps);

                        String image = recipeNode["image"].ToString();

                        Recipe newRecipe = new Recipe(_id: id, _name: name, _image: image, _ingredients: ingredients, _steps: steps);

                        recipes.Add(newRecipe);
                    }
                }
            }
            return recipes;
        } 

        public static async Task<Recipe> CreateRecipeForCookbook(Guid cookbookId, Recipe recipe)
        {

            using (HttpClient httpClient = new HttpClient())
            {

                httpClient.BaseAddress = new Uri(baseUrl + "/rest/v1/");
                httpClient.DefaultRequestHeaders.Add("apiKey", anonKey);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var jsonIngredients = JsonSerializer.Serialize(recipe.Ingredients);
                var jsonSteps = JsonSerializer.Serialize(recipe.Steps);

                var content = new Dictionary<string, string>()
                {
                    { "name", recipe.Name},
                    {"cookbook_id", cookbookId.ToString() },
                    {"ingredients", jsonIngredients },
                    {"steps", jsonSteps },
                    {"image", recipe.Image },
                  
                };

                var json = JsonSerializer.Serialize(content);

                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync("recipe", stringContent);


                if (response.IsSuccessStatusCode)
                {
                    return recipe;
                }
                else
                {
                    return null;
                }

            }
        }

        public static async Task<bool> RemoveRecipeFromCookbook(Guid cookbookId, Guid recipeId)
        {

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseUrl + "/rest/v1/");
                httpClient.DefaultRequestHeaders.Add("apiKey", anonKey);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.DeleteAsync($"recipe?id=eq.{recipeId.ToString()}&cookbook_id=eq.{cookbookId.ToString()}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
