using Android.App;
using Android.Runtime;
using Shiny;
using System;


namespace ShinySink.Droid
{
    [Application]
    public class MainApplication : ShinyAndroidApplication<ShinySinkStartup>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}