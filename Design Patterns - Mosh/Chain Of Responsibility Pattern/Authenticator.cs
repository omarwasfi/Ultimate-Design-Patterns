using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Pattern
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Authentication");
            Boolean isValid = (request.Username == "admin" &&
                                request.Password == "1234");

            return !isValid;
        }

       
    }
}
