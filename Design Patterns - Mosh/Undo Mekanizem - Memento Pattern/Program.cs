using System;

namespace Undo_Mekanizem___Memento_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Editor editor = new Editor();
            History history = new History();

            editor.setContent("a");
            history.PushToHistory(editor.CreateState());

            editor.setContent("b");
            history.PushToHistory(editor.CreateState());

            editor.setContent("c");
            history.PushToHistory(editor.CreateState());

            editor.setContent("d");
            history.PushToHistory(editor.CreateState());

            editor.Restore(history.PopFromHistory());
            editor.Restore(history.PopFromHistory());
            editor.Restore(history.PopFromHistory());


            Console.WriteLine(editor.getContent());

        }
    }
}
