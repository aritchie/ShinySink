using System;
using System.Windows.Input;
using Shiny;
using Xamarin.Forms;


namespace ShinySink
{
    public class MainViewModel : ViewModel
    {

        public MainViewModel()
        {
            this.JobPermissions = new Command(async () =>
            {
                var access = await ShinyJobManager.RequestAccess();
                this.JobPermissionText = access.ToString();
            });
        }


        public string JobPermissionText { get; private set; } = "Unknown";
        public ICommand JobPermissions { get; }        
    }
}
