using eShop.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.IRepository
{
    public interface IEventRepository
    {
        IEnumerable<Event> AllEvents { get; }
        IEnumerable<Event> IsHighlightedEvent { get; }
        Event GetEventById(int? eventId);
    }
}
