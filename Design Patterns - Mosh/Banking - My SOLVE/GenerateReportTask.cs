using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class GenerateReportTask : Task
    {

        public GenerateReportTask(AuditTrail audit) : base(audit)
        {
        }

        public override void Execute()
        {
            AuditTrail.Record();

            Console.WriteLine("Generate Report");

        }
    }
}
