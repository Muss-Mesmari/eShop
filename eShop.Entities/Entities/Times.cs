using System;
using System.Collections.Generic;

namespace eShop.Entities.Entities
{
    public class Times
    {
        public int TimesId { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public int DayId { get; set; }
        public virtual Day Day { get; set; }        
    }
}
