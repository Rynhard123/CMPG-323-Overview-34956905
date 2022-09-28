using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;

namespace DeviceManagement_WebApp.Repository
{
    public interface IDevicesRepo : IGenericRepo<Device>
    {
        Device GetDeviceById(Guid? id);
        IEnumerable<Device> GetAllDevices();
        void AddDevice(Device entity);
        void RemoveDevice(Device entity);
        void UpdateDevice(Device entity);
    }
}
