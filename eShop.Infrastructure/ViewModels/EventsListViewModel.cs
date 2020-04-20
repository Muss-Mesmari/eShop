using eShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Services.ViewModels
{
    public class EventsListViewModel
    {
        public IEnumerable<Event> Events { get; set; }
        public string CurrentCategory { get; set; }        
    }
}
