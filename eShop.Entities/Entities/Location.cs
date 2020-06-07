using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Entities.Entities
{
    public class Location
    {
        public int LocationId { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
    }
}
