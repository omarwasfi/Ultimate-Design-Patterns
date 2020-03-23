using System;
using System.Collections.Generic;
using System.Text;

namespace StartegyPattern
{
    public class JPEG : ICompressor
    {
        public void Compress(string FileName)
        {
            Console.WriteLine("Compressing.. " + FileName + " to JPEG");
        }
    }
}
