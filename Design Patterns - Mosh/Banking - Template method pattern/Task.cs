using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public abstract class Task
    {
        private AuditTrail AuditTrail { get; set; }

        public Task()
        {
            this.AuditTrail = new AuditTrail();
        }

        public Task(AuditTrail audit)
        {
            this.AuditTrail = audit;
        }

        public void Execute()
        {
            AuditTrail.Record();

            DoExecute();
        }

        protected abstract void DoExecute();
        
    }
}
