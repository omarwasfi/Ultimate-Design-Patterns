using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AuditTrail audit = new AuditTrail();

            TransferMoneyTask transferMoney = new TransferMoneyTask(audit);

            transferMoney.Execute();
        }
    }
}
