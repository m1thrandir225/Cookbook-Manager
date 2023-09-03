
![Cookbook Manager](https://zgnjdirylgyxbflzmpvx.supabase.co/storage/v1/object/public/App%20Screenshots/CookbookIcon.png)

# Cookbook Manager

Cookbook manager is a Windows Forms Project. The main goal and purpose of this application is to provide an easy and intuitive way to manage cookbooks and recipes within them. The application provides an easy interface to view and mange your recipes and cookbooks.

When first opening the application you are greated with the "Welcome Screen". This is the onboarding screen where the user gets to create their first cookbook and add a description for it. 

After the user creates their first cookbook they are shown the "Main Window" which features a two panel layout where on the left side they can see and select their cookbooks and on the right panel it shows the state and information of the currently selected cookbook.

From there the user can create and delete cookbooks and recipes as well as view the recipes they have created.

### Data Models

The application has three data models: **Cookbook**, **Recipe** and **Ingredient**
```csharp
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
```
```csharp
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
```
```csharp
    public class Ingredient
    {
        public string Name { get; set; }

        public string Quantity { get; set; }

        public Ingredient() { }
        public Ingredient(string _name, string _quantity)
        {
            Name = _name;
            Quantity = _quantity;
        }
    }
```

These three data models are the foundation of the whole application.

Each cookbook holds a list of Recipes which inturn holds a list of Ingredients and Steps as well as other details. 

### How Persistance Works
One of my personal goals for this application was the data to be perssised across sessions but not to have a login feature. To achive this I used **Supabase** which is a backend-as-a-service which holds all of the data. The way this works is through the DotEnv class.

```csharp
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
            var url = "SUPABASE_URL=";

            var anonKey = "ANON_KEY=";

            var clientId = "CLIENT_ID=" + Guid.NewGuid().ToString();
            var textToWrite = url + "\n" + anonKey + "\n" + clientId;

            File.WriteAllText(filePath, textToWrite);

            return;
        }
    }
```

This class has thre methods: Init, Load and Create. On each application run this class is ran and the purpose of it is to set three environment variables:
- The backend api
- The backend api key
- The unique identifier for each user (computer in this case)

In the Load method we check if there is a .env file in the current running directory. If there is we extract the environment key as well as the value and set it in the Environment state of the application if there isn't we create a .env file with the variables above and set them in the Environment state of the application. 

The unique identifier is used in the backend to make sure that it shows you the correct data and your coookbooks and recipes & is a way to identify you on each application run if the .env file is removed from the current running directory you will be greated as a new user and a new unique identifier will be created.

### Controllers

The application features two controllers which are the main way the application interacts with the backend:

- RecipeController
- CookbookController



## Features

- Creating cookbooks & the ability to delete them
- Creating recipes inside cookbooks & the ability to delete them
- Viewing the recipes
- Perssisted data across application openings


## Screenshots

![Welcome Screen](https://zgnjdirylgyxbflzmpvx.supabase.co/storage/v1/object/public/App%20Screenshots/screenshot_5.png)

![Create Recipe](https://zgnjdirylgyxbflzmpvx.supabase.co/storage/v1/object/public/App%20Screenshots/screenshot_1.png)

![Create Cookbook](https://zgnjdirylgyxbflzmpvx.supabase.co/storage/v1/object/public/App%20Screenshots/screenshot_2.png)

![Main Window](https://zgnjdirylgyxbflzmpvx.supabase.co/storage/v1/object/public/App%20Screenshots/screenshot_3.png)

![Recipe View](https://zgnjdirylgyxbflzmpvx.supabase.co/storage/v1/object/public/App%20Screenshots/screenshot_4.png)

## Tech Stack

**Client:** Windows Forms .NET 6

**Server:** Supabase


## Roadmap

- Add Edit functionality to Cookbooks and Recipes

- Add file uploads when creating a recipe (so they are not stored on your machine)


