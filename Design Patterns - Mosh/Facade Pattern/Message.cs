using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public class Message
    {
        public string Content { get; private set; }

        public Message(string contant)
        {
            this.Content = contant;
        }
    }
}
