using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class VividFilter : Filter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying vivid filter");
        }
    }
}
