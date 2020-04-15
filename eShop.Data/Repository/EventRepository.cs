using eShop.Data.Data;
using eShop.Data.IRepository;
using eShop.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.Data.Repository
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

        public void CreateEvent(Event newEvent)
        {
            var _newEvent = new Event()
            {
                Name = newEvent.Name,
                ShortDescription = newEvent.ShortDescription,
                LongDescription = newEvent.LongDescription,
                Price = newEvent.Price,
                ImageUrl = newEvent.ImageUrl,
                IsHighlightedEvent = newEvent.IsHighlightedEvent,
                InStock = newEvent.InStock,
                Category = newEvent.Category,
                CategoryId = newEvent.CategoryId
            };
            _eShopDbContext.Events.Add(_newEvent);
            _eShopDbContext.SaveChanges();
        }

        public void UpdateEvent(Event newEvent)
        {            
            if (newEvent != null)
            {
                newEvent.Name = newEvent.Name;
                newEvent.ShortDescription = newEvent.ShortDescription;
                newEvent.LongDescription = newEvent.LongDescription;
                newEvent.Price = newEvent.Price;
                newEvent.ImageUrl = newEvent.ImageUrl;
                newEvent.IsHighlightedEvent = newEvent.IsHighlightedEvent;
                newEvent.InStock = newEvent.InStock;
                newEvent.Category = newEvent.Category;
                newEvent.CategoryId = newEvent.CategoryId;
            }

            var entity = _eShopDbContext.Entry(newEvent);
            entity.State = EntityState.Modified;
            _eShopDbContext.SaveChanges();
        }  
    }
}
