using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public class TextBox : UIControl
    {
        public TextBox(DialogBox owner) : base(owner)
        {
        }

        public string  Content { get; private set; }

        public void SetContent(string content)
        {
            this.Content = content;
            Owner.Changed(this);
        }

        
    }
}
