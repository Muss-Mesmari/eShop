using eShop.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.IRepository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
