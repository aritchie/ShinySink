using System;
using Foundation;
using Shiny;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


namespace ShinySink.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            this.ShinyFinishedLaunching(new ShinySinkStartup());
            Forms.Init();
            this.LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }


        public override void PerformFetch(UIApplication application, Action<UIBackgroundFetchResult> completionHandler)
            => this.ShinyPerformFetch(completionHandler);
    }
}
