using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class AuditTrail
    {
        public void Record()
        {
            Console.WriteLine("Audit");
        }
    }
}
