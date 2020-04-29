using System;

namespace Bridge_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDevice device = new SonyTv();
            AdvancedRemoteControl remoteControl = new AdvancedRemoteControl(device);
            remoteControl.SetChannel(456);
        }
    }
}
