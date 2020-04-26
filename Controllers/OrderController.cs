using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Infrastructure;
using eShop.Infrastructure.Services;
using eShop.Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using eShop.Infrastructure.Configuration;
using Microsoft.Extensions.Options;
using eShop.Infrastructure.Rule;
using eShop.Presentation.ViewModels;

namespace eShop.Web.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly ShoppingCartService _shoppingCartService;
        private readonly FeaturesConfiguration _featuresConfiguration;      
        private IRuleProcessor _ruleProcessor;

        public OrderController
            (
            IOrderService orderService, 
            ShoppingCartService shoppingCartService, 
            IOptions<FeaturesConfiguration> options,          
            IRuleProcessor ruleProcessor
            )
        {
            _orderService = orderService;
            _shoppingCartService = shoppingCartService;
            _featuresConfiguration = options.Value;          
            _ruleProcessor = ruleProcessor;
        }
        // GET: /<controller>/
        public IActionResult Checkout()
        {
            var (passedRules, errors) = _ruleProcessor.PassesAllRules();          
            if (passedRules)
            {
                return View();
            }
            else
            {
                return View("_BlockedPage");
            }
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCartService.GetShoppingCartItems();
            _shoppingCartService.ShoppingCartItems = items;

            if (_shoppingCartService.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty.");
            }

            if (ModelState.IsValid)
            {
                _orderService.CreateOrder(order);
                _shoppingCartService.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order!";
            return View();
        }
    }
}