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
using eShop.Infrastructure.Outage;

namespace eShop.Web.Controllers
{
    [TypeFilter(typeof(OutageAuthorizationFilter))]
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

        public HomeController(IEventService eventService)
        {
            _eventService = eventService;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                IsHighlightedEvent = _eventService.IsHighlightedEvent
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
