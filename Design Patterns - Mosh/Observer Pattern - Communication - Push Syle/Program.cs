using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSource dataSource = new DataSource();
            SpreadSheet sheet1 = new SpreadSheet();
            SpreadSheet sheet2 = new SpreadSheet();
            Chart chart = new Chart();

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);

            dataSource.SetValue(55);
        }
    }
}
