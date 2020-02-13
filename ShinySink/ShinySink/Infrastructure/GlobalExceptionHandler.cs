using System;
using ReactiveUI;
using Shiny;
using Shiny.Logging;


namespace Samples
{
    public class GlobalExceptionHandler : IObserver<Exception>, IShinyStartupTask
    {

        public GlobalExceptionHandler()
        {

        }


        public void Start() => RxApp.DefaultExceptionHandler = this;
        public void OnCompleted() {}
        public void OnError(Exception error) {}


        public void OnNext(Exception value)
        {
            Log.Write(value);
        }
    }
}