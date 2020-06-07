using eShop.Entities.Entities;
using eShop.Infrastructure.Database;
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
    }
}