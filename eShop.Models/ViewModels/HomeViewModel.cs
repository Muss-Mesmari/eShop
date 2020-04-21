using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Presentation.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Event> IsHighlightedEvent { get; set; }
    }
}
