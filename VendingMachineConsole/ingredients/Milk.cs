using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsole.ingredients
{
    public class Milk: Ingredient
    {
        public Milk(double quantity) : base(quantity) { this.name = "milk"; }
    }
}
