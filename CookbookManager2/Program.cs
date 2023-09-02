using CookbookManager2.DataClasses;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;

namespace CookbookManager2
{
    internal static class Program
    {

        private static bool IsFirstTime { get; set; } = true;

        static HttpClient webClient = new HttpClient();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        ///            
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        [STAThread]
        static async Task Main()
        {
            InitEnvFile();


            List<DataClasses.Cookbook>? cookbooks= await GetUserCookbooks();

            
 
            ApplicationConfiguration.Initialize();

            if(cookbooks != null &&  cookbooks.Count > 0)
            {
                Application.Run(new MainWindow(cookbooks));
            } else
            {
                Application.Run(new WelcomeScreen());
                
            }
            
        }

        private static async Task<List<DataClasses.Cookbook>>? GetUserCookbooks()
        {

            List<DataClasses.Cookbook>? cookbooks = new List<Cookbook>();
            var baseUrl = Environment.GetEnvironmentVariable("SUPABASE_URL");

            var anonKey = Environment.GetEnvironmentVariable("ANON_KEY");

            var uuid = Environment.GetEnvironmentVariable("CLIENT_ID");

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
                    foreach(var cookbookNode in cookbooksNode)
                    {

                        Cookbook newCookbok = new Cookbook(cookbookNode["name"].ToString(), cookbookNode["description"].ToString());

                        cookbooks.Add(newCookbok);
                    }
                }

            }

            return cookbooks;
            
        }

        
        static void InitEnvFile()
        {
            var root = Directory.GetCurrentDirectory();

            var dotenv = Path.Combine(root, ".env");

            DotEnv.Load(dotenv);
        }
    }
}