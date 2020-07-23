using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using System.Collections.Generic;

namespace eShop.Infrastructure.Services
{
    public interface ITicketService
    {
        IEnumerable<Ticket> AllTickets { get; }
        void CreateTicket(int eventId, EventViewModel newEvent);
        IEnumerable<Ticket> GetTicketById(int? eventId);
        void UpdateTicket(int eventId, IEnumerable<Ticket> newTickets);
        void DeleteTickets(int id);
    }
}