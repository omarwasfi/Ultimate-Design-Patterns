using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern___Undoble_Commands.Editor
{
    public class History 
    {
        private Queue<UndoableCommand> Commands { get; set; } = new Queue<UndoableCommand>();

        public void Push(UndoableCommand command)
        {
            Commands.Enqueue(command);
        }

        public UndoableCommand Pop()
        {
            return Commands.Dequeue();
        }
        public int Size()
        {
            return Commands.Count;
        }
    }
}
