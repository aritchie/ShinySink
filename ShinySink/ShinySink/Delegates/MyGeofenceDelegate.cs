using System;
using System.Threading.Tasks;
using Shiny.Locations;
using Shiny.Notifications;


namespace ShinySink.Delegates
{
    public class MyGeofenceDelegate : IGeofenceDelegate
    {
        readonly INotificationManager notificationManager;


        public MyGeofenceDelegate(INotificationManager notificationManager)
        {
            this.notificationManager = notificationManager;
        }


        public async Task OnStatusChanged(GeofenceState newStatus, GeofenceRegion region)
        {
            var notification = new Notification
            {
                Title = "WELCOME TO THE CN Tower",
                Message = "What would you like to do",
                Category = region.Identifier // cn tower
            };

            if (newStatus == GeofenceState.Exited)
            {
                notification.Title = "CN Tower says Good-bye!";
                notification.Message = "BYE";
                notification.Category = null;
            }
            
            await this.notificationManager.Send(notification);
        }
    }
}
