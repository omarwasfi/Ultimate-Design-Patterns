using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group1 = new Group();
            group1.Add(new Shape()); // square
            group1.Add(new Shape()); // square

            Group group2 = new Group();
            group2.Add(new Shape()); // circle
            group2.Add(new Shape()); // circle

            group1.Add(group2);

            group1.Render();

        }
    }
}
