using eShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Services.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Event> IsHighlightedEvent { get; set; }
    }
}
