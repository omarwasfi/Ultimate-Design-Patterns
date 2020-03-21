using System;

namespace Strategy_Pattern
{
    /// <summary>
    /// source: https://www.youtube.com/watch?v=yGhZbN2caSE&list=PLQkyODvJ8ywsIlo7_VTPKRWUn2xWoaEyA&index=2
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            Magroo7a b1 = new Magroo7a();
            
           b1.Perform();

            Console.WriteLine();
            

            Magroo7a b2 = new Magroo7a();
            b2.Perform();

            Console.WriteLine();

            b1.gotShot();

            b1.Perform();

        }
    }
}
