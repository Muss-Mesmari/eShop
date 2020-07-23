using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Entities.Entities
{
    public class Week
    {
        public int WeekId { get; set; }
        public virtual ICollection<Day> Day { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }        
    }
}
