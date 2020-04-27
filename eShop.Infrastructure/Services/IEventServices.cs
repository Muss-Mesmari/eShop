using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Infrastructure.Services
{
    public interface IEventService
    {
        IEnumerable<Event> AllEvents { get; }
        IEnumerable<Event> IsHighlightedEvent { get; }
        Event GetEventById(int? eventId);
        IEnumerable<Event> AllEventsByName(string searchedEvent = null);
        void CreateEvent(EventCreateEditViewModel newEvent);
        void UpdateEvent(EventCreateEditViewModel oldEvent);
        void DeleteEvent(int id);      
    }
}
