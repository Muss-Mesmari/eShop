using eShop.Data.Entities;
using eShop.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Services.IRepository
{
    public interface IEventRepository
    {
        IEnumerable<Event> AllEvents { get; }
        IEnumerable<Event> IsHighlightedEvent { get; }
        Event GetEventById(int? eventId);
        void CreateEvent(EventCreateEditViewModel newEvent);
        void UpdateEvent(EventCreateEditViewModel oldEvent);
        void DeleteEvent(int id);      
    }
}
