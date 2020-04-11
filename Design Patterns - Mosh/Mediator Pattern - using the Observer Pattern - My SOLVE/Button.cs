using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public class Button : UIControl
    {
   

        public Boolean IsEnabled { get; private set; }

        public void SetEnabled(Boolean enabled)
        {
            this.IsEnabled = enabled;
            NotifyEventHandlers();
        }

    }
}
