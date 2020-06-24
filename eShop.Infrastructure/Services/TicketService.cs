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

        public IEnumerable<Ticket> GetTicketById(int? eventId)
        {
            var tickets = _eShopDbContext.Ticket.Where(e => e.EventId == eventId).ToList();
            return tickets;
        }

        //public void CreateTicket(EventCreateViewModel newEvent)
        //{
        //    var _newTicket = new Ticket()
        //    {
        //        TicketName = newEvent.
        //        Street = newEvent.Location.Street,
        //        StreetNumber = newEvent.Location.StreetNumber,
        //        City = newEvent.Location.City,
        //        State = newEvent.Location.State,
        //        ZipCode = newEvent.Location.ZipCode
        //    };
        //    _eShopDbContext.Tickets.Add(_newTicket);
        //    _eShopDbContext.SaveChanges();
        //}

        //public void UpdateLocation(EventEditViewModel newEvent)
        //{
        //    var eventId = newEvent.Event.EventId;
        //    var location = GetLocationById(eventId);

        //    var newLocation = newEvent.Location;
        //    if (newLocation != null)
        //    {
        //        newLocation.LocationId = location.LocationId;
        //        newLocation.Street = newLocation.Street;
        //        newLocation.StreetNumber = newLocation.StreetNumber;
        //        newLocation.City = newLocation.City;
        //        newLocation.State = newLocation.State;
        //        newLocation.ZipCode = newLocation.ZipCode;
        //    }

        //    var entity = _eShopDbContext.Entry(newLocation);
        //    entity.State = EntityState.Modified;
        //    _eShopDbContext.SaveChanges();
        //}

        //public void DeleteLocation(int id)
        //{
        //    var removedLocation = GetLocationById(id);
        //    if (removedLocation != null)
        //    {
        //        _eShopDbContext.Remove(removedLocation);
        //        _eShopDbContext.SaveChanges();
        //    }
        //}

    }
}
