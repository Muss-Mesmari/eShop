using eShop.Infrastructure.Database;
using eShop.Entities.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Linq;
using eShop.Presentation.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Services
{
    public class TicketService : ITicketService
    {

        private readonly eShopDbContext _eShopDbContext;

        public TicketService(eShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public IEnumerable<Ticket> AllTickets => _eShopDbContext.Ticket;

        public IList<Ticket> GetTicketById(int eventId)
        {
            var tickets = _eShopDbContext.Ticket.Where(e => e.EventId == eventId).ToList();
            foreach (var ticket in tickets)
            {
                var entity = _eShopDbContext.Entry(ticket);
                entity.State = EntityState.Detached;
            }
            return tickets;
        }

        public void CreateTicket(int eventId, EventCreateEditViewModel newEvent)
        {           
            var _newTicket = new Ticket()
            {
                EventId = eventId,
                TicketName = newEvent.Ticket.TicketName,
                Description = newEvent.Ticket.Description,
                TicketPrice = newEvent.Ticket.TicketPrice,
                TotalAvailableTicket = newEvent.Ticket.TotalAvailableTicket
            };
            _eShopDbContext.Ticket.Add(_newTicket);
            _eShopDbContext.SaveChanges();
        }

        public void UpdateTicket(int eventId, IList<Ticket> newTickets)
        {
            var oldTickets = GetTicketById(eventId);
            var oldTicketsIds = oldTickets.Select(t => t.TicketId).ToList();

            var i = 0;
            foreach (var newTicket in newTickets)
            {
                if (newTicket != null)
                {
                    newTicket.EventId = eventId;
                    newTicket.TicketId = oldTicketsIds[i];
                    newTicket.TicketName = newTicket.TicketName;
                    newTicket.Description = newTicket.Description;
                    newTicket.TicketPrice = newTicket.TicketPrice;
                    newTicket.TotalAvailableTicket = newTicket.TotalAvailableTicket;
                    i++;
                }

                var entity = _eShopDbContext.Entry(newTicket);
                entity.State = EntityState.Modified;
                _eShopDbContext.SaveChanges();
                entity.State = EntityState.Detached;
            }
        }

        public void DeleteTickets(int id)
        {
            var removedTicket = GetTicketById(id);
            if (removedTicket != null)
            {
                foreach (var ticket in removedTicket)
                {
                    _eShopDbContext.Remove(ticket);
                    _eShopDbContext.SaveChanges();
                }
            }
        }

    }
}
