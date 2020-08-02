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

        public IEnumerable<Location> GetLocationById(int? eventId)
        {
            var locations = _eShopDbContext.Location.Where(e => e.EventId == eventId).ToList();
            foreach (var location in locations)
            {
                var entity = _eShopDbContext.Entry(location);
                entity.State = EntityState.Detached;
            }
            return locations;
        }

        public void CreateLocation(int eventId, EventViewModel newEvent)
        {
            var _newLocation = new Location()
            {
                EventId = eventId,
                Street = newEvent.Location.Street,
                StreetNumber = newEvent.Location.StreetNumber,
                City = newEvent.Location.City,
                State = newEvent.Location.State,
                ZipCode = newEvent.Location.ZipCode
            };
            _eShopDbContext.Location.Add(_newLocation);
            _eShopDbContext.SaveChanges();
        }

        public void UpdateLocation(int eventId, IEnumerable<Location> newLocations)
        {
            var oldLocations = GetLocationById(eventId);
            var oldLocationsIds = oldLocations.Select(t => t.LocationId).ToList();

            var i = 0;
            foreach (var newLocation in newLocations)
            {
                if (newLocation != null)
                {
                    newLocation.EventId = eventId;
                    newLocation.LocationId = oldLocationsIds[i];
                    newLocation.Street = newLocation.Street;
                    newLocation.StreetNumber = newLocation.StreetNumber;
                    newLocation.City = newLocation.City;
                    newLocation.ZipCode = newLocation.ZipCode;
                    newLocation.State = newLocation.State;
                    i++;
                }

                var entity = _eShopDbContext.Entry(newLocation);
                entity.State = EntityState.Modified;
                _eShopDbContext.SaveChanges();
            }
        }

        public void DeleteLocations(int id)
        {                       
            var removedLocation = GetLocationById(id);

            if (removedLocation != null)
            {
                foreach (var location in removedLocation)
                {
                    _eShopDbContext.Remove(location);
                    _eShopDbContext.SaveChanges();
                }
            }
        }

    }
}
