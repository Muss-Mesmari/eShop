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
    public class CategoryService : ICategoryService
    {

        private readonly eShopDbContext _eShopDbContext;

        public CategoryService(eShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _eShopDbContext.Categories;        
    }
}
