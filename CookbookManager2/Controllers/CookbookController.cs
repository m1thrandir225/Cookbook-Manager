using CookbookManager2.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace CookbookManager2.Controllers
{
    internal static class CookbookController
    {
        private static string baseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");

        private static string anonKey = Environment.GetEnvironmentVariable("ANON_KEY");

        private static string uuid = Environment.GetEnvironmentVariable("CLIENT_ID");
        public static async Task<List<Cookbook>> GetCookboooks()
        {
            List<Cookbook> cookbooks = new List<Cookbook>();

            using (var httpClient = new HttpClient())
            {

                
                httpClient.BaseAddress = new Uri(baseUrl + "/rest/v1/");

                httpClient.DefaultRequestHeaders.Add("apiKey", anonKey);

                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.GetAsync("cookbook?client_id=eq." + uuid);

                var json = await response.Content.ReadAsStringAsync();

                JsonArray cookbooksNode = JsonNode.Parse(json).AsArray();

                if(cookbooksNode != null)
                {
                    foreach (var cookbookNode in cookbooksNode)
                    {
                        Cookbook newCookbook = new Cookbook(Guid.Parse(cookbookNode["id"].ToString()), cookbookNode["name"].ToString(), cookbookNode["description"].ToString());

                        var recipeResponse = await Controllers.RecipeController.GetRecipesForCookbook(newCookbook.Id);

                        if(recipeResponse != null)
                        {
                            newCookbook.Recipes = recipeResponse;
                        }

                        cookbooks.Add(newCookbook);
                    }
                }
            }

            return cookbooks;
        }

        static async Task<Cookbook> GetCookbook(String _id)
        {
            Cookbook cookbook = null;

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseUrl + "/rest/v1/");

                httpClient.DefaultRequestHeaders.Add("apiKey", anonKey);

                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.GetAsync($"cookbook?id.eq={_id}");

                var json = await response.Content.ReadAsStringAsync();

                JsonArray cookbooksNode = JsonNode.Parse(json).AsArray();

                if(cookbooksNode != null)
                {
                    var cookbookNode = cookbooksNode[0];

                    cookbook = new Cookbook(Guid.Parse(cookbookNode["id"].ToString()), cookbookNode["name"].ToString(), cookbookNode["description"].ToString());

                }
            }

            return cookbook;
        }

        public static async Task<Cookbook> CreateCookbook(Cookbook newCookbook)
        {

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseUrl + "/rest/v1/");

                httpClient.DefaultRequestHeaders.Add("apiKey", anonKey);

                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                var content = new Dictionary<string, string>()
                {
                    { "id", newCookbook.Id.ToString() },
                    { "name", newCookbook.Name },
                    { "description", newCookbook.Description },
                    { "client_id", uuid }
                };

                var json = JsonSerializer.Serialize(content);

                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                

                HttpResponseMessage response = await httpClient.PostAsync("cookbook", stringContent);

                if(response.IsSuccessStatusCode)
                {
                    return newCookbook;
                }
                else
                {
                    return null;
                }

            }
        }
        static async Task<Cookbook> EditCookbook(String _id, String _newName, String _newDescription)
        {

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseUrl + "/rest/v1/");

                httpClient.DefaultRequestHeaders.Add("apiKey", anonKey);

                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var content = new StringContent("{\"name\": \"" + _newName + "\", \"description\": \"" + _newDescription + "\"}", Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PutAsync("cookbook?id=eq." + _id, content);

                var json = await response.Content.ReadAsStringAsync();

                JsonObject cookbookNode = JsonNode.Parse(json).AsObject();

                Cookbook newCookbook = new Cookbook(Guid.Parse(cookbookNode["id"].ToString()), cookbookNode["name"].ToString(), cookbookNode["description"].ToString());

                return newCookbook;
            }
        }

        public static async Task<bool> RemoveCookbook(Guid id)
        {

            using(HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseUrl + "/rest/v1/");

                httpClient.DefaultRequestHeaders.Add("apiKey", anonKey);

                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.DeleteAsync($"cookbook?id=eq.{id.ToString()}&client_id=eq.{uuid}");

                if(response.IsSuccessStatusCode)
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
