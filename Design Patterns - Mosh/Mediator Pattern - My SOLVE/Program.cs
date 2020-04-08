using System;

namespace Mediator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            UIControl textBox = new TextBox();
            UIControl button = new Button();
            ListBox listBox = new ListBox();

            listBox.AddObserver(textBox);
            listBox.AddObserver(button);

            listBox.SetSelection("211");

        }
    }
}
