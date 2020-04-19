using Adapter.AvaFilters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class CaramelFilter : Filter
    {
        private Caramel caramel  { get; set; }

        public CaramelFilter(Caramel caramel)
        {
            this.caramel = caramel;
        }
        public void Apply(Image image)
        {
            caramel.Init();
            caramel.Render(image); 
        }
    }
}
