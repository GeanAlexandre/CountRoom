namespace CountRoom.Core.Models
{
    public class Room
    {
        public string Id { get; private set; }
        public int PeopleNumbers { get; private set; }
        public Room (string id, int peopleNumbers)
        {
            Id = id;
            PeopleNumbers = peopleNumbers;
        }
    }
}