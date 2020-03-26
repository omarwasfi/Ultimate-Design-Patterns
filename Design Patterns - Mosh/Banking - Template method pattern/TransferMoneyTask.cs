using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class TransferMoneyTask : Task
    {
        public TransferMoneyTask() { }
        public TransferMoneyTask(AuditTrail audit) : base(audit)
        {
        }

        protected override void DoExecute()
        {

            Console.WriteLine("Transfer Money");
        }
    }
}
