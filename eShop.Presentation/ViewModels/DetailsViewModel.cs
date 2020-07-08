
using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Presentation.ViewModels
{
    public class DetailsViewModel
    {
        public Event Event { get; set; }
        public IEnumerable<Day> Days { get; set; }
        public Location Location { get; set; }
        public Teachers Teachers { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
        public List<List<KeyValuePair<string, string>>> EventSchedule { get; set; }
        public decimal ShoppingCartItemTotalEUR { get; set; }
        public decimal ShoppingCartItemTotalSEK { get; set; }
        public int Amount { get; set; }
    }
}
