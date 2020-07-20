using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eShop.Infrastructure.Services;
using eShop.Web.ViewModels;
using eShop.Presentation.ViewModels;
using eShop.Infrastructure.Filters;
using eShop.Infrastructure.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using eShop.Entities.Entities;

namespace eShop.Web.Controllers
{
  // [TypeFilter(typeof(OutageAuthorizationFilter))]

  //  [MobileRedirectActionFilter(Action ="ActionName", Controller ="Home")]
  //   To target the action name that we want to be generated for mobile phones
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;

        //public IActionResult Index()
        //{
        //     return View();
        //}

        private readonly IEventService _eventService;
        private readonly ITicketService _ticketService;
        private readonly IScheduleService _scheduleService;
        private readonly ICategoryService _categoryService;
        private readonly FeaturesConfiguration _featuresConfiguration;

        [BindProperty(SupportsGet = true)]
        public string SearchedEventBar { get; set; }

        public HomeController
        (
            ITicketService ticketService,
            IScheduleService scheduleService,
            IEventService eventService, 
            ICategoryService categoryService,
            IOptions<FeaturesConfiguration> options
        )
        {
            _ticketService = ticketService;
            _scheduleService = scheduleService;
            _eventService = eventService;
            _categoryService = categoryService;
            _featuresConfiguration = options.Value;
        }

        //[Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                IsHighlightedEvent = _eventService.IsHighlightedEvent,
                AllCategories = _categoryService.AllCategories,
                HomepageCategorySection = _featuresConfiguration.HomepageCategorySection,
                HomepageFeaturedEventsSection = _featuresConfiguration.HomepageFeaturedEventsSection
            };

            return View(homeViewModel);
        }

        public ActionResult Search()
        {
            IEnumerable<Event> events = _eventService.GetEventsByContent(SearchedEventBar).OrderBy(e => e.EventId);

            return View(new HomeViewModel
            {
                Events = events,
                SearchedEventBar = SearchedEventBar,
                NotFoundSearchedBarMessage = "Nothing was found that matched your search",
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
