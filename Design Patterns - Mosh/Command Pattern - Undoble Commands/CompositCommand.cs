using Command_Pattern___Undoble_Commands.fx;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern___Undoble_Commands
{
    public class CompositCommand : Command
    {
        private List<Command> Commands = new List<Command>();

        public void Add(Command command)
        {
            Commands.Add(command);
        }

        public void Execute()
        {
            foreach(Command command in Commands)
            {
                command.Execute();
            }
        }
    }
}
