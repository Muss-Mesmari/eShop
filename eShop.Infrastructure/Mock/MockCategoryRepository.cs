using eShop.Infrastructure.Services;
using eShop.Entities.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Infrastructure.Mock
{
    public class MockCategoryRepository : ICategoryService
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
                new Category{CategoryId=1, CategoryName="Category One", Description="All events of category one"},
                new Category{CategoryId=2, CategoryName="Category Two", Description="All events of category two"},
                new Category{CategoryId=3, CategoryName="Category Three", Description="All events of category three"}
        };

        public void CreateCategory(Category newCategory)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int? eventId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category newCategory)
        {
            throw new NotImplementedException();
        }
    }
}
