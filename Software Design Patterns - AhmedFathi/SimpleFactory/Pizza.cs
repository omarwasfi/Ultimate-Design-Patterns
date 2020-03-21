using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        public string Name;
        public string Dough;
        public string Sauce;
        public List<string> Toppings = new List<string>();

        public void GetName()
        {
            Console.WriteLine(Name);
        }
        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
        }

        public void Bake()
        {
            Console.WriteLine("Baking " + Name);
        }

        public void Cut()
        {
            Console.WriteLine("Cutting " + Name);
        }
        public void Box()
        {
            Console.WriteLine("Boxing " + Name) ;
        }
        
        public override string ToString()
        {
            string append = "";

            append += "--------" + Name + "----------\n";
            append += Dough + "\n";
            append += Sauce + "\n";
            foreach(string s in Toppings)
            {
                append += s + "\n";
                
            }
            return append;
        }

    }
}
