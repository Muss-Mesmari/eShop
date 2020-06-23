using eShop.Infrastructure.Database;
using eShop.Entities.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Linq;
using eShop.Presentation.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Services
{
    public class TeachersService : ITeachersService
    {

        private readonly eShopDbContext _eShopDbContext;

        public TeachersService(eShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public IEnumerable<Teachers> AllTeachers => _eShopDbContext.Teachers;
        public Teachers GetTeachersById(int? eventId)
        {
            var teachersId = _eShopDbContext.Events.FirstOrDefault(e => e.EventId == eventId).TeachersId;
            var teachers = _eShopDbContext.Teachers.FirstOrDefault(t => t.TeachersId == teachersId);

            var entity = _eShopDbContext.Entry(teachers);
            entity.State = EntityState.Detached;

            return teachers;
        }
        public void CreateTeachers(EventCreateViewModel newEvent)
        {
            var newTeachers = new Teachers()
            {
                TeacherName = newEvent.Teachers.TeacherName,
                TeachingAssistantName = newEvent.Teachers.TeachingAssistantName
            };
            _eShopDbContext.Teachers.Add(newTeachers);
            _eShopDbContext.SaveChanges();
        }
        public void UpdateTeachers(EventEditViewModel newEvent)
        {
            var eventId = newEvent.Event.EventId;
            var teachers = GetTeachersById(eventId);

            var newTeachers = newEvent.Teachers;
            if (newTeachers != null)
            {
                newTeachers.TeachersId = teachers.TeachersId;
                newTeachers.TeacherName = newTeachers.TeacherName;
                newTeachers.TeachingAssistantName = newTeachers.TeachingAssistantName;
            }

            var entity = _eShopDbContext.Entry(newTeachers);
            entity.State = EntityState.Modified;
            _eShopDbContext.SaveChanges();
        }
        public void DeleteTeachers(int id)
        {
            var removedTeachers = GetTeachersById(id);
            if (removedTeachers != null)
            {
                _eShopDbContext.Remove(removedTeachers);
                _eShopDbContext.SaveChanges();
            }
        }

    }
}
