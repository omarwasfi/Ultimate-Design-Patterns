using System;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerService service = new CustomerService();
            Command command = new AddCustomerCommand(service);

            Button button = new Button(command);
            button.Click();
        }
    }
}
