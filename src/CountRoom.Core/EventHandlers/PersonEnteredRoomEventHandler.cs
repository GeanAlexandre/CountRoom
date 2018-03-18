using System.Threading;
using System.Threading.Tasks;
using CountRoom.Core.Events;

namespace CountRoom.Core.EventHandlers
{
    public class PersonEnteredRoomEventHandler : IEventHandler<PersonEnteredRoomEvent>
    {
        public Task Handle(PersonEnteredRoomEvent notification, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}