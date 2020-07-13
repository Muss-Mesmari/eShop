using eShop.Infrastructure.Database;
using eShop.Entities.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Linq;
using eShop.Presentation.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Services
{
    public class LocationService : ILocationService
    {

        private readonly eShopDbContext _eShopDbContext;

        public LocationService(eShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public IEnumerable<Location> AllLocations => _eShopDbContext.Location;

        public Location GetLocationById(int? eventId)
        {
            var locationId = _eShopDbContext.Events.FirstOrDefault(e => e.EventId == eventId).LocationId;
            var location = _eShopDbContext.Location.FirstOrDefault(l => l.LocationId == locationId);

            var entity = _eShopDbContext.Entry(location);
            entity.State = EntityState.Detached;

            return location;
        }

        public void CreateLocation(EventCreateEditViewModel newEvent)
        {
            var _newLocation = new Location()
            {
                Street = newEvent.Location.Street,
                StreetNumber = newEvent.Location.StreetNumber,
                City = newEvent.Location.City,
                State = newEvent.Location.State,
                ZipCode = newEvent.Location.ZipCode
            };
            _eShopDbContext.Location.Add(_newLocation);
            _eShopDbContext.SaveChanges();
        }

        public void UpdateLocation(EventCreateEditViewModel newEvent)
        {
            var eventId = newEvent.Event.EventId;
            var location = GetLocationById(eventId);

            var newLocation = newEvent.Location;
            if (newLocation != null)
            {
                newLocation.LocationId = location.LocationId;
                newLocation.Street = newLocation.Street;
                newLocation.StreetNumber = newLocation.StreetNumber;
                newLocation.City = newLocation.City;
                newLocation.State = newLocation.State;
                newLocation.ZipCode = newLocation.ZipCode;
            }

            var entity = _eShopDbContext.Entry(newLocation);
            entity.State = EntityState.Modified;
            _eShopDbContext.SaveChanges();
        }

        public void DeleteLocation(int locationId)
        {
            //var removedLocation = GetLocationById(id);
           
            var removedLocation = _eShopDbContext.Location.FirstOrDefault(l => l.LocationId == locationId);

            if (removedLocation != null)
            {
                _eShopDbContext.Remove(removedLocation);
                _eShopDbContext.SaveChanges();
            }
        }

    }
}
