using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class Le3ba : Batta
    {
        Le3ba():base()
        {
            this.MyFlyBehaviour = new FlyNoFly();
        }

        protected override string Display()
        {
            return "I'm Le3ba";
        }
    }
}
