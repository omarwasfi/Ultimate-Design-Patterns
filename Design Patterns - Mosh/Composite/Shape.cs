using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Shape : Component
    {
        public void Render()
        {
            Console.WriteLine("render shape");
        }
    }
}
