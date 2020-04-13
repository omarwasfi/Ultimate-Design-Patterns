using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public class HtmlDecument
    {
        public List<HtmlNode> Nodes { get; set; } = new List<HtmlNode>();

        public void Add(HtmlNode node)
        {
            Nodes.Add(node);
        }

        public void Execute(Operation operation)
        {
            foreach(HtmlNode node in Nodes)
            {
                node.Execute(operation);
            }
        }
    }
}
