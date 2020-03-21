using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "CheesePizza";
            Dough = "Thin Crust";
            Sauce = "White garlic Sauce";
            Toppings.Add("Clams");
            Toppings.Add("Grated parmesan cheese");
        }
    }
}
