using System;

namespace VendingMachineConsole
{
    public class Ingredient
    {
        private double quantity;
        protected string name;

        public Ingredient(double quantity) {
            this.quantity = quantity;
            this.name = "ingredient";
        }

        public double Quantity {
            get { return quantity; }
            set { quantity = value;}
        }

        public static bool operator >(Ingredient a, Ingredient b) { return a.quantity > b.quantity; }
        public static bool operator <(Ingredient a, Ingredient b) { return a.quantity < b.quantity; }
        /*public static bool operator ==(Ingredient a, Ingredient b) { return a.quantity == b.quantity; }*/
/*        public static bool operator !=(Ingredient a, Ingredient b) { return a.quantity != b.quantity; }*/

        public override bool Equals(object obj)
        {
            Ingredient ingredient = obj as Ingredient;
            return this != null && obj != null && this.name.ToLower().Equals(ingredient.name.ToLower());
        }

        public override int GetHashCode()
        {
            return this.name.ToLower().GetHashCode();
        }
    }
}