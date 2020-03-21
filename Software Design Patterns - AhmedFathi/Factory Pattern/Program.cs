using System;

namespace FactoryPattern
{
    /// <summary>
    /// Not Completed
    /// source: https://www.youtube.com/watch?v=JcRZb-w0K6E&list=PLQkyODvJ8ywsIlo7_VTPKRWUn2xWoaEyA&index=10
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory factory = new RandomTwoPizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(factory);
            Pizza p = pizzaStore.OrderPizza();
            Console.WriteLine();
            Console.WriteLine(p);
        }
    }
}
