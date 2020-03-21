using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class FlyNoFly : FlyBehaviour
    {
        public string Fly()
        {
            return "I can't fly";
        }
    }
}
