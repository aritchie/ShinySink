using System;
using System.Threading.Tasks;
using Shiny.Notifications;


namespace ShinySink.Delegates
{
    public class MyNotificationDelegate : INotificationDelegate
    {
        readonly INotificationManager notificationManager;


        public MyNotificationDelegate(INotificationManager notificationManager)
        {
            this.notificationManager = notificationManager;
        }


        public async Task OnEntry(NotificationResponse response)
        {
            // the user responded
            switch (response.ActionIdentifier)
            {
                case "message":

                    break;

                case "ticket":
                    break;
            }
        }


        public Task OnReceived(Notification notification)
        {
            // the notification was received
            return Task.CompletedTask;
        }
    }
}
