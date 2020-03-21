using System;
using System.Collections.Generic;
using System.Text;

namespace Undo_Mekanizem___Memento_Pattern
{
    public class History
    {
        private List<EditorState> states ;

        public History()
        {
            states = new List<EditorState>();
        }

        public void PushToHistory(EditorState state)
        {
            states.Add(state);
        }

        public EditorState PopFromHistory()
        {
           int lastIndex = states.Count - 1;
            EditorState lastState = states[lastIndex-1];
            states.RemoveAt(lastIndex);

            return lastState;
        }

    }
}
