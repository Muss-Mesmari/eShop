﻿using eShop.Infrastructure;
using eShop.Infrastructure.Repository;
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
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotalSEK = _shoppingCart.GetShoppingCartTotalSEK(),
                ShoppingCartTotalEUR = _shoppingCart.GetShoppingCartTotalEUR()
            };
            return View(shoppingCartViewModel);
        }
    }
}