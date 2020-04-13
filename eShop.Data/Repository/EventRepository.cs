using eShop.Data.Data;
using eShop.Data.IRepository;
using eShop.infrastructure.Models;
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

    }
}
