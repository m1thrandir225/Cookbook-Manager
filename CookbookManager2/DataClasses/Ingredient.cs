using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookbookManager2.DataClasses
{
    internal class Ingredient
    {
        public string Name { get; set; }

        public float Quantity { get; set; }

        public Ingredient(string _name, float _quantity)
        {
            Name = _name;
            Quantity = _quantity;
        }
    }
}
