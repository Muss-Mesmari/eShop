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
    public class TeacherService : ITeacherService
    {

        private readonly eShopDbContext _eShopDbContext;

        public TeacherService(eShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public IEnumerable<Teacher> AllTeachers => _eShopDbContext.Teacher;
        //public Teachers GetTeachersById(int? eventId)
        //{
        //    var teachersId = _eShopDbContext.Events.FirstOrDefault(e => e.EventId == eventId).TeachersId;
        //    var teachers = _eShopDbContext.Teachers.FirstOrDefault(t => t.TeachersId == teachersId);

        //    var entity = _eShopDbContext.Entry(teachers);
        //    entity.State = EntityState.Detached;

        //    return teachers;
        //}
        public IEnumerable<Teacher> GetTeachersById(int? eventId)
        {
            var teachers = _eShopDbContext.Teacher.Where(e => e.EventId == eventId).ToList();
            foreach (var teacher in teachers)
            {
                var entity = _eShopDbContext.Entry(teacher);
                entity.State = EntityState.Detached;
            }
            return teachers;
        }
        //public void CreateTeachers(EventViewModel newEvent)
        //{
        //    var newTeachers = new Teachers()
        //    {
        //        TeacherName = newEvent.Teachers.TeacherName,
        //        TeachingAssistantName = newEvent.Teachers.TeachingAssistantName
        //    };
        //    _eShopDbContext.Teachers.Add(newTeachers);
        //    _eShopDbContext.SaveChanges();
        //}
        public void CreateTeacher(int eventId, EventViewModel newEvent)
        {
            var newTeachers = new Teacher()
            {
                EventId = eventId,
                TeacherName = newEvent.Teacher.TeacherName,
                TeacherDescription = newEvent.Teacher.TeacherDescription
            };
            _eShopDbContext.Teacher.Add(newTeachers);
            _eShopDbContext.SaveChanges();
        }
        //public void UpdateTeachers(EventViewModel newEvent)
        //{
        //    var eventId = newEvent.Event.EventId;
        //    var teachers = GetTeachersById(eventId);

        //    var newTeachers = newEvent.Teachers;
        //    if (newTeachers != null)
        //    {
        //        newTeachers.TeachersId = teachers.TeachersId;
        //        newTeachers.TeacherName = newTeachers.TeacherName;
        //        newTeachers.TeachingAssistantName = newTeachers.TeachingAssistantName;
        //    }

        //    var entity = _eShopDbContext.Entry(newTeachers);
        //    entity.State = EntityState.Modified;
        //    _eShopDbContext.SaveChanges();
        //}

        public void UpdateTeacher(int eventId, IEnumerable<Teacher> newTeachers)
        {
            var oldTeacher = GetTeachersById(eventId);
            var oldTeacherIds = oldTeacher.Select(t => t.TeacherId).ToList();

            var i = 0;
            foreach (var newTeacher in newTeachers)
            {
                if (newTeacher != null)
                {
                    newTeacher.EventId = eventId;
                    newTeacher.TeacherId = oldTeacherIds[i];
                    newTeacher.TeacherName = newTeacher.TeacherName;
                    newTeacher.TeacherDescription = newTeacher.TeacherDescription;
                    i++;
                }

                var entity = _eShopDbContext.Entry(newTeacher);
                entity.State = EntityState.Modified;
                _eShopDbContext.SaveChanges();
                // entity.State = EntityState.Detached;
            }
        }
        //public void DeleteTeachers(int teacherId)
        //{
        //    //  var removedTeachers = GetTeachersById(id);
        //    var removedTeachers = _eShopDbContext.Teacher.FirstOrDefault(t => t.TeacherId == teacherId);
        //    if (removedTeachers != null)
        //    {
        //        _eShopDbContext.Remove(removedTeachers);
        //        _eShopDbContext.SaveChanges();
        //    }
        //}


        public void DeleteTeacher(int id)
        {
            var removedTeacher = GetTeachersById(id);
            if (removedTeacher != null)
            {
                foreach (var teacher in removedTeacher)
                {
                    _eShopDbContext.Remove(teacher);
                    _eShopDbContext.SaveChanges();
                }
            }
        }
    }
}
