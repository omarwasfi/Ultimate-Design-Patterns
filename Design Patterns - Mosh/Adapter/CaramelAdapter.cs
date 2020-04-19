using Adapter.AvaFilters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class CaramelAdapter : Caramel, Filter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}
