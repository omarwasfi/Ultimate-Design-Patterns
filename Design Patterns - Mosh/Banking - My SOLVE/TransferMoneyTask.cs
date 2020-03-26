using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class TransferMoneyTask : Task
    {
        public TransferMoneyTask(AuditTrail audit) : base(audit)
        {
        }

        public override void Execute()
        {
            AuditTrail.Record();

            Console.WriteLine("Transfer Money");
        }
    }
}
