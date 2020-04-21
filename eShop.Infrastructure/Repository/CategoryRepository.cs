using eShop.Infrastructure.Database;
using eShop.Infrastructure.IRepository;
using eShop.Entities.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace eShop.Infrastructure.Repository
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly eShopDbContext _eShopDbContext;

        public CategoryRepository(eShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _eShopDbContext.Categories;        
    }
}
