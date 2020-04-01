using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Chart : Observer
    {
        private DataSource DataSource;

        public Chart(DataSource dataSource)
        {
            this.DataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("Chart Notified ! "+ DataSource.GetValue());
        }
    }
}
