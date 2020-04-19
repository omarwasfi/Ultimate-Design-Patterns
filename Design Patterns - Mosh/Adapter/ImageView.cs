using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ImageView
    {
        private Image image { get; set; }

        public ImageView(Image image)
        {
            this.image = image;
        }


        public void Apply(Filter filter)
        {
            filter.Apply(image) ;
        }
    }
}
