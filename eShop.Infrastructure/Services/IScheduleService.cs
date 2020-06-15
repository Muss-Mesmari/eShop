using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using System;
using System.Collections.Generic;

namespace eShop.Infrastructure.Services
{
    public interface IScheduleService
    {
        public IEnumerable<Day> GetEventDays(int eventId);
        public List<List<KeyValuePair<string, string>>> GetEventTimes(int eventId);
        public void CreateSchedule(EventCreateEditViewModel newEvent);
    }
}