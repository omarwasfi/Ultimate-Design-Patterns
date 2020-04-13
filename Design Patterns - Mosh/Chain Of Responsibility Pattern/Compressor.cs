using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Pattern
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }
        
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Compress");

            return false;
        }
    }
}
