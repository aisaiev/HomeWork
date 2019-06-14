using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class SmartHome
    {
        private List<Device> devices;

        public void AddDevice(Device device)
        {
            if (device != null)
            {
                this.devices.Add(device);
            }
        }

        public void RemoveDeviceByName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                devices.Remove(devices.Find(x => x.Name == name));
            }
        }

        public List<Device> GetAllDevices()
        {
            return this.devices;
        }

        public SmartHome()
        {
            this.devices = new List<Device>();
        }
    }
}
