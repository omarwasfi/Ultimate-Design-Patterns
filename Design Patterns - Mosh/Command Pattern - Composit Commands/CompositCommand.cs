using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern___Composit_Commands
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
