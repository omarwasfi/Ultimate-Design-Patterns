using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Group : Component
    {
        List<Component> Components = new List<Component>();

        public void Add(Component component)
        {
            Components.Add(component);
        }

        public void Render()
        {
            foreach (Component component in Components)
            {
                component.Render();
            }
        }
    }
}
