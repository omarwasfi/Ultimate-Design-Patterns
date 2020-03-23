using System;
using StartegyPattern.Filter_Types;

namespace StartegyPattern
{
    class Program
    {
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
