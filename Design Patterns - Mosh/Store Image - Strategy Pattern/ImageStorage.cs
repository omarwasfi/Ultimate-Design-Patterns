using System;
using System.Collections.Generic;
using System.Text;

namespace StartegyPattern
{
    public class ImageStorage
    {
        public string FileName { get; set; }


        public ImageStorage(string FileName)
        {
            this.FileName = FileName;
        }
        

         public void Store(ICompressor compressor )
        {
            compressor.Compress(this.FileName);
        }

        public void Filter(IFilter filter)
        {
            filter.Filter(this.FileName);
        }
    }
}
