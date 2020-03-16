using System;
using Android.App;
using Android.Runtime;
using Shiny;

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