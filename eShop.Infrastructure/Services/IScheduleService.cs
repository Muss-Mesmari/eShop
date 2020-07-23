using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using System;
using System.Collections.Generic;

namespace eShop.Infrastructure.Services
{
    public interface IScheduleService
    {
        List<List<KeyValuePair<string, string>>> GetAllEventsTimesList();
        IEnumerable<Day> AllDaysList { get; }

        IEnumerable<Day> GetEventDays(int eventId, bool isNewEvent);
        List<List<KeyValuePair<string, string>>> GetEventTimes(int eventId, bool isNewEvent);


        void CreateSchedule(EventViewModel newEvent);
        void UpdateDays(int eventId, IEnumerable<Day> newDays);
        void UpdateTimes(int eventId, List<string> selectedStartTimesBinded, List<string> selectedEndTimesBinded);
        void DeleteSchedule(int? id);
    }
}