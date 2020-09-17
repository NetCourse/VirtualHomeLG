namespace VirtualHomeBL
{
    class Program
    {
        static void Main(string[] args)
        {
            //DeviceManager deviceManager = DeviceManager.GetInstance();

            HouseBuilder Cave = new HouseBuilder();
            Cave.AddRooom(new Room("Kitchen", Room.RoomType.Kitchen));
            Cave.AddRooom(new Room("Bathroom", Room.RoomType.Bathroom));
            Cave.AddRooom(new Room("Bedroom", Room.RoomType.Bedroom));
            Cave.AddRooom(new Room("Livingroom", Room.RoomType.Livingroom));

            Cave.PrintRoomList(); // how to print room name?

            //deviceManager.AddDevice(new Room("Kitchen", Room.RoomType.Kitchen), deviceManager.AddDevice());
        }
    }
}
