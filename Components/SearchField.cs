using eShop.Entities.Entities;
using eShop.Infrastructure.Services;
using eShop.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Web.Components
{
    public class SearchField : ViewComponent
    {
        private readonly IEventService _eventService;
        private readonly ICategoryService _categoryService;

        [BindProperty(SupportsGet = true)]
        public string SearchedEvent { get; set; }
        public SearchField(IEventService eventService, ICategoryService categoryService)
        {
            _eventService = eventService;
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            IEnumerable<Event> events;
            string currentCategory;
            SearchedEvent = SearchedEvent;

            string category = null;

            if (string.IsNullOrEmpty(category))
            {
                events = _eventService.AllEventsByName(SearchedEvent).OrderBy(e => e.EventId);
                currentCategory = "All events";
            }
            else
            {
                events = _eventService.AllEventsByName(SearchedEvent).Where(p => p.Category.CategoryName == category)
                    .OrderBy(e => e.EventId);
                currentCategory = _categoryService.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new EventsListViewModel
            {
                Events = events,
                CurrentCategory = currentCategory,
                SearchedEvent = SearchedEvent
            });
           
        }
    }
}
