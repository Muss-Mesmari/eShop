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

        public IEnumerable<Day> GetEventDays(int eventId)
        {
            int scheduleId = _eShopDbContext.Schedule.Where(sh => sh.ScheduleId == eventId).FirstOrDefault().ScheduleId;
            int weekId = _eShopDbContext.Week.Where(d => d.WeekId == scheduleId).FirstOrDefault().WeekId;
            return _eShopDbContext.Day.Where(d => d.WeekId == weekId).ToList();
        }

        public List<List<KeyValuePair<string, string>>> GetEventTimes(int eventId)
        {
            int scheduleId = _eShopDbContext.Schedule.Where(sh => sh.ScheduleId == eventId).FirstOrDefault().ScheduleId;
            int weekId = _eShopDbContext.Week.Where(d => d.WeekId == scheduleId).FirstOrDefault().WeekId;
            var dayIds = _eShopDbContext.Day.Where(w => w.WeekId == weekId).Select(d => d.DayId).ToList();

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

        public void CreateSchedule(EventCreateEditViewModel newEvent)
        {
            int eventId = _eShopDbContext.Events.Select(e => e.EventId).ToList().Last();
            var _newSchedule = new Schedule()
            {
                EventId = eventId,
            };
            _eShopDbContext.Schedule.Add(_newSchedule);
            _eShopDbContext.SaveChanges();
            
            int scheduleId = _newSchedule.ScheduleId;
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