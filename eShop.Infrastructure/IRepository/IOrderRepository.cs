using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Infrastructure.IRepository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
