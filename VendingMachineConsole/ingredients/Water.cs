using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsole.ingredients
{
    public class Water : Ingredient
    {
        public Water(double quantity): base(quantity) {
            this.name = "water";
        }
    }
}
