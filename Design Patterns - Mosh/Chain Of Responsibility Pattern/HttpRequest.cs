using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Pattern
{
    public class HttpRequest
    {
        public string Username { get; private set; }

        public string Password { get; private set; }

        public HttpRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }


    }
}
