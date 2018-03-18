using System.Threading.Tasks;
using CountRoom.Core.Bus;
using CountRoom.Core.Commands;
using CountRoom.Core.EventHandlers;
using CountRoom.Core.Events;

namespace CountRoom.Core.CommandHandlers
{
    public class VerifyFlowRoomCommandHandler : ICommandHandler<VerifyFlowRoomCommand>
    {
        private readonly IBus _bus;
        public VerifyFlowRoomCommandHandler(IBus bus)
        {
            _bus = bus;
        }

        public Task HandleAsync(ICommand command)
        {
            return _bus.RaiseEventAsync(new PersonEnteredRoomEvent(null));
        }
    }
}