using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern___Undoble_Commands.Editor
{
    public class BoldCommand : UndoableCommand
    {
        private  string PrevContent { get; set; }
        private HtmlDocument Document { get; set; }
        private History History { get; set; }

        public BoldCommand(HtmlDocument document,History history)
        {
            this.Document = document;
            this.History = history;
        }

        public void Execute()
        {
            PrevContent = Document.Content;
            Document.MakeBold();
            History.Push(command: this);
        }

        public void Unexecute()
        {
            Document.Content = PrevContent;
        }
    }
}
