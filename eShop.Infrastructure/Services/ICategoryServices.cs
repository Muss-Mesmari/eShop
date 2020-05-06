using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;


namespace eShop.Infrastructure.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> AllCategories { get; }
        Category GetCategoryById(int? eventId);
        void CreateCategory(Category newCategory);
        void UpdateCategory(Category newCategory);
        void DeleteCategory(int id);

    }
}
