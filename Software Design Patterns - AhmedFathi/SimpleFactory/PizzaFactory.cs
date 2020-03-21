using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public interface PizzaFactory
    {
        public Pizza CreatePizza(params string[] type);
    }
}

