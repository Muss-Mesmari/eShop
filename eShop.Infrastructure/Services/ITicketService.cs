using eShop.Entities.Entities;
using System.Collections.Generic;

namespace eShop.Infrastructure.Services
{
    public interface ITicketService
    {
        IEnumerable<Ticket> AllTickets { get; }
        //  void CreateLocation(EventCreateViewModel newEvent);
        //  void DeleteLocation(int id);
        public IEnumerable<Ticket> GetTicketById(int? eventId);
      //  void UpdateLocation(EventEditViewModel newEvent);
    }
}