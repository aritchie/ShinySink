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
        readonly AppSettings appSettings;


        public MainViewModel(IJobManager jobs, AppSettings appSettings)
        {
            this.jobs = jobs;
            this.appSettings = appSettings;

            this.JobPermissions = ReactiveCommand.CreateFromTask(async () =>
            {
                var access = await this.jobs.RequestAccess();
                this.JobPermissionText = access.ToString();
            });
        }


        [Reactive] public string JobPermissionText { get; private set; } = "Unknown";
        public bool FireHeyStupid
        {
            get => this.appSettings.FireHeyStupid;
            set => this.appSettings.FireHeyStupid = value;
        }

        public ICommand JobPermissions { get; }        
    }
}
