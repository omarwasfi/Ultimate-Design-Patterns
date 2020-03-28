using Command_Pattern___Undoble_Commands.Editor;
using Command_Pattern___Undoble_Commands.fx;
using System;

namespace Command_Pattern___Undoble_Commands
{
    class Program
    {
        static void Main(string[] args)
        {

            History history = new History();
            HtmlDocument document = new HtmlDocument();

            document.Content = "Hello World";

            BoldCommand boldCommand = new BoldCommand(document:document , history);
            boldCommand.Execute();
            Console.WriteLine(document.Content);

            UndoCommand undoCommand = new UndoCommand(history);
            undoCommand.Execute();

            Console.WriteLine(document.Content);
        }
    }
}
