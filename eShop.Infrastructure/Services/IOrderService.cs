using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Infrastructure.Services
{
    public interface IOrderService
    {
        void CreateOrder(Order order);
    }
}
