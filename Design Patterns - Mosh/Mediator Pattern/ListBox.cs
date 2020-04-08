using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public class ListBox : UIControl
    {
        public ListBox(DialogBox owner) : base(owner)
        {

        }

        public  string Selection { get; private set; }
        public void SetSelection(string selected)
        {
            Selection = selected;
            Owner.Changed(this);
        }

       
    }
}
