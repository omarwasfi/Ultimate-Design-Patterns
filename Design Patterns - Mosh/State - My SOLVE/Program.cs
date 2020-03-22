using State___My_SOLVE.Tools;
using System;

namespace State___My_SOLVE
{
    class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();

            Tool selection = new Selection();
            Tool brush = new Brush();

            canvas.SelectedTool = selection;

            canvas.MouseDown();

            canvas.MouseUp();

            canvas.SelectedTool = brush;


            canvas.MouseDown();

            canvas.MouseUp();

        }
    }
}
