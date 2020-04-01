using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void ReamoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }


        public void NotifyObservers()
        {
            foreach(Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
