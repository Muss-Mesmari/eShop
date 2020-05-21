using eShop.Entities.Entities;
using eShop.Infrastructure.Services;
using eShop.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Web.Components
{
    public class SearchBar : ViewComponent
    {
        private readonly IEventService _eventService;
        private readonly ICategoryService _categoryService;

        public SearchBar
        (
            IEventService eventService,
            ICategoryService categoryService
        )
        {
            _eventService = eventService;
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {           
            return View(new HomeViewModel { } );
        }
    }
}
