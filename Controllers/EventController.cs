using System;
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
        private readonly IEventServices _eventRepository;
        private readonly ICategoryServices _categoryRepository;

        public EventController(IEventServices eventRepository, ICategoryServices categoryRepository)
        {
            _eventRepository = eventRepository;
            _categoryRepository = categoryRepository;
        }
        // GET: Event
        public ActionResult Index(string category)
        {
            IEnumerable<Event> events;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                events = _eventRepository.AllEvents.OrderBy(e => e.EventId);
                currentCategory = "All events";
            }
            else
            {
                events = _eventRepository.AllEvents.Where(p => p.Category.CategoryName == category)
                    .OrderBy(e => e.EventId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new EventsListViewModel
            {
                Events = events,
                CurrentCategory = currentCategory
            });
        }

        // GET: Event/Details/5
        public IActionResult Details(int id)
        {
            var model = _eventRepository.GetEventById(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        // GET: Event/Create
        public IActionResult Create()
        {
            var viewModel = new EventCreateEditViewModel
            {
                Categories = _categoryRepository.AllCategories.ToList()

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
                _eventRepository.CreateEvent(newEvent);
                return RedirectToAction(nameof(Details), new { id = _eventRepository.AllEvents.Max(e => e.EventId) });  
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
                Categories = _categoryRepository.AllCategories.ToList(),
                Event = _eventRepository.GetEventById(id)
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
                _eventRepository.UpdateEvent(newEvent);
                return RedirectToAction(nameof(Details), new { id = newEvent.Event.EventId });
            }
            return View();
        }

        // GET: Event/Delete/5
        public IActionResult Delete(int id)
        {
            var model = _eventRepository.GetEventById(id);
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
                _eventRepository.DeleteEvent(id);              
            }
            return RedirectToAction("Index");
        }
    }
}