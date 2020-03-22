using System;
using System.Collections.Generic;
using System.Text;

namespace State___My_SOLVE.Tools
{
    public class Selection : Tool
    {
        public void DrawBehave()
        {
            Console.WriteLine("Draw Dashed Rectangle");
        }

        public void MouseDownBehave()
        {
            Console.WriteLine("Selection Icon");
        }
    }
}
