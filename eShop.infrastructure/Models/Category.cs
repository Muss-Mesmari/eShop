using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Infrastructure.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Event> Events { get; set; }
    }
}
