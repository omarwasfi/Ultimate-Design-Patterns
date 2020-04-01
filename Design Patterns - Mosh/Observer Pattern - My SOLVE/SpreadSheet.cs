using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern___My_SOLVE
{
    public class SpreadSheet : IUpdate
    {
        public void Update(DataSource dataSource)
        {
            Console.WriteLine("SpreadSheet Updated.." + dataSource.GetValue() );
        }
    }
}
