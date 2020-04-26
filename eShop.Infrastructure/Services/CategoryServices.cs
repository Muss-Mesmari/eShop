using eShop.Infrastructure.Database;
using eShop.Entities.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace eShop.Infrastructure.Services
{
    public class CategoryServices : ICategoryServices
    {

        private readonly eShopDbContext _eShopDbContext;

        public CategoryServices(eShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _eShopDbContext.Categories;        
    }
}
