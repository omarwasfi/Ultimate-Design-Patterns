using System;
using System.Collections.Generic;
using System.Text;

namespace StartegyPattern.Filter_Types
{
    class Sepia : IFilter
    {
        public void Filter(string FileName)
        {
            Console.WriteLine("Appling Sepia on " + FileName + " ...");
        }
    }
   
}
