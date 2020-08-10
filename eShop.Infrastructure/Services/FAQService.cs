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
    public class FAQService : IFAQService
    {

        private readonly eShopDbContext _eShopDbContext;

        public FAQService(eShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public IEnumerable<FAQ> AllFAQs => _eShopDbContext.FAQ;

        public IEnumerable<FAQ> GetFAQById(int? eventId)
        {
            var faqs = _eShopDbContext.FAQ.Where(e => e.EventId == eventId).ToList();
            foreach (var faq in faqs)
            {
                var entity = _eShopDbContext.Entry(faq);
                entity.State = EntityState.Detached;
            }
            return faqs;
        }

        public void CreateFAQ(int eventId, EventViewModel newEvent)
        {
            if (newEvent.FAQ != null)
            {
                var _newFAQ = new FAQ()
                {
                    EventId = eventId,
                    Question = newEvent.FAQ.Question,
                    Answer = newEvent.FAQ.Answer
                };
                _eShopDbContext.FAQ.Add(_newFAQ);
            }
            _eShopDbContext.SaveChanges();
        }

        public void UpdateFAQ(int eventId, IEnumerable<FAQ> newFAQs)
        {
            var oldFAQs = GetFAQById(eventId);
            var oldFAQsIds = oldFAQs.Select(f => f.FAQId).ToList();

            var i = 0;
            foreach (var newFAQ in newFAQs)
            {
                if (newFAQ != null)
                {
                    newFAQ.EventId = eventId;
                    newFAQ.FAQId = oldFAQsIds[i];
                    newFAQ.Question = newFAQ.Question;
                    newFAQ.Answer = newFAQ.Answer;
                    i++;
                }

                var entity = _eShopDbContext.Entry(newFAQ);
                entity.State = EntityState.Modified;
                _eShopDbContext.SaveChanges();
            }
        }

        public void DeleteFAQs(int id)
        {
            var removedFAQ = GetFAQById(id);

            if (removedFAQ != null)
            {
                foreach (var faq in removedFAQ)
                {
                    _eShopDbContext.Remove(faq);
                    _eShopDbContext.SaveChanges();
                }
            }
        }

    }
}
