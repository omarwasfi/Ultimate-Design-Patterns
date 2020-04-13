using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public class HighlightOperation : Operation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Hightlight Heading..");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Hightlight anchor..");
        }
    }
}
