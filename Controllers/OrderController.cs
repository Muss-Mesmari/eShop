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

namespace eShop.Web.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly FeaturesConfiguration _featuresConfiguration;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart, IOptions<FeaturesConfiguration> options)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
            _featuresConfiguration = options.Value;
        }
        // GET: /<controller>/
        public IActionResult Checkout()
        {
            if (_featuresConfiguration.EnableOrder)
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