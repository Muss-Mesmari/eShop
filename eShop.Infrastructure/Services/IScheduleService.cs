using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using System;
using System.Collections.Generic;

namespace eShop.Infrastructure.Services
{
    public interface IScheduleService
    {
        public IEnumerable<Day> GetEventDays(int eventId, bool isNewEvent);
        public List<List<KeyValuePair<string, string>>> GetEventTimes(int eventId, bool isNewEvent);
        public void CreateSchedule(EventCreateEditViewModel newEvent);
    }
}