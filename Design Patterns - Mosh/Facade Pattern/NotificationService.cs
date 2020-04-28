using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    class NotificationService
    {
        public void Send(string message , string target)
        {
            NotifivationServer server = new NotifivationServer();
            Connection connection = server.Connect("ip");
            AuthToken authToken = server.Authenticate("appId", "Key");
            server.Send(authToken,new Message(message), target);
            connection.Disconnect();
        }
    }
}
