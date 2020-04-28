using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public class NotifivationServer
    {
        public Connection Connect(string ipAddress)
        {
            return new Connection();
        }

        public AuthToken Authenticate(string appId , string key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken authToken , Message message , string target)
        {
            Console.WriteLine("Sending a message");
        }
    }
}
