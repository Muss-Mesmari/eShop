using eShop.Infrastructure;
using eShop.Infrastructure.Services;
using eShop.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Web.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCartService _shoppingCartService;

        public ShoppingCartSummary(ShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCartService.GetShoppingCartItems();
            _shoppingCartService.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCartService = _shoppingCartService,
                ShoppingCartTotalSEK = _shoppingCartService.GetShoppingCartTotalSEK(),
                ShoppingCartTotalEUR = _shoppingCartService.GetShoppingCartTotalEUR()
            };
            return View(shoppingCartViewModel);
        }
    }
}
