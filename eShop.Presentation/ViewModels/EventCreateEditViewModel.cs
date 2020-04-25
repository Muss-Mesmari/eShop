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
        public IEnumerable<Category> Categories { get; set; }
    }
}
