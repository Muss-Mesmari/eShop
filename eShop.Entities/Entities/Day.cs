using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShop.Entities.Entities
{
    public class Day
    {
        public int DayId { get; set; }

        [Display(Name = "Day of week")]
        public DayOfWeek DayOfWeek { get; set; }
        public virtual ICollection<Times> Times { get; set; }
        public int WeekId { get; set; }
        public virtual Week Week { get; set; }


        //[Display(Name = "Date")]
        //[DataType(DataType.Date)]
        //public DateTime EventDay { get; set; }
    }
}
