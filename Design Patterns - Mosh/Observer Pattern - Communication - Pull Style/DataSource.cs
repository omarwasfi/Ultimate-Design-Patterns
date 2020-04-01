using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class DataSource : Subject
    {
        private int Value;


        public void SetValue(int value)
        {
            this.Value = value;
            NotifyObservers();
        }

        public int GetValue()
        {
            return Value;
        }
    }
}
