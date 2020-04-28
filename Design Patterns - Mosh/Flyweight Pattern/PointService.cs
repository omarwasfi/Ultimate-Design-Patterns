using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern
{
    public class PointService
    {
        private PointIconFactory PointIconFactory { get; set; }

        public PointService(PointIconFactory pointIconFactory)
        {
            this.PointIconFactory = pointIconFactory;
        }

        public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            Point point = new Point(1, 2, PointIconFactory.GetPointIcon(pointType: PointType.CAFE));
            points.Add(point);

            return points;
        }
    }
}
