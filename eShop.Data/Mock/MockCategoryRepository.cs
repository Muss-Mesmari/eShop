using eShop.Data.IRepository;
using eShop.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Mock
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
                new Category{CategoryId=1, CategoryName="Category One", Description="All events of category one"},
                new Category{CategoryId=2, CategoryName="Category Two", Description="All events of category two"},
                new Category{CategoryId=3, CategoryName="Category Three", Description="All events of category three"}
        };


    }
}
