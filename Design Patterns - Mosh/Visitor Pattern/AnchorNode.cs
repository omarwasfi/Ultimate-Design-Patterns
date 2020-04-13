using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public class AnchorNode : HtmlNode
    {
        public void Execute(Operation operation)
        {
            operation.Apply(this);
        }

        
    }
}
