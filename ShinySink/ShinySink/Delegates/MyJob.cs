using System;
using System.Threading;
using System.Threading.Tasks;
using Shiny.Jobs;
using Shiny.Notifications;


namespace ShinySink.Delegates
{
    public class MyJob : IJob
    {
        readonly INotificationManager notificationManager;


        public MyJob(INotificationManager notificationManager)
        {
            this.notificationManager = notificationManager;
        }


        public async Task<bool> Run(JobInfo jobInfo, CancellationToken cancelToken)
        {
            await this.notificationManager.Send("Hello From Shiny", "PSST - I ran in the background");
            return true;
        }
    }
}
