﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Entities.Entities
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Event Event { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
        public Ticket Ticket { get; set; }          
    }
}
