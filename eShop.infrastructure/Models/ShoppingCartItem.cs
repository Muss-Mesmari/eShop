using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Infrastructure.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Event Event { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
