using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public interface IDevice 
    {
        public  void TurnOn();


        public  void TurnOff();
        public  void SetChannel(int number);
    }
}
