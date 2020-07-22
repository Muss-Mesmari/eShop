using eShop.Entities.Entities;
using eShop.Infrastructure.Database;
using eShop.Presentation.ViewModels;
using FluentAssertions;
using FluentAssertions.Extensions;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
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

        public IList<Day> AllDaysList => _eShopDbContext.Day.OrderBy(d => d.DayId).ToList();

        public IList<Day> GetEventDaysList()
        {
            List<Day> days = new List<Day>();
            List<int> weekIds = new List<int>();

            foreach (var daysList in AllDaysList)
            {
              //  int scheduleId = _eShopDbContext.Schedule.Where(sh => sh.ScheduleId == eventId).FirstOrDefault().ScheduleId;
                weekIds = _eShopDbContext.Week.Where(d => d.WeekId == daysList.WeekId).Select(id => id.WeekId).ToList();
            }
          

            foreach (var weekId in weekIds)
            {
                days.Add(_eShopDbContext.Day.Where(d => d.WeekId == weekId).FirstOrDefault());
            }

            return days;
        }

        public List<List<KeyValuePair<string, string>>> GetEventTimesList()
        {
            var AlltimesOfEachDaySorted = new List<List<KeyValuePair<string, string>>>();
            for (int i = 0; i < AllDaysList.Count(); i++)
            {
                var timesOfEachDaySorted = new List<KeyValuePair<string, string>>();
                var times = _eShopDbContext.Times.Where(t => t.DayId == AllDaysList[i].DayId).OrderBy(t => t.TimesId).Select(t => t.TimesId).ToList().Count();
                for (int j = 0; j < times; j++)
                {
                    var timeStart = _eShopDbContext.Times.Where(t => t.DayId == AllDaysList[i].DayId).OrderBy(t => t.TimesId).Select(t => t.TimeStart.ToString("hh:mm")).ToList()[j];
                    var timeEnd = _eShopDbContext.Times.Where(t => t.DayId == AllDaysList[i].DayId).OrderBy(t => t.TimesId).Select(t => t.TimeEnd.ToString("hh:mm")).ToList()[j];
                    timesOfEachDaySorted.Insert(j, new KeyValuePair<string, string>(timeStart, timeEnd));
                }
                AlltimesOfEachDaySorted.Add(timesOfEachDaySorted);
            }

            return AlltimesOfEachDaySorted;
        }

        // Try int? eventId instead of bool isNewEvent
        public IList<Day> GetEventDays(int eventId, bool isNewEvent)
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

        public void UpdateDays(int eventId, IList<Day> newDays)
        {
            // Get the needed Ids
            int scheduleId = _eShopDbContext.Schedule.Where(sh => sh.ScheduleId == eventId).FirstOrDefault().ScheduleId;
            List<int> weekIds = _eShopDbContext.Week.Where(d => d.ScheduleId == scheduleId).Select(id => id.WeekId).ToList();
            List<int> dayIds = new List<int>();
            foreach (var weekId in weekIds)
            {
                dayIds.Add(_eShopDbContext.Day.Where(w => w.WeekId == weekId).Select(d => d.DayId).FirstOrDefault());
            }

            // Update the days
            foreach (var weekId in weekIds)
            {
                var i = 0;
                foreach (var newDay in newDays)
                {
                    if (newDay != null)
                    {
                        newDay.DayOfWeek = newDay.DayOfWeek;
                        newDay.WeekId = weekId;
                        newDay.DayId = dayIds[i];
                        i++;
                    }

                    var entity = _eShopDbContext.Entry(newDay);
                    entity.State = EntityState.Modified;
                    _eShopDbContext.SaveChanges();
                    entity.State = EntityState.Detached;
                }
            }

        }

        private List<int> GetDaysIds(int eventId)
        {
            int scheduleId = _eShopDbContext.Schedule.Where(sh => sh.ScheduleId == eventId).FirstOrDefault().ScheduleId;
            List<int> weekIds = _eShopDbContext.Week.Where(d => d.ScheduleId == scheduleId).Select(id => id.WeekId).ToList();
            List<int> dayIds = new List<int>();

            foreach (var weekId in weekIds)
            {
                var day = _eShopDbContext.Day.Where(w => w.WeekId == weekId).FirstOrDefault();
                dayIds.Add(day.DayId);
                var entity = _eShopDbContext.Entry(day);
                entity.State = EntityState.Detached;
            }
            return dayIds;
        }

        private int GetScheduleId(int? eventId)
        {
            var schedule = _eShopDbContext.Schedule.Where(sh => sh.ScheduleId == eventId).FirstOrDefault();
            int scheduleId = schedule.ScheduleId;
            var entity = _eShopDbContext.Entry(schedule);
            entity.State = EntityState.Detached;
            return scheduleId;
        }

        private Schedule GetScheduleById(int? eventId)
        {
            var schedule = _eShopDbContext.Schedule.Where(sh => sh.ScheduleId == eventId).FirstOrDefault();
            var entity = _eShopDbContext.Entry(schedule);
            entity.State = EntityState.Detached;
            return schedule;
        }
        public void UpdateTimes(int eventId, List<string> eventTimesBindedKey, List<string> eventTimesBindedValue)
        {
            // Get the needed Ids
            var dayIds = GetDaysIds(eventId);

            if (dayIds != null)
            {
                foreach (var dayId in dayIds)
                {
                    var timesIds = _eShopDbContext.Times.Where(t => t.DayId == dayId).Select(t => t.TimesId).ToList();


                    for (int i = 0; i < timesIds.Count(); i++)
                    {
                        var newTimeStart = eventTimesBindedKey[i];
                        var newTimeEnd = eventTimesBindedValue[i];

                        // update the times
                        var newTimes = new Times()
                        {
                            TimeStart = DateTime.Parse(newTimeStart),
                            TimeEnd = DateTime.Parse(newTimeEnd),
                            DayId = dayId,
                            TimesId = timesIds[i]
                        };

                        var entity = _eShopDbContext.Entry(newTimes);
                        entity.State = EntityState.Modified;
                        _eShopDbContext.SaveChanges();
                        entity.State = EntityState.Detached;
                    }
                }
            }
        }

        public void DeleteSchedule(int? id)
        {
            var removedSchedule = GetScheduleById(id);
            if (removedSchedule != null)
            {
                _eShopDbContext.Remove(removedSchedule);
                _eShopDbContext.SaveChanges();
            }
        }
    }
}