using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern___Undoble_Commands.fx
{
    public class Button
    {
        private Command Command { get; set; }

        public string Label { get; set; }

        public Button(Command command)
        {
            this.Command = command;
        }

        public void Click()
        {
            Command.Execute();
        }

    }
}
