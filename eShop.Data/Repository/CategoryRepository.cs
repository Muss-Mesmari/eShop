using eShop.Data.Data;
using eShop.Data.IRepository;
using eShop.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Repository
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
