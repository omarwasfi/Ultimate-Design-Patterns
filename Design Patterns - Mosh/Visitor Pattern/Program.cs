using System;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlDecument htmlDecument = new HtmlDecument();
            htmlDecument.Add(new HeadingNode());
            htmlDecument.Add(new AnchorNode());
            htmlDecument.Execute(new HighlightOperation());
            htmlDecument.Execute(new PlanTextOperation());
        }
    }
}
