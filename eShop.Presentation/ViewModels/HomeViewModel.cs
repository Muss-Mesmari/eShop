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
        public IEnumerable<Category> AllCategories { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public bool HomepageCategorySection { get; set; }
        public bool HomepageFeaturedEventsSection { get; set; }
        public string SearchedEvent { get; set; }
        public string SearchedCategory { get; set; }
    }
}
