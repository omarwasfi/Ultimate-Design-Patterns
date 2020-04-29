using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    class SonyTv : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Sony set channel: " + number);
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony: Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Sony: Turn on");
        }
    }
}
