using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class SamsungTv : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Samsung set channel: " + number);
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung: Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Samsung: Turn on");
        }
    }
}
