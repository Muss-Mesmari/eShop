using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eShop.Entities.Entities;
using eShop.Infrastructure.Database;
using eShop.Infrastructure.Services;
using eShop.Presentation.ViewModels;
using FluentAssertions;

namespace eShop.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IEventService _eventService;
        private readonly ICategoryService _categoryService;

        public CategoryController(IEventService eventService, ICategoryService categoryService)
        {
            _eventService = eventService;
            _categoryService = categoryService;
        }

        // GET: Category
        public ActionResult Index()
        {
            var categories = _categoryService.AllCategories.OrderBy(g => g.CategoryId);
            return View(categories);
        }

        // GET: Category/Details/5
        [Route("/Create-a-category", Name = "Create a category")]
        public IActionResult Details(int? id)
        {
            var model = _categoryService.GetCategoryById(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category newCategory)
        {
            if (ModelState.IsValid)
            {
                _categoryService.CreateCategory(newCategory);
                return RedirectToAction(nameof(Details), new { id = _categoryService.AllCategories.Max(c => c.CategoryId) });
            }
            return View();
        }

        // GET: Categories/Edit/5
        public IActionResult Edit(int id)
        {
            var viewModel = new Category
            {
                CategoryId = id,
                CategoryName = _categoryService.GetCategoryById(id).CategoryName,
                Description = _categoryService.GetCategoryById(id).Description,
                Events = _categoryService.GetCategoryById(id).Events
            };
            if (viewModel == null)
            {
                return View("NotFound");
            }
            return View(viewModel);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Category newCategory)
        {
            if (ModelState.IsValid)
            {
                _categoryService.UpdateCategory(newCategory);
                return RedirectToAction(nameof(Details), new { id = newCategory.CategoryId });
            }
            return View();
        }

        // GET: Categories/Delete/5
        public IActionResult Delete(int? id)
        {
            var model = _categoryService.GetCategoryById(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, Category removedCategory)
        {
            if (ModelState.IsValid)
            {
                _categoryService.DeleteCategory(id);
            }
            return RedirectToAction("Index");
        }

        private bool CategoryExists(int id)
        {
            return _categoryService.AllCategories.Any(e => e.CategoryId == id);
        }
    }
}
