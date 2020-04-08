using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public abstract class UIControl
    {
        private List<UIControl> observers = new List<UIControl>();

        public void AddObserver(UIControl observer)
        {
            observers.Add(observer);
        }

        public void ReamoveObserver(UIControl observer)
        {
            observers.Remove(observer);
        }


        public void NotifyObservers(ListBox listBox)
        {
            foreach (UIControl observer in observers)
            {
                observer.Update(listBox);
            }
        }

        

        public abstract void Update(ListBox listBox);
    }
}
