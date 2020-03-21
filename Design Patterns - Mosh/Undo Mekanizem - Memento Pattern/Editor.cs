using System;
using System.Collections.Generic;
using System.Text;

namespace Undo_Mekanizem___Memento_Pattern
{
    public class Editor
    {
        private String content;

        public EditorState CreateState()
        {
            return new EditorState(content);
        }

        public void Restore(EditorState state)
        {
            content = state.getContent();
        }

        public String getContent()
        {
            return content;
        }

        public void setContent(String content)
        {
            this.content = content;
        }
    }
}
