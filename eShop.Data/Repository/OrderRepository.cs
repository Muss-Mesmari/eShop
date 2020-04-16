using eShop.Data.Data;
using eShop.Data.IRepository;
using eShop.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly eShopDbContext _eShopDbContext;        

        public OrderRepository(eShopDbContext eShopDbContext, ShoppingCart shoppingCart)
        {
            _eShopDbContext = eShopDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();
            //adding the order with its details

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    EventId = shoppingCartItem.Event.EventId,
                    Price = shoppingCartItem.Event.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _eShopDbContext.Orders.Add(order);
            _eShopDbContext.SaveChanges();
        }
    }
}
