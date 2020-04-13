using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.infrastructure.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int EventId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Event Event { get; set; }
        public Order Order { get; set; }
    }
}
