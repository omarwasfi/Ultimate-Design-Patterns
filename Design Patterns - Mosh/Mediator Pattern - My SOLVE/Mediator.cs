using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    /// <summary>
    /// if textBox.content.isnotEmpty -> button is enabled
    /// </summary>
    public class Mediator : UIControl
    {
        public override void Update(ListBox listBox)
        {
            if(listBox.Selection.Length > 0)
            {
                // Update  the button and textBox
            }
        }


    }
}
