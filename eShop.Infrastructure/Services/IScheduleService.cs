using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using System;
using System.Collections.Generic;

namespace eShop.Infrastructure.Services
{
    public interface IScheduleService
    {
        public List<List<KeyValuePair<string, string>>> GetEventTimesList();
        IList<Day> AllDaysList { get; }

        IList<Day> GetEventDays(int eventId, bool isNewEvent);
        List<List<KeyValuePair<string, string>>> GetEventTimes(int eventId, bool isNewEvent);
        void CreateSchedule(EventCreateEditViewModel newEvent);
        void UpdateDays(int eventId, IList<Day> newDays);
        void UpdateTimes(int eventId, List<string> eventTimesBindedKey, List<string> eventTimesBindedValue);
        void DeleteSchedule(int? id);
    }
}