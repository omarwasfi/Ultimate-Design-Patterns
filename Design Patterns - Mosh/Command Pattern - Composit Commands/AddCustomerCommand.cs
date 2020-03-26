using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern___Composit_Commands
{
    public class AddCustomerCommand : Command
    {
        private CustomerService CustomerService { get; set; }


        public AddCustomerCommand( CustomerService customerService)
        {
            this.CustomerService = customerService;
        }

        public void Execute()
        {
            CustomerService.AddCustomer();
        }
    }
}
