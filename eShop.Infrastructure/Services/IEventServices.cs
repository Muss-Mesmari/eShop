using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Infrastructure.Services
{
    public interface IEventService
    {
        IEnumerable<Event> AllEvents(string searchedEvent = null, string searchedCategory = null);
        IEnumerable<Event> IsHighlightedEvent { get; }
        Event GetEventById(int? eventId);      
        IEnumerable<Event> GetSearchedEventsByContent(string searchedEvent);
        void CreateEvent(EventViewModel newEvent);
        void UpdateEvent(EventViewModel oldEvent);
        void DeleteEvent(int id);
    }
}
