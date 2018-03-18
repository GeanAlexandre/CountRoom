using System.Threading;
using System.Threading.Tasks;
using CountRoom.Core.Events;

namespace CountRoom.Core.EventHandlers
{
    public class PersonLeftRoomEventHandler : IEventHandler<PersonLeftRoomEvent>
    {
        public Task Handle(PersonLeftRoomEvent notification, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}