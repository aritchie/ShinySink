using System;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;


namespace ShinySink
{
    public class AppSettings : ReactiveObject
    {
        public AppSettings()
        {
            this.FireHeyStupid = true;
        }


        [Reactive] public bool FireHeyStupid { get; set; }
    }
}
