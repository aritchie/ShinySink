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
            await this.notificationManager.Send(new Notification
            {
                Title = "WELCOME to the CN Tower",
                Message = "What would you like to do?",
                Category = region.Identifier // cntower
            });
        }
    }
}
