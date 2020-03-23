using System;
using System.Collections.Generic;
using System.Text;

namespace StartegyPattern.Filter_Types
{
    class Amaro : IFilter
    {
        public void Filter(string FileName)
        {
            Console.WriteLine("Appling Amaro on " + FileName + " ...");
        }
    }
   
}
