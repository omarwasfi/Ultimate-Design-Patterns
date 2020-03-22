using System;

namespace State___My_SOLVE.Tools
{
    public class Eraser : Tool
    {
        public void DrawBehave()
        {
            Console.WriteLine("Draw something");
        }

        public void MouseDownBehave()
        {
            Console.WriteLine("Eraser Icon");
        }
    }
}