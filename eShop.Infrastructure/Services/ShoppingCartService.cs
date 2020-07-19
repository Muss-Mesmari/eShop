using eShop.Infrastructure.Database;
using eShop.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.Infrastructure.Services
{
    public class ShoppingCartService
    {
        private readonly eShopDbContext _eShopDbContext;

        private ShoppingCartService
            (
            eShopDbContext eShopDbContext
            )
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

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       _eShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(e => e.Event)
                           .Include(t => t.Ticket)
                           .ToList());
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

        public int GetShoppingCartItemAmount(int eventId)
        {
            var total = _eShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId && c.Event.EventId == eventId)
    .Select(t => t.Amount).FirstOrDefault();

            return total;
        }

        public int GetShoppingCartItemTicketId(int eventId)
        {
            var total = _eShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId && c.Event.EventId == eventId)
    .Select(t => t.Ticket.TicketId).FirstOrDefault();

            return total;
        }
        
        public decimal GetShoppingCartItemTotalSEK(int eventId)
        {
            var total = _eShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId && c.Event.Currency == SEK && c.Event.EventId == eventId)
    .Select(t => t.Ticket.TicketPrice * t.Amount).Sum();
            return total;
        }

        public decimal GetShoppingCartItemTotalEUR(int eventId)
        {
            var total = _eShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId && c.Event.Currency != SEK && c.Event.EventId == eventId)
    .Select(t => t.Ticket.TicketPrice * t.Amount).Sum();
            return total;
        }

        public decimal GetShoppingCartTotalSEK()
        {
            var total = _eShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId && c.Event.Currency == SEK)
    .Select(t => t.Ticket.TicketPrice * t.Amount).Sum();
            return total;
        }

        public decimal GetShoppingCartTotalEUR()
        {
            var total = _eShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId && c.Event.Currency != SEK)
    .Select(t => t.Ticket.TicketPrice * t.Amount).Sum();
            return total;
        }

        public void AddToCart(Event purchasedEvent, Ticket purchasedTicket, int amount, bool isDetailesPage)
        {
            var shoppingCartItem =
                    _eShopDbContext.ShoppingCartItems.SingleOrDefault(
                        e => e.Event.EventId == purchasedEvent.EventId && e.ShoppingCartId == ShoppingCartId);

            var oldAmount = GetShoppingCartItemAmount(purchasedEvent.EventId);
            var oldTicketId = GetShoppingCartItemTicketId(purchasedEvent.EventId);

            if (isDetailesPage is false)
            {
                if (amount == 0)
                {
                    amount = oldAmount;
                }

                if (oldTicketId != purchasedTicket.TicketId)
                {
                    var newPurchasedEvent = purchasedEvent;
                    var newPurchasedTicket = purchasedTicket;

                    _eShopDbContext.ShoppingCartItems.Remove(shoppingCartItem);

                    shoppingCartItem = new ShoppingCartItem
                    {
                        ShoppingCartId = ShoppingCartId,
                        Event = newPurchasedEvent,
                        Amount = oldAmount,
                        Ticket = newPurchasedTicket
                    };

                    _eShopDbContext.ShoppingCartItems.Add(shoppingCartItem);               
                }

                else if (shoppingCartItem == null)
                {
                    shoppingCartItem = new ShoppingCartItem
                    {
                        ShoppingCartId = ShoppingCartId,
                        Event = purchasedEvent,
                        Amount = 0,
                        Ticket = purchasedTicket
                    };

                    _eShopDbContext.ShoppingCartItems.Add(shoppingCartItem);
                }

                else
                {
                    shoppingCartItem.Amount = amount;
                }
            }
            else
            {
                if (shoppingCartItem == null)
                {
                    shoppingCartItem = new ShoppingCartItem
                    {
                        ShoppingCartId = ShoppingCartId,
                        Event = purchasedEvent,
                        Amount = amount,
                        Ticket = purchasedTicket
                    };

                    _eShopDbContext.ShoppingCartItems.Add(shoppingCartItem);
                }
                else
                {
                    shoppingCartItem.Amount = amount;             
                }
            }

            _eShopDbContext.SaveChanges();
        }

        public int RemoveFromCart(Event purchasedEvent)
        {
            var shoppingCartItem =
                    _eShopDbContext.ShoppingCartItems.SingleOrDefault(
                        e => e.Event.EventId == purchasedEvent.EventId && e.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _eShopDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
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
