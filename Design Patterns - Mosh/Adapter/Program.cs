using Adapter.AvaFilters;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageView imageView = new ImageView(new Image());
            imageView.Apply(new CaramelFilter(new Caramel())) ;
        }
    }
}
