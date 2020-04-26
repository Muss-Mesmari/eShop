using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Infrastructure.Services
{
    public interface IOrderServices
    {
        void CreateOrder(Order order);
    }
}
