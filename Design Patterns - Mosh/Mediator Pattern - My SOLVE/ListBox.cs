using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public class ListBox : UIControl
    {
        public  string Selection { get; private set; }
        public void SetSelection(string selected)
        {
            Selection = selected;

            NotifyObservers(this);
        }

        public override void Update(ListBox listBox)
        {
            throw new NotImplementedException();
        }
    }
}
