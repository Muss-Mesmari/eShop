using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Data;
using eShop.Services;
using eShop.Services.IRepository;
using eShop.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IEventRepository _eventRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IEventRepository eventRepository, ShoppingCart shoppingCart)
        {
            _eventRepository = eventRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }
        public RedirectToActionResult AddToShoppingCart(int eventId)
        {
            var selectedEvent = _eventRepository.AllEvents.FirstOrDefault(e => e.EventId == eventId);

            if (selectedEvent != null)
            {
                _shoppingCart.AddToCart(selectedEvent, 1);
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