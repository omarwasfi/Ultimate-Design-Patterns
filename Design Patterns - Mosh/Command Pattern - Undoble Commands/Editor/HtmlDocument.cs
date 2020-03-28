using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern___Undoble_Commands.Editor
{
    public class HtmlDocument
    {
        public string Content { get; set; }

        public void MakeBold()
        {
            Content = "<b>" + Content + "</b>";
        }
    }
}
