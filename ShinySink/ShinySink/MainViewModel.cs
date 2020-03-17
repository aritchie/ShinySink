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


        public ICommand JobPermissions { get; }

        string text = String.Empty;
        public string JobPermissionText
        {
            get => this.text;
            private set => this.Set(ref this.text, value);
        }
    }
}
