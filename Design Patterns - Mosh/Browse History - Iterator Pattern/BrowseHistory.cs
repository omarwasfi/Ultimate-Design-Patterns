using System;
using System.Collections.Generic;
using System.Text;

namespace Browse_History___Iterator_Pattern
{
    public class BrowseHistory
    {
        private List<string> Urls { get; set; }


        public BrowseHistory()
        {
            Urls = new List<string>();
        }

        public void Push(string Url)
        {
            Urls.Add(Url);
        }

        public Iterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : Iterator<string>
        {
            private BrowseHistory history;
            private int index;

            public ListIterator(BrowseHistory history)
            {
                this.history = history;
            }

            public string Current()
            {
                return history.Urls[index];
            }

            public bool HasNext()
            {
                return (index < history.Urls.Count);
            }

            public void Next()
            {
                index++;
            }
        }


    }
}
