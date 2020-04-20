using eShop.Data.Data;
using eShop.Services.IRepository;
using eShop.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace eShop.Services.Repository
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
