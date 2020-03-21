using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Name = "PepperoniPizza";
            Dough = "Crust";
            Sauce = "Marinara souce";
            Toppings.Add("Sliced Pepperoni");
            Toppings.Add("Sliced Onion");
            Toppings.Add("Grated parmesan cheese");
        }
    }
}
