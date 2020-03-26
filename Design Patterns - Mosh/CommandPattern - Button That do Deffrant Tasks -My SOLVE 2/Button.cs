using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern___Button_That_do_Deffrant_Tasks__My_SOLVE_2
{
    public class Button
    {
        public string Label { get; set; }

        public void Click(ITask task)
        {
            task.Apply();
        }

    }
}
