using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();
        public PointIcon GetPointIcon(PointType pointType)
        {
            // key -> value
            // pintetype -> pointIcon

            if (!icons.ContainsKey(pointType))
            {
                PointIcon pointIcon = new PointIcon(pointType,null);
                icons.Add(pointType, pointIcon);
            }
            return icons.GetValueOrDefault(pointType);

        }
    }
}
