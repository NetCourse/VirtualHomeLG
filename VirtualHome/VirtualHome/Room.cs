
namespace VirtualHome
{
    class Room
    {
        private string name;
        private string type;

        public Room(string Name)
        {
            this.name = Name;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
    }
}
