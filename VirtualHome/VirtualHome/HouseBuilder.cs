using System;
using System.Collections.Generic;

namespace TestVH
{
    public class HouseBuilder
    {
        public List<Room> House = new List<Room>();

        public void AddRooom(Room room)
        {
            House.Add(room);
        }

        public List<Room> GetRoomList()
        {
            return House;
        }

        public void PrintRoomList()
        {
            House.ForEach(Console.Write);
        }
    }
}
