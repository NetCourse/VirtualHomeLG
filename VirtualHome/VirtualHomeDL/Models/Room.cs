namespace VirtualHomeDL.Models
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

        public string Name { get; set; }

        public RoomType Type { get; set; }

        public int RoomId { get; set; }
    }
}