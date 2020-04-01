using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern___My_SOLVE
{
    public class DataSource
    {
        private int Value { get; set; }

        private IUpdate update { get; set; }

        public void SetValue(int value,IUpdate updatedElement)
        {
            this.Value = value;
            this.update = updatedElement;
            UpdateAllElements();
        }

        public int GetValue()
        {
            return Value;
        }

        public void UpdateAllElements()
        {
            update.Update(this);
        }

        public DataSource()
        {
            this.Value = new int();
            
        }



    }
}
