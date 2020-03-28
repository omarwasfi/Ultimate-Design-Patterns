using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern___Undoble_Commands.Editor
{
    public interface UndoableCommand : Command
    {
        public void Unexecute();
    }
}
