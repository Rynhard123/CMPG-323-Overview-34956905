using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using DeviceManagement_WebApp.Data;
using System.Linq;


namespace DeviceManagement_WebApp.Repository
{
    public class ZonesRepo : GenericRepo<Zone>, IZonesRepo
    {
        public ZonesRepo(Proj3_AppDevContext Proj3_AppDevContext) : base(Proj3_AppDevContext)
        {
        }
        public Zone GetZoneById(Guid? id)
        {
            return GetAll().FirstOrDefault(x => x.ZoneId == id);
        }
        public IEnumerable<Zone> GetAllZones()
        {
            return GetAll().ToList();
        }
        public void AddZone(Zone entity)
        {
            Add(entity);
        }
        public void RemoveZone(Zone entity)
        {
            Remove(entity);
        }
        public void UpdateZone(Zone entity)
        {
            Update(entity);
        }

    }
}
