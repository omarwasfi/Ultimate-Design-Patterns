using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class EncryptedCloudStream : Stream
    {
        private Stream stream;

        public EncryptedCloudStream(Stream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            string compress = Encrypt(data);
            stream.Write(compress);
        }

        private String Encrypt(string data)
        {
            return "(^&$*^%(#!@%&*" + data ;
        }
    }
}
