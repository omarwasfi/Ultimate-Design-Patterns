using System;

namespace Command_Pattern___Composit_Commands
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerService service = new CustomerService();
            Command command = new AddCustomerCommand(service);

            Button button = new Button(command);
            button.Click();

            CompositCommand Composit = new CompositCommand();
            Composit.Add(new BlackAndWhiteCommand());
            Composit.Add(new ResizeCommand());
            Composit.Add(new AddCustomerCommand(new CustomerService()));
            Composit.Execute();
        }
    }
}
