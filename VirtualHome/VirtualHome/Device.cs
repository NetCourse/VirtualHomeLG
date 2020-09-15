using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome
{
    class Device
    {
        private string name;

        public Device(string Name)
        {
            this.Name = Name;
        }

        public string Name { get => name; set => name = value; }

    }
}
