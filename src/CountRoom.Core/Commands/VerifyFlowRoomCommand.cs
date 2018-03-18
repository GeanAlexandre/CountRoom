namespace CountRoom.Core.Commands
{
    public class VerifyFlowRoomCommand : ICommand
    {
        public string RoomId { get; set; }
        public int SensorOne { get; set; }
        public int SensorTwo { get; set; }
    }
}