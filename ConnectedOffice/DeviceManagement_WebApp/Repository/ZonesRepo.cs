using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository : GenericRepo<Zone>, IZonesRepo
    {
        public ZoneRepository(Proj3_AppDevContext Proj3_AppDevContext) : base(Proj3_AppDevContext)
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

        System.Security.Policy.Zone IZonesRepo.GetZoneById(Guid? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<System.Security.Policy.Zone> IZonesRepo.GetAllZones()
        {
            throw new NotImplementedException();
        }

        public void AddZone(System.Security.Policy.Zone entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveZone(System.Security.Policy.Zone entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateZone(System.Security.Policy.Zone entity)
        {
            throw new NotImplementedException();
        }

        System.Security.Policy.Zone IGenericRepo<System.Security.Policy.Zone>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<System.Security.Policy.Zone> IGenericRepo<System.Security.Policy.Zone>.GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<System.Security.Policy.Zone> Find(Expression<Func<System.Security.Policy.Zone, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Add(System.Security.Policy.Zone entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<System.Security.Policy.Zone> entities)
        {
            throw new NotImplementedException();
        }

        public void Remove(System.Security.Policy.Zone entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<System.Security.Policy.Zone> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(System.Security.Policy.Zone entity)
        {
            throw new NotImplementedException();
        }
    }
}
