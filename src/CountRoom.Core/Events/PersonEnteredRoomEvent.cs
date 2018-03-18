using CountRoom.Core.Models;

namespace CountRoom.Core.Events
{
    public class PersonEnteredRoomEvent : IEvent
    {
        public Room Room { get; private set; }
        public PersonEnteredRoomEvent (Room room)
        {
            Room = room;
        }
    }
}