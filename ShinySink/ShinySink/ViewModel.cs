using System;
using ReactiveUI;

namespace ShinySink
{
    public class ViewModel : ReactiveObject
    {
        public void Set<T>(ref T backingStore, T value)
            => this.RaiseAndSetIfChanged(ref backingStore, value);
    }
}
