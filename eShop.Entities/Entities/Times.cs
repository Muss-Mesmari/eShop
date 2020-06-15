using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eShop.Entities.Entities
{
    public class Times
    {
        public int TimesId { get; set; }

        [Display(Name = "Start time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime TimeStart { get; set; }

        [Display(Name = "End time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime TimeEnd { get; set; }
        public int DayId { get; set; }
        public virtual Day Day { get; set; }        
    }
}
