﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class SpreadSheet:Observer
    {
        public void Update(int value)
        {
            Console.WriteLine("Spread Sheet Notified ! " + value);
        }
    }
 
}
