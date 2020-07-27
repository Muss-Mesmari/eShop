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
        public DateTime Date { get; set; }
        public virtual ICollection<Times> Times { get; set; }
        public int WeekId { get; set; }
        public virtual Week Week { get; set; }       

    }
}
