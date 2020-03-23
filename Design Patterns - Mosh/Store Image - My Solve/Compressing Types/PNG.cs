using System;
using System.Collections.Generic;
using System.Text;

namespace StartegyPattern
{
    public class PNG : ICompressor
    {

        public void Compress(string FileName)
        {
            Console.WriteLine("Compressing.. " + FileName + " to PNG");
        }
    }
}
