using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using System.Collections.Generic;

namespace eShop.Infrastructure.Services
{
    public interface ITeacherService
    {
        IEnumerable<Teacher> AllTeachers { get; }
        void CreateTeacher(int eventId, EventViewModel newEvent);
        void DeleteTeacher(int id);
        IEnumerable<Teacher> GetTeachersById(int? eventId);
        void UpdateTeacher(int eventId, IEnumerable<Teacher> newTeachers);        
    }
}