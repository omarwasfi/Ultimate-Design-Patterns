using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Chart : Observer
    {
        public void Update(int value)
        {
            Console.WriteLine("Chart Notified ! "+value);
        }
    }
}
