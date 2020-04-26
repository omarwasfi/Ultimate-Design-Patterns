using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            AddData( new CompressedCloudStream( new EncryptedCloudStream(new CloudStream())));

        }

        public static void AddData(Stream stream)
        {
            stream.Write("Hi It's me");
        }
        
    }
}
