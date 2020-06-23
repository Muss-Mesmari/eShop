using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Infrastructure;
using eShop.Web.ViewModels;
using eShop.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using eShop.Infrastructure.Configuration;
using Microsoft.Extensions.Options;

namespace eShop.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IEventService _eventService;
        private readonly ShoppingCartService _shoppingCartService;
        private readonly FeaturesConfiguration _featuresConfiguration;


        [BindProperty(SupportsGet = true)]
        public int Amount { get; set; }

        public ShoppingCartController
            (IEventService eventService,
            ShoppingCartService shoppingCartService,
            IOptions<FeaturesConfiguration> options)
        {
            _eventService = eventService;
            _shoppingCartService = shoppingCartService;
            _featuresConfiguration = options.Value;
        }
        public IActionResult Index()
        {
            if (_featuresConfiguration.EnableOrder)
            {
                var items = _shoppingCartService.GetShoppingCartItems();
                _shoppingCartService.ShoppingCartItems = items;

                var shoppingCartViewModel = new ShoppingCartViewModel
                {
                    ShoppingCartService = _shoppingCartService,
                    ShoppingCartTotalSEK = _shoppingCartService.GetShoppingCartTotalSEK(),
                    ShoppingCartTotalEUR = _shoppingCartService.GetShoppingCartTotalEUR()
                };

                return View(shoppingCartViewModel);
            }
            else
            {
                return View("_BlockedPage");
            }
        }
        public RedirectToActionResult AddToShoppingCart(int eventId)
        {
            if (_featuresConfiguration.EnableOrder)
            {
                var selectedEvent = _eventService.AllEvents.FirstOrDefault(e => e.EventId == eventId);

                if (selectedEvent != null)
                {
                    _shoppingCartService.AddToCart(selectedEvent, Amount, false);
                }
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int eventId)
        {
            var selectedEvent = _eventService.AllEvents.FirstOrDefault(e => e.EventId == eventId);

            if (selectedEvent != null)
            {
                _shoppingCartService.RemoveFromCart(selectedEvent);
            }
            return RedirectToAction("Index");
        }
    }
}