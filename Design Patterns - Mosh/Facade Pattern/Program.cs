using System;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService();
            notificationService.Send("Hello world", "target");
        }
    }
}
