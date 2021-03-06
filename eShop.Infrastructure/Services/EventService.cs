﻿using eShop.Infrastructure.Database;
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
        private readonly ILocationService _locationService;
        private readonly ITeacherService _teachersService;

        public EventService(
            eShopDbContext eShopDbContext,
            ILocationService locationService,
            ITeacherService teachersService)
        {
            _eShopDbContext = eShopDbContext;
            _locationService = locationService;
            _teachersService = teachersService;
        }

        public IEnumerable<Event> AllEvents(string searchedEvent = null, string searchedCategory = null)
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

        public IEnumerable<Event> IsHighlightedEvent
        {
            get
            {
                return _eShopDbContext.Events.Include(c => c.Category).Where(e => e.IsHighlightedEvent).OrderBy(e => e.EventId);
            }
        }

        public Event GetEventById(int? eventId)
        {
            var eventById = _eShopDbContext.Events.FirstOrDefault(e => e.EventId == eventId);

            var entity = _eShopDbContext.Entry(eventById);
            entity.State = EntityState.Detached;

            return eventById;
        }

        public void CreateEvent(EventViewModel newEvent)
        {
            var eventId = newEvent.Event.EventId;

            var _newEvent = new Event()
            {
                Name = newEvent.Event.Name,
                ShortDescription = newEvent.Event.ShortDescription,
                LongDescription = newEvent.Event.LongDescription,
                ImageUrl = newEvent.Event.ImageUrl,
                IsHighlightedEvent = newEvent.Event.IsHighlightedEvent,
                InStock = newEvent.Event.InStock,
                CategoryId = newEvent.Event.CategoryId,
                Currency = newEvent.Event.Currency
            };

            _eShopDbContext.Events.Add(_newEvent);
            _eShopDbContext.SaveChanges();
        }

        public void UpdateEvent(EventViewModel newEvent)
        {
            var eventId = newEvent.Event.EventId;

            if (newEvent != null)
            {
                newEvent.Event.Name = newEvent.Event.Name;
                newEvent.Event.ShortDescription = newEvent.Event.ShortDescription;
                newEvent.Event.LongDescription = newEvent.Event.LongDescription;
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
  
        public IEnumerable<Event> GetSearchedEventsByContent(string searchedEvent)
        {
            return _eShopDbContext.Events.Include(c => c.Category)
                .Where(e => e.Name.Contains(searchedEvent) || e.LongDescription.Contains(searchedEvent) || e.ShortDescription.Contains(searchedEvent) || e.Category.CategoryName.Contains(searchedEvent) || e.Category.Description.Contains(searchedEvent));
        }

    }
}
