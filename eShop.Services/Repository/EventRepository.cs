using eShop.Data.Data;
using eShop.Services.IRepository;
using eShop.Data.Entities;
using eShop.Presentation.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.Services.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly eShopDbContext _eShopDbContext;

        public EventRepository(eShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public IEnumerable<Event> AllEvents
        {
            get
            {
                return _eShopDbContext.Events.Include(c => c.Category);
            }
        }

        public IEnumerable<Event> IsHighlightedEvent
        {
            get
            {
                return _eShopDbContext.Events.Include(c => c.Category).Where(e => e.IsHighlightedEvent);
            }
        }

        public Event GetEventById(int? eventId)
        {
            return _eShopDbContext.Events.FirstOrDefault(e => e.EventId == eventId);
        }

        public void CreateEvent(EventCreateEditViewModel newEvent)
        {
            var _newEvent = new Event()
            {
                Name = newEvent.Event.Name,
                ShortDescription = newEvent.Event.ShortDescription,
                LongDescription = newEvent.Event.LongDescription,
                Price = newEvent.Event.Price,
                ImageUrl = newEvent.Event.ImageUrl,
                IsHighlightedEvent = newEvent.Event.IsHighlightedEvent,
                InStock = newEvent.Event.InStock,
                Category = newEvent.Event.Category,
                CategoryId = newEvent.Event.CategoryId
            };
            _eShopDbContext.Events.Add(_newEvent);
            _eShopDbContext.SaveChanges();
        }

        public void UpdateEvent(EventCreateEditViewModel newEvent)
        {            
            if (newEvent != null)
            {
                newEvent.Event.Name = newEvent.Event.Name;
                newEvent.Event.ShortDescription = newEvent.Event.ShortDescription;
                newEvent.Event.LongDescription = newEvent.Event.LongDescription;
                newEvent.Event.Price = newEvent.Event.Price;
                newEvent.Event.ImageUrl = newEvent.Event.ImageUrl;
                newEvent.Event.IsHighlightedEvent = newEvent.Event.IsHighlightedEvent;
                newEvent.Event.InStock = newEvent.Event.InStock;              
                newEvent.Event.CategoryId = newEvent.Event.CategoryId;               
            }
            
            var entity = _eShopDbContext.Entry(newEvent.Event);
            entity.State = EntityState.Modified;
            _eShopDbContext.SaveChanges();
        }

        public void DeleteEvent(int id)
        {
            var removedEvent = GetEventById(id);
            if (removedEvent != null)
            {
               _eShopDbContext.Remove(removedEvent);
                _eShopDbContext.SaveChanges();
            }
        }
    }
}
