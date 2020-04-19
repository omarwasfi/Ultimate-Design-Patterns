using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.AvaFilters
{
    public class Caramel
    {
        public void Init()
        {

        }

        public void Render(Image image)
        {
            Console.WriteLine("Applying caramel filter");
        }
    }
}
