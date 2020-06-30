using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Presentation.ViewModels
{
    public class EventEditViewModel
    {   
        public Event Event { get; set; }
        public Day Day { get; set; }
        public Times Times { get; set; }
        public Location Location { get; set; }
        public Teachers Teachers { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IList<Ticket> Tickets { get; set; }
        public Ticket Ticket { get; set; }
    }
}
