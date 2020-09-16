using System.Collections.Generic;

namespace TestVH.Services
{
    public class DeviceManager
    {
        private static readonly DeviceManager instance = new DeviceManager();

        public List<Device> DeviceList = new List<Device>();

        private DeviceManager()
        {
        }

        public static DeviceManager GetInstance()
        {
            if (instance != null)
            {
                return instance;
            }
            throw new System.ArgumentException("Class instance already exist");
        }
        //public static DeviceMenager CreateInstance1() => instance;

        public void AddDevice(Room room, Device device)
        {
            DeviceList.Add(device);
            device.AssignRoom(room);
        }

        public List<Device> GetDeviceList()
        {
            return DeviceList;
        }
    }
}
