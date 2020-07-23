using eShop.Infrastructure.Services;
using eShop.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace eShop.Web.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCartService ShoppingCartService { get; set; }
        public decimal ShoppingCartTotalSEK { get; set; }        
        public decimal ShoppingCartTotalEUR { get; set; }

        public IList<Ticket> Tickets { get; set; }


        [Required]
        [UIHint("Number")]
        [Display(Name = "Amount of classes", Prompt = "Enter an number")]
        public int SelectedAmount { get; set; }

        [Required]
        [UIHint("Number")]
        [Display(Name = "Type of ticket", Prompt = "Choose a ticket")]
        public int SelectedTicketId { get; set; }
    }
}
