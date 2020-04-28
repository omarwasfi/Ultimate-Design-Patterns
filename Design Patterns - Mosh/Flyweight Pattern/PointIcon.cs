using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern
{
    public class PointIcon
    {
        public  PointType PointType { get; private set; }
        public byte[] Icon { get; private set; }

        public PointIcon(PointType pointType, byte[] icone)
        {
            this.PointType = pointType;
            this.Icon = icone;
        }
    }
}
