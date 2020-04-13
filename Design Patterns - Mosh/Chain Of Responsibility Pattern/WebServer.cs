using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Pattern
{
    public class WebServer
    {
        private Handler Handler { get; set; }

        public WebServer(Handler handler)
        {
            this.Handler = handler;
        }
        public void Handle(HttpRequest httpRequest)
        {
            Handler.Handle(request: httpRequest);
        }
    }
}
