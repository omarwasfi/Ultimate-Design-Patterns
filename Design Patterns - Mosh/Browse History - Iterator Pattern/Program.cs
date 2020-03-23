using System;

namespace Browse_History___Iterator_Pattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BrowseHistory browseHistory = new BrowseHistory();
            browseHistory.Push("A");
            browseHistory.Push("b");
            browseHistory.Push("c");
            browseHistory.Push("d");
            browseHistory.Push("f");

            Iterator<string> iterator = browseHistory.CreateIterator();
            while (iterator.HasNext())
            {
                string url = iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }

           
        }
    }
}