using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public abstract class Task
    {
        protected AuditTrail AuditTrail { get; set; }

        public Task(AuditTrail audit)
        {
            this.AuditTrail = audit;
        }

        public abstract void Execute();
        
    }
}
