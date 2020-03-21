using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PizzaStore
    {
        PizzaFactory factory;

        public PizzaStore(PizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza OrderPizza(params string[] type)
        {
            Pizza pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

    }
}
