using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShop.Entities.Entities
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
        public Teachers Teachers { get; set; }
        public int TeachersId { get; set; }
        public string HowToGo { get; set; }        
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
        public string ImageUrl { get; set; }
        public bool IsHighlightedEvent { get; set; }
        public bool InStock { get; set; }        
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
