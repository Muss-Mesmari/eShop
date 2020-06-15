using System;
using System.Collections.Generic;

namespace eShop.Entities.Entities
{
    public class Schedule
    { 
        public int ScheduleId { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public virtual ICollection<Week> Week { get; set; }
    }

}