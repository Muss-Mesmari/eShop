using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Presentation.ViewModels
{
    public class EventCreateEditViewModel
    {
        public int EventId { get; set; }
        public Event Event { get; set; }
        public Day Day { get; set; }
        public Times Times { get; set; }
        public Location Location { get; set; }
        public Teachers Teachers { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public List<List<KeyValuePair<string, string>>> EventTimes { get; set; }            
        public List<string> EventTimesBindedKey { get; set; }
        public List<string> EventTimesBindedValue { get; set; }
        public IList<Day> Days { get; set; }
        public IList<Ticket> Tickets { get; set; }
        public Ticket Ticket { get; set; }
        public decimal ShoppingCartItemTotalEUR { get; set; }
        public decimal ShoppingCartItemTotalSEK { get; set; }

        [Required]
        [UIHint("Number")]       
        [Display(Name = "Amount of classes", Prompt = "Enter an number")]       
        public int Amount { get; set; }

        [Required]
        [UIHint("Number")]
        [Display(Name = "Type of ticket", Prompt = "Choose a ticket")]
        public int SelectedTicketId { get; set; }        

    }
}
