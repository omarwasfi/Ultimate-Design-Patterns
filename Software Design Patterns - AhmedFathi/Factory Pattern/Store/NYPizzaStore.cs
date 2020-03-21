using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class NYPizzaStore : PizzaFactory
    {
       
        public Pizza CreatePizza(params string[] myType)
        {
            Pizza pizza = null;
            string type = "";
            if (myType.Length > 0)
            {
                type = myType[0];
            }
            else
            {
                type = "Cheese";
            }

            if (type == "Cheese")
            {
                pizza = new CheesePizza();
            }
            else if (type == "PepperoniPizza")
            {
                pizza = new PepperoniPizza();

            }
            else if (type == "VeggiePizza")
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }

    }
}
