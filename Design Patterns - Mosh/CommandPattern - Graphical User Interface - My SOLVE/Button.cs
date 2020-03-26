using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern___Graphical_User_Interface___My_SOLVE
{
    public class Button : UIElement
    {
        public Button(string label) : base(label)
        {

        }

        protected override void BeClicked()
        {
            Console.WriteLine("Click Like button , My label is: " + Label);
        }
    }
}
