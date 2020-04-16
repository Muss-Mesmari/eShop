using eShop.Data.Data;
using eShop.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.Data
{
    public class ShoppingCart
    {
        private readonly eShopDbContext _eShopDbContext;

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        private ShoppingCart(eShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<eShopDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       _eShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(e => e.Event)
                           .ToList());
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _eShopDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(e => e.Event.Price * e.Amount).Sum();
            return total;
        }

        public void AddToCart(Event purchasedEvent, int amount)
        {
            var shoppingCartItem =
                    _eShopDbContext.ShoppingCartItems.SingleOrDefault(
                        e => e.Event.EventId == purchasedEvent.EventId && e.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Event = purchasedEvent,
                    Amount = 1
                };

                _eShopDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
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
