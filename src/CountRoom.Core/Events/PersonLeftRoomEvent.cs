using CountRoom.Core.Models;

namespace CountRoom.Core.Events
{
    public class PersonLeftRoomEvent : IEvent
    {
        public Room Room { get; set; }
        public PersonLeftRoomEvent (Room room)
        {
            Room = room;
        }
    }
}