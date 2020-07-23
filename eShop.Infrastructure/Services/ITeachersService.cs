using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using System.Collections.Generic;

namespace eShop.Infrastructure.Services
{
    public interface ITeachersService
    {
        IEnumerable<Teachers> AllTeachers { get; }
        void CreateTeachers(EventViewModel newEvent);
        void DeleteTeachers(int id);
        Teachers GetTeachersById(int? eventId);
        void UpdateTeachers(EventViewModel newEvent);        
    }
}