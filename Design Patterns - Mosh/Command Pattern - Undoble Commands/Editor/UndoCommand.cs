using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern___Undoble_Commands.Editor
{
    public class UndoCommand : Command
    {
        private History History { get; set; }
        public UndoCommand(History history)
        {
            this.History = history;
        }
        public void Execute()
        {
            if(History.Size()>0)
                History.Pop().Unexecute();
        }
    }
}
