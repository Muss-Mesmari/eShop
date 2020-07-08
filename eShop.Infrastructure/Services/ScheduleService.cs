using eShop.Entities.Entities;
using eShop.Infrastructure.Database;
using eShop.Presentation.ViewModels;
using FluentAssertions;
using FluentAssertions.Extensions;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.Infrastructure.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly eShopDbContext _eShopDbContext;
        public ScheduleService(eShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        // Try int? eventId instead of bool isNewEvent
        public IEnumerable<Day> GetEventDays(int eventId, bool isNewEvent)
        {
            List<Day> days = new List<Day>();
            if (!isNewEvent)
            {
                int scheduleId = _eShopDbContext.Schedule.Where(sh => sh.ScheduleId == eventId).FirstOrDefault().ScheduleId;
                var weekIds = _eShopDbContext.Week.Where(d => d.ScheduleId == scheduleId).Select(id => id.WeekId).ToList();

                foreach (var weekId in weekIds)
                {
                    days.Add(_eShopDbContext.Day.Where(d => d.WeekId == weekId).FirstOrDefault());
                }
            }
            return days;
        }

        public List<List<KeyValuePair<string, string>>> GetEventTimes(int eventId, bool isNewEvent)
        {
            if (!isNewEvent)
            {
                int scheduleId = _eShopDbContext.Schedule.Where(sh => sh.ScheduleId == eventId).FirstOrDefault().ScheduleId;
                var weekIds = _eShopDbContext.Week.Where(d => d.ScheduleId == scheduleId).Select(id => id.WeekId).ToList();

                List<int> dayIds = new List<int>();
                foreach (var weekId in weekIds)
                {
                    dayIds.Add(_eShopDbContext.Day.Where(w => w.WeekId == weekId).Select(d => d.DayId).FirstOrDefault());
                }

                var AlltimesOfEachDaySorted = new List<List<KeyValuePair<string, string>>>();
                if (dayIds != null)
                {
                    foreach (var dayId in dayIds)
                    {
                        var timesOfEachDaySorted = new List<KeyValuePair<string, string>>();
                        var timesOfEachDayUnsorted = _eShopDbContext.Times.Where(t => t.DayId == dayId).Select(t => t.TimesId).ToList();

                        for (int i = 0; i < timesOfEachDayUnsorted.Count(); i++)
                        {
                            var timeStart = _eShopDbContext.Times.Where(t => t.TimesId == timesOfEachDayUnsorted[i]).Select(t => t.TimeStart.ToString("hh:mm")).FirstOrDefault();
                            var timeEnd = _eShopDbContext.Times.Where(t => t.TimesId == timesOfEachDayUnsorted[i]).Select(t => t.TimeEnd.ToString("hh:mm")).FirstOrDefault();

                            timesOfEachDaySorted.Insert(i, new KeyValuePair<string, string>(timeStart, timeEnd));
                        }

                        AlltimesOfEachDaySorted.Add(timesOfEachDaySorted);
                    }
                }
                return AlltimesOfEachDaySorted;
            }
            else
            {
                return new List<List<KeyValuePair<string, string>>>();
            }     
        }

        public void CreateSchedule(EventCreateEditViewModel newEvent)
        {
            int eventId = _eShopDbContext.Events.Select(e => e.EventId).ToList().Last();

            // if the eventId does not have a ScheduleId, create new one
            // if not, find the ScheduleId and assign it to the eventId            
            var _newSchedule = new Schedule()
            {
                EventId = eventId
            };
            _eShopDbContext.Schedule.Add(_newSchedule);
            _eShopDbContext.SaveChanges();

            int scheduleId = _newSchedule.ScheduleId;
            if (scheduleId != eventId)
            {
                scheduleId = eventId;
                _eShopDbContext.Schedule.Remove(_newSchedule);
                _eShopDbContext.SaveChanges();
            }

            var newWeek = new Week()
            {
                ScheduleId = scheduleId
            };
            _eShopDbContext.Week.Add(newWeek);
            _eShopDbContext.SaveChanges();

            var weekId = newWeek.WeekId;
            var newDay = new Day()
            {
                DayOfWeek = newEvent.Day.DayOfWeek,
                WeekId = weekId
            };
            _eShopDbContext.Day.Add(newDay);
            _eShopDbContext.SaveChanges();

            var dayId = newDay.DayId;
            var newTimes = new Times()
            {
                TimeStart = newEvent.Times.TimeStart,
                TimeEnd = newEvent.Times.TimeEnd,
                DayId = dayId
            };
            _eShopDbContext.Times.Add(newTimes);
            _eShopDbContext.SaveChanges();
        }
    }
}