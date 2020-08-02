
using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eShop.Presentation.ViewModels
{
    public class EventViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public List<Day> Days { get; set; }
        public List<List<Day>> DaysList { get; set; }
        public List<List<KeyValuePair<string, string>>> Times { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public string CurrentCategory { get; set; }
        public string SearchedEvent { get; set; }
        public string SearchedCategory { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public Day Day { get; set; }
        public Times Time { get; set; }
        public Location Location { get; set; }
        public Teacher Teacher { get; set; }
        public Ticket Ticket { get; set; }
        public decimal ShoppingCartItemTotalEUR { get; set; }
        public decimal ShoppingCartItemTotalSEK { get; set; }

        //[Required]
        //[UIHint("Number")]
        //[Display(Name = "")]
        public int SelectedAmount { get; set; }

        //[Required]
        //[UIHint("Number")]
        //[Display(Name = "", Prompt = "Choose a ticket")]
        public int SelectedTicketId { get; set; }
        public List<string> SelectedStartTimesBinded { get; set; }
        public List<string> SelectedEndTimesBinded { get; set; }
        public bool HomepageCategorySection { get; set; }
        public bool HomepageFeaturedEventsSection { get; set; }

        // Need to be looked at!
        public string SearchedEventBar { get; set; }
        public string NotFoundSearchedBarMessage { get; set; }
        public string NotFoundSearchedEventMessage { get; set; }
        public string NotFoundSchedule { get; set; }

    }
}
