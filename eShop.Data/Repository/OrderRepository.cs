using eShop.Data.Data;
using eShop.Data.IRepository;
using eShop.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Repository
{
    class OrderRepository : IOrderRepository
    {
        private readonly eShopDbContext _eShopDbContext;
       

        public OrderRepository(eShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

 
    }
}
