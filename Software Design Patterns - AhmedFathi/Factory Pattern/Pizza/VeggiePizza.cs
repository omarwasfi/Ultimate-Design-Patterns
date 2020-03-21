using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public  class VeggiePizza : Pizza
    {
         public  VeggiePizza()
        {
            Name = "VeggiePizza";
            Dough = "Crust";
            Sauce = "Marinara Sauce";
            Toppings.Add("Shadded mozzarella");
            Toppings.Add("Grated parmesan");
            Toppings.Add("Diced onion");
            Toppings.Add("Sliced red papper");

        }
    }
}
