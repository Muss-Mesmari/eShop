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
            var scheduleId = _eShopDbContext.Schedule.Where(sh => sh.ScheduleId == eventId).FirstOrDefault().ScheduleId;
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
            var weekId = _eShopDbContext.Week.Select(w => w.WeekId).ToList().Last() + 1;
            int dayId = _eShopDbContext.Day.Select(d => d.DayId).ToList().Last() + 1;
            int scheduleId = _eShopDbContext.Schedule.Select(sh => sh.ScheduleId).ToList().Last();

            var _newDay = new Day()
            {
                DayOfWeek = newEvent.Day.DayOfWeek,
                WeekId = weekId
            };

            var _newTimes = new Times()
            {
                TimeStart = newEvent.Times.TimeStart,
                TimeEnd = newEvent.Times.TimeEnd,
                DayId = dayId
            };

            var _newWeek = new Week()
            {
                ScheduleId = scheduleId                
            };

            _eShopDbContext.Week.Add(_newWeek);
            _eShopDbContext.SaveChanges();

            _eShopDbContext.Day.Add(_newDay);
            _eShopDbContext.SaveChanges();

            _eShopDbContext.Times.Add(_newTimes);
            _eShopDbContext.SaveChanges();
        }
    }
}