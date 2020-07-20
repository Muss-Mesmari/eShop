using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShop.Entities.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public string TicketName { get; set; }
        public decimal TicketPrice { get; set; }
        public string Description { get; set; }
        public int TotalAvailableTicket { get; set; }        
    }
}
