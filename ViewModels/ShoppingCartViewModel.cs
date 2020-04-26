using eShop.Infrastructure.Services;
using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace eShop.Web.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotalSEK { get; set; }        
        public decimal ShoppingCartTotalEUR { get; set; }
    }
}
