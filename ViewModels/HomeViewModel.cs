using eShop.infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Web.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Event> IsHighlightedEvent { get; set; }
    }
}
