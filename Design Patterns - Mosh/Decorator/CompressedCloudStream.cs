using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CompressedCloudStream : Stream
    {
        private Stream stream;

        public CompressedCloudStream(Stream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            string compress = Compress(data);
            stream.Write(compress);
        }

        private String Compress(string data)
        {
            return "<><><><><" + data;
        }
    }
}
