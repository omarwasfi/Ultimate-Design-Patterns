using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CloudStream : Stream
    {
        public void Write(string data)
        {
            Console.WriteLine("Storage " + data);
        }
    }
}
