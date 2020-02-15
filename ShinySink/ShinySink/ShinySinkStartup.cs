using Microsoft.Extensions.DependencyInjection;
using Shiny;
using Shiny.Notifications;
using Shiny.Prism;
using ShinySink.Delegates;

namespace ShinySink
{
    public class ShinySinkStartup : PrismStartup
    {
        protected override void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IStupidService, StupidService>();
            services.AddSingleton<AppSettings>();

            services.UseNotifications<MyNotificationDelegate>(
                true,
                null,
                null,
                new[] {
                    new NotificationCategory(
                        "test",
                        new NotificationAction(
                            "yes",
                            "Yes",
                            NotificationActionType.None
                        ),
                        new NotificationAction(
                            "no",
                            "No",
                            NotificationActionType.TextReply
                        )
                    )
                }
            );
            services.RegisterJob(new Shiny.Jobs.JobInfo(typeof(TestJob)));
        }
    }
}
