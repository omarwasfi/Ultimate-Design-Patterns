using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern___Graphical_User_Interface___My_SOLVE
{
    public abstract class UIElement
    {
        protected string Label { get; set; }
        
        public UIElement(string label)
        {
            this.Label = label;
        }

        public  void Clicked()
        {
            Console.WriteLine("Element Clicked !! , with label : "+ Label);

            BeClicked();
        }

        protected abstract void BeClicked();
    }
}
