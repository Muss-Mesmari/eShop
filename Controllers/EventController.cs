﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Infrastructure.Services;
using eShop.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eShop.Web.ViewModels;
using eShop.Presentation.ViewModels;

namespace eShop.Web.Controllers
{
    public class EventController : Controller
    {
        // [TypeFilter(typeof(KillSwitchAuthorizationFilter))]
        private readonly IEventService _eventService;
        private readonly ICategoryService _categoryService;

        [BindProperty(SupportsGet = true)]
        public string SearchedEvent { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchedCategory { get; set; }

        public EventController(IEventService eventService, ICategoryService categoryService)
        {
            _eventService = eventService;
            _categoryService = categoryService;
        }

        // GET: Event
        public ActionResult Index(string category)
        {
            IEnumerable<Event> events;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                events = _eventService.GetEvents(SearchedEvent, SearchedCategory).OrderBy(e => e.EventId);
                if (SearchedEvent != null)
                {
                    currentCategory = SearchedCategory;                    
                }
                else
                {
                    currentCategory = "All events";                 
                }
            }
            else
            {
                events = _eventService.GetEvents(SearchedEvent, SearchedCategory).Where(p => p.Category.CategoryName == category)
                    .OrderBy(e => e.EventId);
                currentCategory = _categoryService.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;                
            }

            return View(new EventsListViewModel
            {
                Events = events,
                CurrentCategory = currentCategory,
                SearchedEvent = SearchedEvent,
                SearchedCategory = SearchedCategory,
                NotFoundSearchedEventMessage = "No events were found that matched your criteria",
                Categories = _categoryService.AllCategories.ToList()
            });
        }

        // GET: Event/Details/5
        public IActionResult Details(int id)
        {
            var model = _eventService.GetEventById(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        // GET: Event/Create
        [Route("/Create-an-event", Name = "Create an event")]
        public IActionResult Create()
        {
            var viewModel = new EventCreateEditViewModel
            {
                Categories = _categoryService.AllCategories.ToList()

            };
            return View(viewModel);
        }

        // POST: Event/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EventCreateEditViewModel newEvent)
        {
            if (ModelState.IsValid)
            {
                _eventService.CreateEvent(newEvent);
                return RedirectToAction(nameof(Details), new { id = _eventService.AllEvents.Max(e => e.EventId) });
            }
            return View();
        }

        // GET: Event/Edit/5
        public IActionResult Edit(int id)
        {

            //var model = _eventRepository.GetEventById(id);
            //if (model == null)
            //{
            //    return View("NotFound");
            //}
            //return View(model);

            var viewModel = new EventCreateEditViewModel
            {
                Categories = _categoryService.AllCategories.ToList(),
                Event = _eventService.GetEventById(id)
            };
            if (viewModel == null)
            {
                return View("NotFound");
            }
            return View(viewModel);
        }

        // POST: Event/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, EventCreateEditViewModel newEvent)
        {
            if (ModelState.IsValid)
            {
                _eventService.UpdateEvent(newEvent);
                return RedirectToAction(nameof(Details), new { id = newEvent.Event.EventId });
            }
            return View();
        }

        // GET: Event/Delete/5
        public IActionResult Delete(int id)
        {
            var model = _eventService.GetEventById(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        // POST: Event/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, Event removedEvent)
        {
            if (ModelState.IsValid)
            {
                _eventService.DeleteEvent(id);
            }
            return RedirectToAction("Index");
        }

        // POST: Event/ImportEvents
        public IActionResult ImportEvents(List<Event> importedEvents)
        {
            return Content("The events has been imported");
        }
    }
}