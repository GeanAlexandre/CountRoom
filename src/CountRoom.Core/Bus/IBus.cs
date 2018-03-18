using System.Threading.Tasks;
using CountRoom.Core.Events;

namespace CountRoom.Core.Bus
{
    public interface IBus
    {
        Task RaiseEventAsync<TEvent>(TEvent @event)
        where TEvent : IEvent;
    }
}