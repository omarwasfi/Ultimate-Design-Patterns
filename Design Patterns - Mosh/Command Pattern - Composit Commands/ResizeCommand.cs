using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern___Composit_Commands
{
    public class ResizeCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("Resize..");
        }
    }
}
