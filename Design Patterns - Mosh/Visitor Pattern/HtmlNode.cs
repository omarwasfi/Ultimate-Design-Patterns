using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public interface HtmlNode
    {
        public void Execute(Operation operation);

    }
}
