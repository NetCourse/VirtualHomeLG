using System;
using TestVH.Interface;

namespace TestVH
{
    public abstract class Device : IDevice
    {
        public string DeviceName { get; private set; }

        public bool Status { get; private set; }

        public Room Location { get; private set; }

        public Guid DeviceID { get; }

        public Device(string deviceName)
        {
            DeviceName = deviceName;
            DeviceID = Guid.NewGuid();
        }

        public void AssignRoom(Room room)
        {
            Location = room;
        }
        //public void AssignRoom(Room room) => Location = room;

        public void TurnOffDevice()
        {
            Status = false;
        }
        //public void TurnOffDevice() => Status = false;

        public void TurnOnDevice()
        {
            Status = true;
        }
        //public void TurnOffDevice() => Status = true;
    }
}
