using System.Threading.Tasks;
using CountRoom.Core.Bus;
using CountRoom.Core.Events;
using MediatR;

namespace CountRoom.Infra.Bus
{
    public class MediatorBus : IBus
    {
        private readonly IMediator _mediator;

        public MediatorBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task RaiseEventAsync<TEvent>(TEvent @event) where TEvent : IEvent
        {
            return _mediator.Publish(@event);
        }
    }
}