using System;
using System.Text.RegularExpressions;

namespace TestVH
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

        //public string name { get; set; }

        //public string Name
        //{
        //    get
        //    {
        //        return Name;
        //    }
        //    private set
        //    {
        //        if (Regex.isMatch(name, "[A-Z]+"))
        //        {
        //            this.Name = value;
        //        }
        //    }
        //}

        public Room(string name, RoomType type)
        {
            Name = name;
            Type = type;
        }
    }
}

