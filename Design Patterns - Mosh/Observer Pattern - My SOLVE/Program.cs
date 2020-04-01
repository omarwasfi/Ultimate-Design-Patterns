using System;

namespace Observer_Pattern___My_SOLVE
{
    class Program
    {
        static void Main(string[] args)
        {
            IUpdate elementToUpdate = new SpreadSheet();
            IUpdate elementToUpdate2 = new Chart();

            DataSource dataSource = new DataSource();
            dataSource.SetValue(15, elementToUpdate);
            dataSource.SetValue(17, elementToUpdate2);

        }
    }
}
