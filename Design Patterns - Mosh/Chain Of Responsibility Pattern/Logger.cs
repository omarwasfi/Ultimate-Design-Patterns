﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Pattern
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Log");

            return false;
        }
    }
}
