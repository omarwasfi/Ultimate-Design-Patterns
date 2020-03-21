using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    /// <summary>
    /// The Super Class
    /// </summary>
     public abstract class  Batta
    {
        private int Id;
        private string Name;

        private static int Counter = 0;

        /// <summary>
        /// Favouring Composition over inheritance
        /// </summary>
        protected FlyBehaviour MyFlyBehaviour;


        public Batta()
        {
            this.Id = Counter++;
            this.Name = "Batta#" + this.Id;
            this.MyFlyBehaviour = new FlyWithWings();
        }

        public string Swim()
        {
            return "Hey , I am Swimming";
        }

        protected abstract string Display();
        public void Perform()
        {
            Console.WriteLine("Hi,I'm" + this.Name);
            Console.WriteLine(this.Swim());
            Console.WriteLine(Display());
            Console.WriteLine(MyFlyBehaviour.Fly());

        }


    }
}
