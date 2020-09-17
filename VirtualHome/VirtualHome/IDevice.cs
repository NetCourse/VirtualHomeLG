using System;

namespace VirtualHomeBL
{
    interface IDevice
    {
        Guid DeviceID { get; }

        void AssignRoom(Room room);

        void TurnOnDevice();

        void TurnOffDevice();
    }
}
