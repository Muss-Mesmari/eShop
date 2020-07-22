using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Presentation.ViewModels
{
    public class HomeViewModel
    {
        public List<List<KeyValuePair<string, string>>> EventTimes { get; set; }
        public IList<Day> Days { get; set; }
        public IEnumerable<Event> IsHighlightedEvent { get; set; }
        public IEnumerable<Category> AllCategories { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public bool HomepageCategorySection { get; set; }
        public bool HomepageFeaturedEventsSection { get; set; }
        public string SearchedEventBar { get; set; }
        public string NotFoundSearchedBarMessage { get; set; }
    }
}
