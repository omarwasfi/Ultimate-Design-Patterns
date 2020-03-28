using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern___Undoble_Commands
{
    public class ResizeCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("Resize..");
        }
    }
}
