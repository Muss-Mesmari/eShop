using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using System.Collections.Generic;

namespace eShop.Infrastructure.Services
{
    public interface ILocationService
    {
        IEnumerable<Location> AllLocations { get; }
        void CreateLocation(int eventId, EventViewModel newEvent);
        void DeleteLocations(int locationId);
        IEnumerable<Location> GetLocationById(int? eventId);
        void UpdateLocation(int eventId, IEnumerable<Location> newLocations);
    }
}