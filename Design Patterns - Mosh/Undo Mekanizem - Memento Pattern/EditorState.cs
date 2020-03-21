using System;
using System.Collections.Generic;
using System.Text;

namespace Undo_Mekanizem___Memento_Pattern
{
    public class EditorState
    {
        private string content;

        public EditorState(string content)
        {
            this.content = content;
        }

        public string getContent()
        {
            return content;
        }
    }
}
