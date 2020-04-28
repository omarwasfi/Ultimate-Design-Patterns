using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern
{
    public class Point
    {
        private int X { get; set; }
        private int Y { get; set; }

        private PointIcon  PointIcon { get; set; }

        public Point(int x,int y, PointIcon pointIcon)
        {
            this.X = x;
            this.Y = y;
            this.PointIcon = pointIcon;
        }

        public void Draw()
        {
            Console.WriteLine(" Type: " + PointIcon.PointType + " , x: "+ X +" , y: " + Y );
        }
    }
}
