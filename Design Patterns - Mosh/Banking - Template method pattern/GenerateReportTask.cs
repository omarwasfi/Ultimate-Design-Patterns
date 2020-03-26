using System;

namespace TemplateMethodPattern
{
    public class GenerateReportTask : Task
    {
        public GenerateReportTask()
        {
        }

        public GenerateReportTask(AuditTrail audit) : base(audit)
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Generate Report");
        }
    }
}