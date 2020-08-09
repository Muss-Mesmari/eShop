using eShop.Infrastructure.Database;
using eShop.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace eShop.Infrastructure.Services
{
    public class ShoppingCartService
    {
        private readonly eShopDbContext _eShopDbContext;

        private ShoppingCartService(eShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public string ShoppingCartId { get; set; }

        //By default the current currency is SEK 
        //because it is the first item in the Currency enum class
        private Currency SEK { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCartService GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<eShopDbContext>();
            var ticketService = services.GetService<ITicketService>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCartService(context) { ShoppingCartId = cartId };
        }

        public List<ShoppingCartItem> GetShoppingCartItems(int? eventId = 0)
        {
            if (eventId != 0)
            {
                return ShoppingCartItems ??
                    (ShoppingCartItems =
                    _eShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId && c.Event.EventId == eventId)
                    .Include(e => e.Event)
                    .Include(t => t.Ticket)
                    .ToList());
            }
            else
            {
                return ShoppingCartItems ??
                       (ShoppingCartItems =
                           _eShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                               .Include(e => e.Event)
                               .Include(t => t.Ticket)
                               .ToList());
            }
        }

        public IList<Ticket> GetTickets()
        {
            var eventId = _eShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(e => e.Event.EventId).FirstOrDefault();
            var tickets = _eShopDbContext.Ticket.Where(t => t.EventId == eventId).ToList();
            foreach (var ticket in tickets)
            {
                var entity = _eShopDbContext.Entry(ticket);
                entity.State = EntityState.Detached;
            }
            return tickets;
        }


        public ShoppingCartItem GetShoppingCartItem(int? eventId = 0, List<int> ticketIds = null, int purchasedTicketId = 0)
        {
            ShoppingCartItem shoppingCartItem = null;
            foreach (var id in ticketIds)
            {
                if (id != purchasedTicketId)
                {
                    shoppingCartItem = _eShopDbContext.ShoppingCartItems.Where(
                        c => c.ShoppingCartId == ShoppingCartId &&
                        c.Event.EventId == eventId)
                        .SingleOrDefault();
                }
            }
            return shoppingCartItem;
        }

        public int GetShoppingCartItemAmount(int eventId)
        {
            var total = _eShopDbContext.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId && c.Event.EventId == eventId)
                .Select(t => t.Amount).FirstOrDefault();

            return total;
        }

        public List<int> GetShoppingCartItemTicketId(int eventId, int ticketId)
        {
            return _eShopDbContext.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId && c.Event.EventId == eventId)
                .Select(t => t.Ticket.TicketId).ToList();
        }

        public decimal GetShoppingCartItemTotalSEK(int eventId)
        {
            var total = _eShopDbContext.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId && c.Event.Currency == SEK && c.Event.EventId == eventId)
                .Select(t => t.Ticket.TicketPrice * t.Amount).Sum();
            return total;
        }


        public decimal GetShoppingCartItemTotalEUR(int eventId)
        {
            var total = _eShopDbContext.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId && c.Event.Currency != SEK && c.Event.EventId == eventId)
                .Select(t => t.Ticket.TicketPrice * t.Amount).Sum();
            return total;
        }

        public decimal GetShoppingCartTotalSEK()
        {
            var total = _eShopDbContext.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId && c.Event.Currency == SEK)
                .Select(t => t.Ticket.TicketPrice * t.Amount).Sum();
            return total;
        }

        public decimal GetShoppingCartTotalEUR()
        {
            var total = _eShopDbContext.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId && c.Event.Currency != SEK)
                .Select(t => t.Ticket.TicketPrice * t.Amount).Sum();
            return total;
        }

        public decimal GetTicketTotalPrice(int ticketId, int amount)
        {
            var total = _eShopDbContext.Ticket.Where(t => t.TicketId == ticketId)
                .Select(t => t.TicketPrice * amount)
                .Sum();
            return total;
        }

        public void AddToCart(Event purchasedEvent, Ticket purchasedTicket, int purchasedAmount, bool isDetailesPage)
        {

            if (IsShoppingCartEmpty() || !IsEventInCart(purchasedEvent).Item1)
            {
                var shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Event = purchasedEvent,
                    Amount = purchasedAmount,
                    Ticket = purchasedTicket
                };
                _eShopDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }

            // detail page rule 
            else if (isDetailesPage && IsEventInCart(purchasedEvent).Item1)
            {
                // ticket rule
                var evenId = purchasedEvent.EventId;
                var purchasedTicketId = purchasedTicket.TicketId;
                var oldPurchasedTicketId = GetShoppingCartItemTicketId(purchasedEvent.EventId, purchasedTicket.TicketId);
                if (!IsTicketInCart(oldPurchasedTicketId, purchasedTicketId))
                {
                    var newShoppingCartItem = new ShoppingCartItem
                    {
                        ShoppingCartId = ShoppingCartId,
                        Event = purchasedEvent,
                        Amount = purchasedAmount,
                        Ticket = purchasedTicket
                    };
                    _eShopDbContext.ShoppingCartItems.Add(newShoppingCartItem);
                }
                else
                {
                    // temp statment. The operation should not be allowed

                    // GetShoppingCartItem(evenId, oldPurchasedTicketId, purchasedTicketId).Ticket = purchasedTicket;
                    //shoppingCartItem.Ticket = purchasedTicket;
                }
            }

            else
            {
                // rule if event in cart and how many
                ShoppingCartItem shoppingCartItem = null;
                if (IsEventInCart(purchasedEvent).Item1 && IsEventInCart(purchasedEvent).Item2 > 1)
                {
                    shoppingCartItem = _eShopDbContext.ShoppingCartItems.Where(
                        e => e.Event.EventId == purchasedEvent.EventId &&
                        e.ShoppingCartId == ShoppingCartId &&
                        e.Ticket.TicketId == purchasedTicket.TicketId).SingleOrDefault();
                }
                else
                {
                    shoppingCartItem =
                            _eShopDbContext.ShoppingCartItems.SingleOrDefault(
                                e => e.Event.EventId == purchasedEvent.EventId &&
                                e.ShoppingCartId == ShoppingCartId);
                }

                // amount rule     
                var oldPurchasedAmount = GetShoppingCartItemAmount(purchasedEvent.EventId);
                if (!IsSameAmount(oldPurchasedAmount, purchasedAmount))
                {
                    shoppingCartItem.Amount = purchasedAmount;
                };
            }
            _eShopDbContext.SaveChanges();
        }

        private (bool, int) IsEventInCart(Event purchasedEvent)
        {
            var oldPurchasedEvents = _eShopDbContext.ShoppingCartItems
                .Where(e => e.Event.EventId == purchasedEvent.EventId
                && e.ShoppingCartId == ShoppingCartId)
                .ToList();
            int counter = 0;
            var isEventInCart = false;
            foreach (var oldPurchasedEvent in oldPurchasedEvents)
            {
                if (oldPurchasedEvent.Event.EventId == purchasedEvent.EventId)
                {
                    counter++;
                    isEventInCart = true;
                }
            }
            return (isEventInCart, counter);
        }

        private bool IsShoppingCartEmpty()
        {
            var shoppingCart =
        _eShopDbContext.ShoppingCartItems.Where(
            e => e.ShoppingCartId == ShoppingCartId).ToList();


            if (shoppingCart.Any())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsTicketInCart(List<int> selectedTicketIds, int oldTicketId)
        {
            var isTicketInCart = false;
            foreach (var id in selectedTicketIds)
            {
                if (id == oldTicketId)
                {
                    isTicketInCart = true;
                }
                else
                {
                    isTicketInCart = false;
                }
            }
            return isTicketInCart;
        }

        private bool IsSameAmount(int selectedAmount, int oldAmount)
        {
            if (selectedAmount == oldAmount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int RemoveFromCart(int eventId, int SelectedTicketId)
        {
            var shoppingCartItem =
                    _eShopDbContext.ShoppingCartItems.SingleOrDefault(
                        e => e.Event.EventId == eventId && e.ShoppingCartId == ShoppingCartId && e.Ticket.TicketId == SelectedTicketId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                _eShopDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                //if (shoppingCartItem.Amount > 1)
                //{
                //    shoppingCartItem.Amount--;
                //    localAmount = shoppingCartItem.Amount;
                //}
                //else
                //{
                //    _eShopDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                //}
            }

            _eShopDbContext.SaveChanges();

            return localAmount;
        }

        public void ClearCart()
        {
            var cartItems = _eShopDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _eShopDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _eShopDbContext.SaveChanges();
        }

    }
}
