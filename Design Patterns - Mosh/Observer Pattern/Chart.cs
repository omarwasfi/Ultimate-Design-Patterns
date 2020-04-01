using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Chart : Observer
    {
        public void Update()
        {
            Console.WriteLine("Chart Notified !");
        }
    }
}
