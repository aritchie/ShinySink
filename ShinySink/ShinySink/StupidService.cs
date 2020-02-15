using System;
using System.Threading.Tasks;

namespace ShinySink
{

    public interface IStupidService
    {
        Task Pause();
    }


    public class StupidService : IStupidService
    {
        public Task Pause() => Task.Delay(5000);
    }
}
