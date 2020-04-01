using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern___My_SOLVE
{
    public class Chart : IUpdate
    {
        public void Update(DataSource dataSource)
        {
            Console.WriteLine("Chart Updated.. " + dataSource.GetValue()) ;
        }
    }
}
