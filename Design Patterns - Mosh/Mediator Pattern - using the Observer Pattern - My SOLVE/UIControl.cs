using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_Pattern
{
    public abstract class UIControl 
    {

        private List<EventHandler> EventHandlers { get; set; } = new List<EventHandler>();

        public UIControl()
        {
            //EventHandlers = new List<EventHandler>();
        }

        public void AddEventHandler(EventHandler observer)
        {
            EventHandlers.Add(observer);
        }

        protected void NotifyEventHandlers()
        {
            foreach(EventHandler observer in EventHandlers)
            {
                observer.Handle();
            }
        }
    }
}
