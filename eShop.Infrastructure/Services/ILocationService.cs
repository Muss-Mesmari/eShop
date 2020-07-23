﻿using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using System.Collections.Generic;

namespace eShop.Infrastructure.Services
{
    public interface ILocationService
    {
        IEnumerable<Location> AllLocations { get; }
        void CreateLocation(EventViewModel newEvent);
        void DeleteLocation(int id);
        Location GetLocationById(int? eventId);
        void UpdateLocation(EventViewModel newEvent);
    }
}