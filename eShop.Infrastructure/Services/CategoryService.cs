using eShop.Infrastructure.Database;
using eShop.Entities.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Linq;
using eShop.Presentation.ViewModels;
using Microsoft.EntityFrameworkCore;

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

        public Category GetCategoryById(int? categoryId)
        {
            return _eShopDbContext.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
        }

        public void CreateCategory(Category newCategory)
        {
            var _newCategory = new Category()
            {
                CategoryName = newCategory.CategoryName,
                Description = newCategory.Description
               // Events = newCategory.Events
            };
            _eShopDbContext.Categories.Add(_newCategory);
            _eShopDbContext.SaveChanges();
        }

        public void UpdateCategory(Category newCategory)
        {
            if (newCategory != null)
            {
                newCategory.CategoryName = newCategory.CategoryName;
                newCategory.Description = newCategory.Description;
               // newCategory.Events = newCategory.Events;
            }

            var entity = _eShopDbContext.Entry(newCategory);
            entity.State = EntityState.Modified;
            _eShopDbContext.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            var removedCategory = GetCategoryById(id);
            if (removedCategory != null)
            {
                _eShopDbContext.Remove(removedCategory);
                _eShopDbContext.SaveChanges();
            }
        }
    }
}
