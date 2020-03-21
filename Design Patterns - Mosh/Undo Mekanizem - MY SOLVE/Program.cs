using System;

namespace Undo_Mekanizem___MY_SOLVE
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var editor = new Editor();
            editor.setContent("a");
            editor.setContent("b");
            editor.setContent("c");
            editor.setContent("d");
            Console.WriteLine(editor.getContent());
            editor.undo();
            Console.WriteLine(editor.getContent());
            editor.undo();
            Console.WriteLine(editor.getContent());
            editor.undo();
            Console.WriteLine(editor.getContent());
            editor.undo();
            Console.WriteLine(editor.getContent());
            editor.undo();
            Console.WriteLine(editor.getContent());
            editor.undo();
            Console.WriteLine(editor.getContent());
        }
    }
}