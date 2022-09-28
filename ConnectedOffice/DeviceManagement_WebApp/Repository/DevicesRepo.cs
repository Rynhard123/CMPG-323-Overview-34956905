using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DeviceManagement_WebApp.Repository
{
    public class DevicesRepo : GenericRepo<Device>, IDevicesRepo
    {
        public DevicesRepo(Proj3_AppDevContext Proj3_AppDevContext) : base(Proj3_AppDevContext)
        {
        }
        public Device GetDeviceById(Guid? id)
        {
            return GetAll().FirstOrDefault(x => x.DeviceId == id);
        }
        public IEnumerable<Device> GetAllDevices()
        {
            return GetAll().ToList();
        }
        public void AddDevice(Device entity)
        {
            Add(entity);
        }
        public void RemoveDevice(Device entity)
        {
            Remove(entity);
        }
        public void UpdateDevice(Device entity)
        {
            Update(entity);
        }
    }
}
