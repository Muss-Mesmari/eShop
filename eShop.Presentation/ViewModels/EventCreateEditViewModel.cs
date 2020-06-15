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
    }
}
