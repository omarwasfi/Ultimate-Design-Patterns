using System;

namespace State___My_SOLVE.Tools
{
    public class Brush
        : Tool
    {
        public void DrawBehave()
        {
            Console.WriteLine("Draw a line");
        }

        public void MouseDownBehave()
        {
            Console.WriteLine("Brush Icon");

        }
    }
}