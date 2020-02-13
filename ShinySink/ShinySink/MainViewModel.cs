using System;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Shiny.Jobs;


namespace ShinySink
{
    public class MainViewModel : ViewModel
    {
        readonly IJobManager jobs;


        public MainViewModel(IJobManager jobs)
        {
            this.jobs = jobs;

            this.JobPermissions = ReactiveCommand.CreateFromTask(async () =>
            {
                var access = await this.jobs.RequestAccess();
                this.JobPermissionText = access.ToString();
            });
        }


        [Reactive] public string JobPermissionText { get; private set; } = "Unknown";
        public ICommand JobPermissions { get; }
    }
}
