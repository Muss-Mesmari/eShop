using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Presentation.ViewModels
{
    public class EventCreateEditViewModel
    {   
        public Event Event { get; set; }
        public Day Day { get; set; }
        public Times Times { get; set; }
        public Location Location { get; set; }
        public Teachers Teachers { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Day> Days { get; set; }
        public List<List<KeyValuePair<string, string>>> EventSchedule { get; set; }
        public IList<Ticket> Tickets { get; set; }
        public Ticket Ticket { get; set; }

        public decimal ShoppingCartItemTotalEUR { get; set; }
        public decimal ShoppingCartItemTotalSEK { get; set; }
        public int Amount { get; set; }
    }
}
