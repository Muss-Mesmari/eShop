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
        private readonly ICategoryService _categoryService;
        private readonly FeaturesConfiguration _featuresConfiguration;

        public HomeController
            (IEventService eventService, 
            ICategoryService categoryService,
            IOptions<FeaturesConfiguration> options)
        {
            _eventService = eventService;
            _categoryService = categoryService;
            _featuresConfiguration = options.Value;
        }

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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
