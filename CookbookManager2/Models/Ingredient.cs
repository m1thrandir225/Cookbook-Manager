using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookbookManager2.DataClasses
{
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
}
