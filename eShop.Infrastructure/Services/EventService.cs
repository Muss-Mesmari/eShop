using eShop.Infrastructure.Database;
using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Infrastructure.Services
{
    public class EventService : IEventService
    {
        private readonly eShopDbContext _eShopDbContext;

        public EventService(eShopDbContext eShopDbContext)
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
                CategoryId = newEvent.Event.CategoryId,
                Currency = newEvent.Event.Currency
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
                newEvent.Event.Currency = newEvent.Event.Currency;
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

        public IEnumerable<Event> GetEvents(string searchedEvent = null, string searchedCategory = null)
        {
            if (searchedCategory == null)
            {
                return _eShopDbContext.Events.Include(c => c.Category).Where(e => e.Name.Contains(searchedEvent) || string.IsNullOrEmpty(searchedEvent));
            }
            else 
            {
                return _eShopDbContext.Events.Include(c => c.Category).Where(e => e.Name.Contains(searchedEvent) && e.Category.CategoryName == searchedCategory || string.IsNullOrEmpty(searchedEvent));
            }           
        }
    }
}
