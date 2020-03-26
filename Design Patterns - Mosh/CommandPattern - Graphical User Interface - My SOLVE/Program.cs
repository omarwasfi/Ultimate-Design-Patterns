using System;

namespace CommandPattern___Graphical_User_Interface___My_SOLVE
{
    class Program
    {   
        /// <summary>
        /// Each class has the same method Click ,  but they run deffrant code 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Button button = new Button("BT1");

            button.Clicked();

            // Exactily like the template Pattern !

        }
    }
}
