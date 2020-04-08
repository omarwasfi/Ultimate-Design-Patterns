using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public  class UIControl
    {
        protected DialogBox Owner { get;  set; }

        public UIControl(DialogBox owner)
        {
            this.Owner = owner;
        }
    }
}
