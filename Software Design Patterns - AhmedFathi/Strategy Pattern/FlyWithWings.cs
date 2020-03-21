using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
   public class FlyWithWings : FlyBehaviour
    {
        public string Fly()
        {
            return "I am flying with wings";
        }
    }
}
