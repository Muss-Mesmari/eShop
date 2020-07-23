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
using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;

namespace eShop.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ITicketService _ticketService;
        private readonly IEventService _eventService;
        private readonly ShoppingCartService _shoppingCartService;
        private readonly FeaturesConfiguration _featuresConfiguration;


        [BindProperty(SupportsGet = true)]
        public int SelectedAmount { get; set; }

        [BindProperty(SupportsGet = true)]
        public int SelectedTicketId { get; set; }

        public ShoppingCartController
        (
            ITicketService ticketService,
            IEventService eventService,
            ShoppingCartService shoppingCartService,
            IOptions<FeaturesConfiguration> options
        )
        {
            _ticketService = ticketService;
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
                    Tickets = _shoppingCartService.GetTickets(),
                    ShoppingCartService = _shoppingCartService,
                    ShoppingCartTotalSEK = _shoppingCartService.GetShoppingCartTotalSEK(),
                    ShoppingCartTotalEUR = _shoppingCartService.GetShoppingCartTotalEUR(),
                };

                return View(shoppingCartViewModel);
            }
            else
            {
                return View("_BlockedPage");
            }
        }

        public RedirectToActionResult AddToShoppingCart(int eventId, bool isDetailesPage)
        {
            if (_featuresConfiguration.EnableOrder)
            {
                var selectedEvent = _eventService.AllEvents().FirstOrDefault(e => e.EventId == eventId);
                var SelectedTicket = _ticketService.AllTickets.FirstOrDefault(t => t.TicketId == SelectedTicketId);

                if (selectedEvent != null)
                {
                    _shoppingCartService.AddToCart(selectedEvent, SelectedTicket, SelectedAmount, isDetailesPage);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public RedirectToActionResult RemoveFromShoppingCart(int eventId)
        {
            var selectedEvent = _eventService.AllEvents().FirstOrDefault(e => e.EventId == eventId);

            if (selectedEvent != null)
            {
                _shoppingCartService.RemoveFromCart(selectedEvent);
            }
            return RedirectToAction("Index");
        }
    }
}