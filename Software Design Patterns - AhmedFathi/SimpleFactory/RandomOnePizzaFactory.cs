using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class RandomOnePizzaFactory : PizzaFactory
    {
        public Pizza CreatePizza(params string[] type)
        {
            Random random = new Random();
            int r = random.Next(11);
            Pizza pizza = null;
            if(r == 0)
            {
                pizza = new CheesePizza();
            }
            else if(r== 1)
            {
                pizza = new PepperoniPizza();
            }
            else
            {
                pizza = new VeggiePizza();
            }
            return pizza;
        }
    }
}
