using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Infrastructure;
using eShop.Infrastructure.IRepository;
using eShop.Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using eShop.Infrastructure.Repository;
using Microsoft.CodeAnalysis.Options;
using eShop.Services;
using Microsoft.Extensions.Options;
using eShop.Infrastructure.Rule;

namespace eShop.Web.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly FeaturesConfiguration _featuresConfiguration;      
        private readonly IRuleProcessor _ruleProcessor;

        public OrderController
            (IOrderRepository orderRepository, 
            ShoppingCart shoppingCart, 
            IOptions<FeaturesConfiguration> options,          
            IRuleProcessor ruleProcessor)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
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
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty.");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
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