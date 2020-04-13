using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Pattern
{
    public abstract class Handler
    {
        private Handler Next { get; set; }

        public Handler(Handler next)
        {
            this.Next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request) == true)
                return;
   

            if(Next != null)
                Next.Handle(request);
        }

        public abstract Boolean DoHandle(HttpRequest request);



    }
}
