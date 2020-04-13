using System;

namespace Chain_Of_Responsibility_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Compressor compressor = new Compressor(null);
            Logger logger = new Logger(compressor);
            Authenticator authenticator = new Authenticator(logger);

            WebServer webServer = new WebServer(authenticator);
            HttpRequest httpRequest = new HttpRequest(username: "admin", password: "1234");
            webServer.Handle(httpRequest);
        }
    }
}
