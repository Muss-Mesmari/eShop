using eShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Services.IRepository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
