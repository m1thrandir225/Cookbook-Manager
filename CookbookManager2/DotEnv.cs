using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookbookManager2
{
    internal class DotEnv
    {

        public static void Init()
        {
            var root = Directory.GetCurrentDirectory();

            var dotenv = Path.Combine(root, ".env");

            Load(dotenv);

        }

        public static void Load(string filePath)
        {
            if(!File.Exists(filePath))
            {
                Create(filePath);
            };

            foreach(var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split("=", StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 2)
                    continue;

                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }

        public static void Create(string filePath)
        {
            FileStream fs = File.Create(filePath);

            fs.Close();

            File.WriteAllText(filePath, "");
            var url = "SUPABASE_URL=https://zgnjdirylgyxbflzmpvx.supabase.co";

            var anonKey = "ANON_KEY=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InpnbmpkaXJ5bGd5eGJmbHptcHZ4Iiwicm9sZSI6ImFub24iLCJpYXQiOjE2OTMxNzEyMDQsImV4cCI6MjAwODc0NzIwNH0.5Fphcpqv2jAvitYXMZPBfUmgJv6vIkOa7-i1B-v_9q4";

            var clientId = "CLIENT_ID=" + Guid.NewGuid().ToString();
            var textToWrite = url + "\n" + anonKey + "\n" + clientId;

            File.WriteAllText(filePath, textToWrite);

            return;
        }
    }
}
