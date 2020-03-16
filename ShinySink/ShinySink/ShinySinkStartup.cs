using System;
using Microsoft.Extensions.DependencyInjection;
using Shiny;
using Shiny.Jobs;
using Shiny.Locations;
using Shiny.Notifications;
using ShinySink.Delegates;


namespace ShinySink
{
    public class ShinySinkStartup : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.RegisterJob(new JobInfo(typeof(MyJob))
            {
                RequiredInternetAccess = InternetAccess.Any,
                Repeat = true,
                DeviceCharging = false,
                BatteryNotLow = true
            });

            services.UseGeofencing<MyGeofenceDelegate>(true);

            services.UseNotifications<MyNotificationDelegate>(
                true,
                notificationCategories: new[] {
                    new NotificationCategory(
                        "cntower",
                        new NotificationAction(
                            "message",
                            "Leave A Message",
                            NotificationActionType.TextReply
                        ),
                        new NotificationAction(
                            "ticket",
                            "Free Ticket!",
                            NotificationActionType.None
                        )
                    )
                }
            );
        }


        public override void ConfigureApp(IServiceProvider services)
        {
            base.ConfigureApp(services);
            services.Resolve<IGeofenceManager>().StartMonitoring(new GeofenceRegion(
                "CNTower",
                new Position(1, 1),
                Distance.FromMeters(500)
            ));
        }
    }
}
