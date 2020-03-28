using Command_Pattern___Undoble_Commands.fx;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern___Undoble_Commands
{
    public class BlackAndWhiteCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("Black and white");
        }
    }
}
