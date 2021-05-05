using System;
using System.Collections.Generic;
using VendingMachineConsole.ingredients;

namespace VendingMachineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Water(200));
            ingredients.Add(new Milk(100));

            Water water = new Water(123);

            Console.WriteLine(ingredients.Find(x => x.Equals(water)) > water);
        }
    }
}
