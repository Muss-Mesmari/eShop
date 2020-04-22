using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Infrastructure;
using eShop.Web.ViewModels;
using eShop.Infrastructure.Repository;
using eShop.Infrastructure.IRepository;
using Microsoft.AspNetCore.Mvc;
using eShop.Services;
using Microsoft.Extensions.Options;

namespace eShop.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IEventRepository _eventRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly FeaturesConfiguration _featuresConfiguration;

        public ShoppingCartController(IEventRepository eventRepository, ShoppingCart shoppingCart, IOptions<FeaturesConfiguration> options)
        {
            _eventRepository = eventRepository;
            _shoppingCart = shoppingCart;
            _featuresConfiguration = options.Value;
        }
        public IActionResult Index()
        {
            if (_featuresConfiguration.EnableOrder)
            {
                var items = _shoppingCart.GetShoppingCartItems();
                _shoppingCart.ShoppingCartItems = items;

                var shoppingCartViewModel = new ShoppingCartViewModel
                {
                    ShoppingCart = _shoppingCart,
                    ShoppingCartTotalSEK = _shoppingCart.GetShoppingCartTotalSEK(),
                    ShoppingCartTotalEUR = _shoppingCart.GetShoppingCartTotalEUR()
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
                var selectedEvent = _eventRepository.AllEvents.FirstOrDefault(e => e.EventId == eventId);

                if (selectedEvent != null)
                {
                    _shoppingCart.AddToCart(selectedEvent, 1);
                }                
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int eventId)
        {
            var selectedEvent = _eventRepository.AllEvents.FirstOrDefault(e => e.EventId == eventId);

            if (selectedEvent != null)
            {
                _shoppingCart.RemoveFromCart(selectedEvent);
            }
            return RedirectToAction("Index");
        }
    }
}