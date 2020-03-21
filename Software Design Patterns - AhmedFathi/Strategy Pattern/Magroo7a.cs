using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    
    public class Magroo7a : Batta
    {
        public Magroo7a() : base()
        {

        }
        protected override string Display()
        {
            return "I'm Magroo7a";
        }

        public void gotShot()
        {
            this.MyFlyBehaviour = new FlyNoFly();
        }
    }
}
