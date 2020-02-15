using System;
using System.Threading.Tasks;
using Shiny.Notifications;


namespace ShinySink.Delegates
{
    public class MyNotificationDelegate : INotificationDelegate
    {
        public Task OnEntry(NotificationResponse response)
        {
            return Task.CompletedTask;
        }

        public Task OnReceived(Notification notification)
        {
            return Task.CompletedTask;
        }
    }
}
