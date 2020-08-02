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
using eShop.Infrastructure.Configuration;
using Microsoft.Extensions.Options;

namespace eShop.Web.Controllers
{
    public class EventController : Controller
    {
        // [TypeFilter(typeof(KillSwitchAuthorizationFilter))]
        private readonly IEventService _eventService;
        private readonly ICategoryService _categoryService;
        private readonly IScheduleService _scheduleService;
        private readonly ILocationService _locationService;
        private readonly ITeacherService _teacherService;
        private readonly ITicketService _ticketService;
        private readonly ShoppingCartService _shoppingCartService;
        private readonly FeaturesConfiguration _featuresConfiguration;

        [BindProperty(SupportsGet = true)]
        public string SearchedEventBar { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchedEvent { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchedCategory { get; set; }

        public EventController
            (
            IEventService eventService,
            ICategoryService categoryService,
            IScheduleService scheduleService,
            ILocationService locationService,
            ITeacherService teachersService,
            ITicketService ticketService,
            ShoppingCartService shoppingCartService,
            IOptions<FeaturesConfiguration> options
            )
        {
            _scheduleService = scheduleService;
            _eventService = eventService;
            _categoryService = categoryService;
            _locationService = locationService;
            _teacherService = teachersService;
            _ticketService = ticketService;
            _shoppingCartService = shoppingCartService;
            _featuresConfiguration = options.Value;
        }

        // GET: Event
        public ActionResult Index(string category)
        {
            IEnumerable<Event> events;

            List<List<Day>> daysList = new List<List<Day>>();
            var eventsList = _eventService.AllEvents();
            foreach (var e in eventsList)
            {
                var days = _scheduleService.GetEventDays(e.EventId, false);
                daysList.Add(days); 
            }
            var times = _scheduleService.GetAllEventsTimesList();

            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                events = _eventService.AllEvents(SearchedEvent, SearchedCategory).OrderBy(e => e.EventId);

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
                events = _eventService.AllEvents(SearchedEvent, SearchedCategory).Where(p => p.Category.CategoryName == category)
                    .OrderBy(e => e.EventId);
                currentCategory = _categoryService.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new EventViewModel
            {
                Events = events,
                DaysList = daysList,
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
            var times = _scheduleService.GetEventTimes(id, false);
            var locations = _locationService.GetLocationById(id);
            var teachers = _teacherService.GetTeachersById(id);
            var selectedAmount = _shoppingCartService.GetShoppingCartItemAmount(id);
            var tickets = _ticketService.GetTicketById(id);
 
            if (selectedAmount == 0)
            {
                selectedAmount = 1;
            }

            if (eventDetails == null)
            {
                return View("NotFound");
            }

            return View(new EventViewModel
            {
                ShoppingCartItemTotalSEK = _shoppingCartService.GetShoppingCartItemTotalSEK(id),
                ShoppingCartItemTotalEUR = _shoppingCartService.GetShoppingCartItemTotalEUR(id),
                SelectedAmount = selectedAmount,
                Event = eventDetails,
                Days = days,
                Times = times,
                Locations = locations,
                Teachers = teachers,
                Tickets = tickets,
                NotFoundSchedule = "The event does not have a schedule yet!"
            });
        }


        // GET: Event/CreateStepOne
        // [Route("/Event/Create-Step-One")]
        // [HttpGet]
        public IActionResult CreateStepOne()
        {
            var viewModel = new EventViewModel
            {
                Categories = _categoryService.AllCategories.ToList()
            };
            return View(viewModel);
        }

        // POST: Event/CreateStepOne
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateStepOne(EventViewModel newEvent)
        {
            if (ModelState.IsValid)
            {
                _eventService.CreateEvent(newEvent);

                var eventId = _eventService.AllEvents().Max(e => e.EventId);
                return RedirectToAction(nameof(CreateStepTwo), new { id = eventId, isNewEvent = true });
            }
            return View();
        }

        // GET: Event/CreateStepTwo
        // [Route("/Event/Create-Step-Two")]
        // [HttpGet]
        public IActionResult CreateStepTwo(int id, bool isNewEvent)
        {
            var viewModel = new EventViewModel
            {
                EventId = id,
                Days = _scheduleService.GetEventDays(id, isNewEvent),
                Times = _scheduleService.GetEventTimes(id, isNewEvent)
            };
            return View(viewModel);
        }

        // POST: Event/CreateStepTwo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateStepTwo(EventViewModel newEvent)
        {
            if (ModelState.IsValid)
            {
                _scheduleService.CreateSchedule(newEvent);
                var eventId = _eventService.AllEvents().Max(e => e.EventId);
                return RedirectToAction(nameof(CreateStepTwo), new { id = eventId });
            }
            return View();
        }

        // GET: Event/CreateStepThree
        //[Route("/Event/Create-Step-Three")]
        //[HttpGet]
        public IActionResult CreateStepThree(int id)
        {
            var viewModel = new EventViewModel
            {
                EventId = id,
                Event = _eventService.GetEventById(id),
                Tickets = _ticketService.GetTicketById(id)
            };
            return View(viewModel);
        }

        // POST: Event/CreateStepThree
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateStepThree(int id, EventViewModel newEvent)
        {
            if (ModelState.IsValid)
            {
                _ticketService.CreateTicket(_eventService.AllEvents().Max(e => e.EventId), newEvent);
                var eventId = _eventService.AllEvents().Max(e => e.EventId);
                return RedirectToAction(nameof(CreateStepFour), new { id = eventId });                
            }
            return View();
        }

        // GET: Event/CreateStepFour
        //[Route("/Event/Create-Step-Four")]
        //[HttpGet]
        public IActionResult CreateStepFour(int id)
        {
            var viewModel = new EventViewModel
            {
                EventId = id,
                Event = _eventService.GetEventById(id),
                Teachers = _teacherService.GetTeachersById(id)
            };
            return View(viewModel);
        }

        // POST: Event/CreateStepFour
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateStepFour(int id, EventViewModel newEvent)
        {
            if (ModelState.IsValid)
            {
                _teacherService.CreateTeacher(_eventService.AllEvents().Max(e => e.EventId), newEvent);
                var eventId = _eventService.AllEvents().Max(e => e.EventId);
                return RedirectToAction(nameof(CreateStepFive), new { id = eventId });
            }
            return View();
        }

        // GET: Event/CreateStepFive
        //[Route("/Event/Create-Step-Five")]
        //[HttpGet]
        public IActionResult CreateStepFive(int id)
        {
            var viewModel = new EventViewModel
            {
                EventId = id,
                Event = _eventService.GetEventById(id),
                Locations = _locationService.GetLocationById(id)
            };
            return View(viewModel);
        }

        // POST: Event/CreateStepFive
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateStepFive(int id, EventViewModel newEvent)
        {
            if (ModelState.IsValid)
            {
                _locationService.CreateLocation(_eventService.AllEvents().Max(e => e.EventId), newEvent);
                var eventId = _eventService.AllEvents().Max(e => e.EventId);
                return RedirectToAction(nameof(CreateStepFive), new { id = eventId });
            }
            return View();
        }

        // GET: Event/Edit/5
        public IActionResult Edit(int id)
        {
            var viewModel = new EventViewModel
            {
                Teachers = _teacherService.GetTeachersById(id),
                Locations = _locationService.GetLocationById(id),
                Categories = _categoryService.AllCategories.ToList(),
                Event = _eventService.GetEventById(id),
                Tickets = _ticketService.GetTicketById(id),
                Days = _scheduleService.GetEventDays(id, false),
                Times = _scheduleService.GetEventTimes(id, false),
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
        public IActionResult Edit(int id, EventViewModel newEvent, IEnumerable<Location> locations, IEnumerable<Teacher> teachers, IEnumerable<Ticket> tickets, IEnumerable<Day> days, List<string> SelectedStartTimesBinded, List<string> SelectedEndTimesBinded)
        {
            if (ModelState.IsValid)
            {
                _eventService.UpdateEvent(newEvent);
                _locationService.UpdateLocation(id, locations);
                _teacherService.UpdateTeacher(id, teachers);
                _ticketService.UpdateTicket(id, tickets);
                _scheduleService.UpdateDays(id, days);
                _scheduleService.UpdateTimes(id, SelectedStartTimesBinded, SelectedEndTimesBinded);

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
                _ticketService.DeleteTickets(id);
                _scheduleService.DeleteSchedule(id);
                _eventService.DeleteEvent(id);
                _locationService.DeleteLocations(id);
                _teacherService.DeleteTeacher(id);
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSchedule(int id)
        {
            var modifiedEvent = _eventService.GetEventById(id);

            if (ModelState.IsValid)
            {
                _scheduleService.DeleteSchedule(id);
            }
            return RedirectToPage($"/Event/Details/{modifiedEvent.EventId}#schedule");
            // https://localhost:44369/Event/Details/1#schedule
            //return RedirectToAction(nameof(Details), new { id = modifiedEvent.EventId });
        }


        // POST: Event/ImportEvents
        public IActionResult ImportEvents(List<Event> importedEvents)
        {
            return Content("The events has been imported");
        }
    }
}