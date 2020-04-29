using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public  class RemoteControl
    {
        protected IDevice Device { get; set; }

        public RemoteControl(IDevice device)
        {
            this.Device = device;
        }
        public  void TurnOn()
        {
            Device.TurnOn();
        }


        public void TurnOff() 
        {
            Device.TurnOff();
        }


    }
}
 