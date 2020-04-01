using System;

namespace Observer_Pattern
{
    class Program
    {
        /// <summary>
        /// Best style in this case
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DataSource dataSource = new DataSource();
            SpreadSheet sheet1 = new SpreadSheet(dataSource);
            SpreadSheet sheet2 = new SpreadSheet(dataSource);
            Chart chart = new Chart(dataSource);

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);

            dataSource.SetValue(55);
        }
    }
}
