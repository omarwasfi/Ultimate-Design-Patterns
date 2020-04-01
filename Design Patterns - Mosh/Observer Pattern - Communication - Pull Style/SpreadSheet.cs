using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class SpreadSheet:Observer
    {
        private DataSource DataSource;

        public SpreadSheet(DataSource dataSource)
        {
            this.DataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("Spread Sheet Notified ! " + DataSource.GetValue());
        }
    }
 
}
