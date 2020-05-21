using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Presentation.ViewModels
{
    public class EventsListViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public string CurrentCategory { get; set; }
        public string SearchedEvent { get; set; }
        public string SearchedCategory { get; set; }
        public string NotFoundSearchedEventMessage { get; set; }
        public Event Event { get; set; }
        
    }
}
