using CookbookManager2.DataClasses;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;

namespace CookbookManager2
{
    internal static class Program
    {

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
            DotEnv.Init();

            List<DataClasses.Cookbook>? cookbooks= await Controllers.CookbookController.GetCookboooks();

 
            ApplicationConfiguration.Initialize();

            if(cookbooks != null &&  cookbooks.Count > 0)
            {
                Application.Run(new MainWindow(cookbooks));
            } else
            {
                Application.Run(new WelcomeScreen());
                
            }
            
        }
        
    }
}