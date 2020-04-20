using eShop.Services.IRepository;
using eShop.Data.Entities;
using eShop.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.Services.Mock
{
    public class MockEventRepository : IEventRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Event> AllEvents =>
            new List<Event>
            {

                new Event {EventId = 1, Name="Event One", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", InStock=true, IsHighlightedEvent=false},
                new Event {EventId = 2, Name="Event Two", Price=18.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", InStock=true, IsHighlightedEvent=false},
                new Event {EventId = 3, Name="Event Three", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", InStock=true, IsHighlightedEvent=true} 
            };

        public IEnumerable<Event> IsHighlightedEvent { get; }

        public void CreateEvent(EventCreateEditViewModel newEvent)
        {
            throw new NotImplementedException();
        }

        public void DeleteEvent(int id)
        {
            throw new NotImplementedException();
        }

        public Event GetEventById(int? eventId)
        {
            return AllEvents.FirstOrDefault(e => e.EventId == eventId);
        }

        public void UpdateEvent(EventCreateEditViewModel oldEvent)
        {
            throw new NotImplementedException();
        }
    }
}
