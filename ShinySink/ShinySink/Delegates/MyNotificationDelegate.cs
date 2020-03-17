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
                    await this.notificationManager.Send("CN Tower Message", $"Your message '{response.Text}' has been recorded!");
                    break;

                case "ticket":
                    await this.notificationManager.Send("CN Tower Ticket", "Check the app, you have a FREE ticket");
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
