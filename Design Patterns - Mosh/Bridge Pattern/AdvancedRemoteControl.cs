using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public  class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {

        }

        public  void SetChannel(int number)
        {
            Device.SetChannel(number);
        }
        
    }
}
