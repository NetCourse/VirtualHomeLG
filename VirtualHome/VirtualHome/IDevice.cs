using System;

namespace TestVH.Interface
{
    interface IDevice
    {
        Guid DeviceID { get; }

        void AssignRoom(Room room);

        void TurnOnDevice();

        void TurnOffDevice();
    }
}
