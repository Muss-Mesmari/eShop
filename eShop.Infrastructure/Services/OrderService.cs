using eShop.Infrastructure.Database;
using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        private readonly ShoppingCartService _shoppingCartService;
        private readonly eShopDbContext _eShopDbContext;
      //  private readonly ITicketService _ticketService;

        public OrderService
            (
          //  ITicketService ticketService,
            eShopDbContext eShopDbContext,
            ShoppingCartService shoppingCartService
            )
        {
           // _ticketService = ticketService;
            _eShopDbContext = eShopDbContext;
            _shoppingCartService = shoppingCartService;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCartService.ShoppingCartItems;
            order.OrderTotalSEK = _shoppingCartService.GetShoppingCartTotalSEK();
            order.OrderTotalEUR = _shoppingCartService.GetShoppingCartTotalEUR();

            order.OrderDetails = new List<OrderDetail>();

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    EventId = shoppingCartItem.Event.EventId,
                    Price = shoppingCartItem.Ticket.TicketPrice
                };

                order.OrderDetails.Add(orderDetail);
            }

            _eShopDbContext.Orders.Add(order);
            _eShopDbContext.SaveChanges();
        }
    }
}
