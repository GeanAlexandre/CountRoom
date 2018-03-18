using System.Threading.Tasks;
using CountRoom.Core.Events;
using MediatR;

namespace CountRoom.Core.EventHandlers
{
    public interface IEventHandler<in TEvent> : INotificationHandler<TEvent>
        where TEvent : IEvent
    {
    }
}