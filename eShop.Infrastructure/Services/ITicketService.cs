﻿using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using System.Collections.Generic;

namespace eShop.Infrastructure.Services
{
    public interface ITicketService
    {
        IEnumerable<Ticket> AllTickets { get; }
        void CreateTicket(int eventId, EventEditViewModel newEvent);
        //  void DeleteLocation(int id);
        public IList<Ticket> GetTicketById(int? eventId);
        void UpdateTicket(int eventId, IList<Ticket> newTickets);
    }
}