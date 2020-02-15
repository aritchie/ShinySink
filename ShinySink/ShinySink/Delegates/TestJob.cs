using System;
using System.Threading;
using System.Threading.Tasks;
using Shiny;
using Shiny.Jobs;
using Shiny.Notifications;


namespace ShinySink.Delegates
{
    public class TestJob : IJob
    {
        readonly IStupidService heyStupid;
        readonly INotificationManager notifications;
        readonly AppSettings appSettings;


        public TestJob(INotificationManager notifications,
                       AppSettings appSettings,
                       IStupidService heyStupid,
                       IEnvironment environment)
        {
            this.heyStupid = heyStupid;
            this.appSettings = appSettings;
            this.notifications = notifications;
        }


        public async Task<bool> Run(JobInfo jobInfo, CancellationToken cancelToken)
        {
            var notification = new Notification
            {
                Title = "Shiny Sink",
                Message = "Hey Stupid is starting"
            };
            await this.notifications.Send(notification);

            if (this.appSettings.FireHeyStupid)
                await this.heyStupid.Pause();

            await this.notifications.Send("Shiny Sink", "Hey Stupid is finished");
            return true;
        }
    }
}
