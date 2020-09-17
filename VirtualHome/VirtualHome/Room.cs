namespace VirtualHomeBL
{
    public class Room
    {
        public enum RoomType
        {
            Kitchen = 1,
            Bathroom = 2,
            Livingroom = 3,
            Bedroom = 4,
        }

        public string Name { get; }

        public RoomType Type { get; }      

        public Room(string name, RoomType type)
        {
            Name = name;
            Type = type;
        }
    }
}

