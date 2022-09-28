
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZonesRepo : IGenericRepo<Zone>
    {
        Zone GetZoneById(Guid? id);
        IEnumerable<Zone> GetAllZones();
        void AddZone(Zone entity);
        void RemoveZone(Zone entity);
        void UpdateZone(Zone entity);
        
    }
}
