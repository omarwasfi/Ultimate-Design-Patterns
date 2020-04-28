using System;

namespace Flyweight_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PointService pointService = new PointService(new PointIconFactory());
            foreach(Point point in pointService.GetPoints())
            {
                point.Draw();
            }
        }
    }
}
