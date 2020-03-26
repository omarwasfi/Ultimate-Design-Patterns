using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern___Button_That_do_Deffrant_Tasks__My_SOLVE_2
{
    public class ChangeShape : ITask
    {
        public void Apply()
        {
            Console.WriteLine("Changing Shape..");
        }
    }
}
