using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public class PlanTextOperation : Operation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Text-heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Text-anchor");
        }
    }
}
