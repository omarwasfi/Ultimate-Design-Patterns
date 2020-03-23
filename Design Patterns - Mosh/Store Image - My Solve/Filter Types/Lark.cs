using System;
using System.Collections.Generic;
using System.Text;

namespace StartegyPattern.Filter_Types
{
    public class Lark : IFilter
    {
        public void Filter(string FileName)
        {
            Console.WriteLine("Appling Lark on " + FileName + " ...");
        }
    }
}
