using StartegyPattern.Filter_Types;
using System;

namespace StartegyPattern
{
    class Program
    {
        /// <summary>
        /// To store any Image we need to compress it or apply any filters and so on.. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ICompressor compressor = new PNG();
            ImageStorage imageStorage = new ImageStorage("ALI");
            imageStorage.Store(compressor);


            ICompressor compressor2 = new JPEG();
            ImageStorage imageStorage2 = new ImageStorage("LK");
            imageStorage2.Store(compressor2);


            IFilter larkFilter = new Lark();
            imageStorage.Filter(larkFilter);
            imageStorage2.Filter(larkFilter);


        }
    }
}
