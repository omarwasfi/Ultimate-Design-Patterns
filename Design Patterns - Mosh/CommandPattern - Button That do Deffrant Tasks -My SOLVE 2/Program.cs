using System;

namespace CommandPattern___Button_That_do_Deffrant_Tasks__My_SOLVE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();

            ITask task = new ChangeShape();

            button.Click(task);
        }
    }
}
