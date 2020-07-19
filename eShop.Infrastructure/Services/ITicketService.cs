using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using System.Collections.Generic;

namespace eShop.Infrastructure.Services
{
    public interface ITicketService
    {
        IEnumerable<Ticket> AllTickets { get; }
        void CreateTicket(int eventId, EventCreateEditViewModel newEvent);        
        IList<Ticket> GetTicketById(int? eventId);
        void UpdateTicket(int eventId, IList<Ticket> newTickets);
        void DeleteTickets(int id);
    }
}