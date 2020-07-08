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
        // [TypeFilter(typeof(KillSwitchAuthorizationFilter))]
        private readonly IEventService _eventService;
        private readonly ICategoryService _categoryService;
        private readonly IScheduleService _scheduleService;
        private readonly ILocationService _locationService;
        private readonly ITeachersService _teachersService;
        private readonly ITicketService _ticketService;
        private readonly ShoppingCartService _shoppingCartService;

        [BindProperty(SupportsGet = true)]
        public string SearchedEvent { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchedCategory { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Amount { get; set; }
        public EventController
            (
            IEventService eventService,
            ICategoryService categoryService,
            IScheduleService scheduleService,
            ILocationService locationService,
            ITeachersService teachersService,
            ITicketService ticketService,
            ShoppingCartService shoppingCartService
            )
        {
            _scheduleService = scheduleService;
            _eventService = eventService;
            _categoryService = categoryService;
            _locationService = locationService;
            _teachersService = teachersService;
            _ticketService = ticketService;
            _shoppingCartService = shoppingCartService;
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
            var eventDetails = _eventService.GetEventById(id);
            var days = _scheduleService.GetEventDays(id, false);
            var eventSchedule = _scheduleService.GetEventTimes(id, false);
            var location = _locationService.GetLocationById(id);
            var teachers = _teachersService.GetTeachersById(id);
            var amount = _shoppingCartService.GetShoppingCartItemAmount(id);
            var tickets = _ticketService.GetTicketById(id);

            if (amount == 0)
            {
                amount = 1;
            }

            if (eventDetails == null)
            {
                return View("NotFound");
            }

            return View(new EventCreateEditViewModel
            /*DetailsViewModel*/
            {
                ShoppingCartItemTotalSEK = _shoppingCartService.GetShoppingCartItemTotalSEK(id),
                ShoppingCartItemTotalEUR = _shoppingCartService.GetShoppingCartItemTotalEUR(id),
                Amount = amount,
                Event = eventDetails,
                Days = days,
                EventSchedule = eventSchedule,
                Location = location,
                Teachers = teachers,
                Tickets = tickets
            });
        }

        public RedirectResult AddToShoppingCart(int eventId)
        {
            var selectedEvent = _eventService.GetEventById(eventId);

            if (selectedEvent != null)
            {
                _shoppingCartService.AddToCart(selectedEvent, Amount, true);
            }
            return Redirect($"/Event/Details/{eventId}#tickets");
        }

        // GET: Event/Create
        //[Route("/Event/Create-Step-One")]
        //[HttpGet]
        public IActionResult CreateStepOne()
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
        public IActionResult CreateStepOne(EventCreateEditViewModel newEvent)
        {
            if (ModelState.IsValid)
            {
                _teachersService.CreateTeachers(newEvent);
                _locationService.CreateLocation(newEvent);
                _eventService.CreateEvent(newEvent);

                var eventId = _eventService.AllEvents.Max(e => e.EventId);
                return RedirectToAction(nameof(CreateStepTwo), new { id = eventId, isNewEvent = true });
            }
            return View();
        }

        //GET: Event/Create
        // [Route("/Event/Create-Step-Two")]
        //[HttpGet]
        public IActionResult CreateStepTwo(int id, bool isNewEvent)
        {
            var viewModel = new EventCreateEditViewModel
            {
                Days = _scheduleService.GetEventDays(id, isNewEvent),
                EventSchedule = _scheduleService.GetEventTimes(id, isNewEvent)
            };
            return View(viewModel);
        }

        // POST: Event/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateStepTwo(EventCreateEditViewModel newEvent)
        {
            if (ModelState.IsValid)
            {
                _scheduleService.CreateSchedule(newEvent);

                var eventId = _eventService.AllEvents.Max(e => e.EventId);
                //return RedirectToAction(nameof(CreateStepThree));
                return RedirectToAction(nameof(CreateStepTwo), new { id = eventId });
            }
            return View();
        }

        // GET: Event/Create
        //[Route("/Event/Create-Step-Three")]
        //[HttpGet]
        public IActionResult CreateStepThree(int id)
        {            
            // return View();
            var viewModel = new EventCreateEditViewModel
            {
                Tickets = _ticketService.GetTicketById(id),
                EventId = id
            };
            return View(viewModel);
        }

        // POST: Event/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateStepThree(EventCreateEditViewModel newEvent)
        {
            if (ModelState.IsValid)
            {
                _ticketService.CreateTicket(_eventService.AllEvents.Max(e => e.EventId), newEvent);

                var eventId = _eventService.AllEvents.Max(e => e.EventId);
                return RedirectToAction(nameof(CreateStepThree), new { id = eventId });
                //return RedirectToAction(nameof(Details), new { id = eventId });
            }
            return View();
        }

        //// POST: Event/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult CreateTicket(EventCreateEditViewModel newEvent)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _ticketService.CreateTicket( 1/*_eventService.AllEvents.Max(e => e.EventId)*/, newEvent);                
        //    }
        //    return View();
        //}

        // GET: Event/Edit/5
        public IActionResult Edit(int id)
        {
            var viewModel = new EventCreateEditViewModel
            {
                Teachers = _teachersService.GetTeachersById(id),
                Location = _locationService.GetLocationById(id),
                Categories = _categoryService.AllCategories.ToList(),
                Event = _eventService.GetEventById(id),
                Tickets = _ticketService.GetTicketById(id),
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
        public IActionResult Edit(int id, EventCreateEditViewModel newEvent, IList<Ticket> tickets)
        {
            if (ModelState.IsValid)
            {
                _eventService.UpdateEvent(newEvent);
                _locationService.UpdateLocation(newEvent);
                _teachersService.UpdateTeachers(newEvent);
                _ticketService.UpdateTicket(id, tickets);

                //return Redirect($"/Event/Edit/{id}#tickets");
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