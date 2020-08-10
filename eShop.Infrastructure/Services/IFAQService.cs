using eShop.Entities.Entities;
using eShop.Presentation.ViewModels;
using System.Collections.Generic;

namespace eShop.Infrastructure.Services
{
    public interface IFAQService
    {
        IEnumerable<FAQ> AllFAQs { get; }
        void CreateFAQ(int eventId, EventViewModel newEvent);
        void DeleteFAQs(int id);
        IEnumerable<FAQ> GetFAQById(int? eventId);
        void UpdateFAQ(int eventId, IEnumerable<FAQ> newFAQs);
    }
}