using eShop.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Web.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public CategoryMenu(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.AllCategories.OrderBy(c => c.CategoryId);
            return View(categories);
        }
    }
}
