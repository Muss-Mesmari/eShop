using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Presentation.ViewModels
{
    public class DetailsViewModel
    {
        public Event Event { get; set; }
        public IEnumerable<Day> Day { get; set; }
        public Location Location { get; set; }
        public Teachers Teachers { get; set; }
        public List<List<KeyValuePair<string, string>>> EventSchedule { get; set; }
    }
}
