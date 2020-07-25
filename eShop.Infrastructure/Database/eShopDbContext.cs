using eShop.Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace eShop.Infrastructure.Database
{
    public class eShopDbContext : IdentityDbContext<IdentityUser>
    {
        public eShopDbContext(DbContextOptions<eShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Day> Day { get; set; }
        public DbSet<Week> Week { get; set; }
        public DbSet<Times> Times { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed day
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 1, WeekId = 1, DayOfWeek = DayOfWeek.Monday });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 2, WeekId = 2, DayOfWeek = DayOfWeek.Monday });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 3, WeekId = 3, DayOfWeek = DayOfWeek.Monday });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 4, WeekId = 4, DayOfWeek = DayOfWeek.Monday });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 5, WeekId = 5, DayOfWeek = DayOfWeek.Monday });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 6, WeekId = 6, DayOfWeek = DayOfWeek.Monday });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 7, WeekId = 7, DayOfWeek = DayOfWeek.Monday });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 8, WeekId = 8, DayOfWeek = DayOfWeek.Monday });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 9, WeekId = 9, DayOfWeek = DayOfWeek.Monday });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 10, WeekId = 10, DayOfWeek = DayOfWeek.Monday });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 11, WeekId = 11, DayOfWeek = DayOfWeek.Monday });

            //seed week
            modelBuilder.Entity<Week>().HasData(new Week { WeekId = 1, ScheduleId = 1 });
            modelBuilder.Entity<Week>().HasData(new Week { WeekId = 2, ScheduleId = 2 });
            modelBuilder.Entity<Week>().HasData(new Week { WeekId = 3, ScheduleId = 3 });
            modelBuilder.Entity<Week>().HasData(new Week { WeekId = 4, ScheduleId = 4 });
            modelBuilder.Entity<Week>().HasData(new Week { WeekId = 5, ScheduleId = 5 });
            modelBuilder.Entity<Week>().HasData(new Week { WeekId = 6, ScheduleId = 6 });
            modelBuilder.Entity<Week>().HasData(new Week { WeekId = 7, ScheduleId = 7 });
            modelBuilder.Entity<Week>().HasData(new Week { WeekId = 8, ScheduleId = 8 });
            modelBuilder.Entity<Week>().HasData(new Week { WeekId = 9, ScheduleId = 9 });
            modelBuilder.Entity<Week>().HasData(new Week { WeekId = 10, ScheduleId = 10 });
            modelBuilder.Entity<Week>().HasData(new Week { WeekId = 11, ScheduleId = 11 });


            //seed times
            modelBuilder.Entity<Times>().HasData(new Times
            {
                TimesId = 1,
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now.AddHours(2),
                DayId = 1 
            });
            modelBuilder.Entity<Times>().HasData(new Times
            {
                TimesId = 2,
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now.AddHours(2),
                DayId = 2 
            });
            modelBuilder.Entity<Times>().HasData(new Times
            {
                TimesId = 3,
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now.AddHours(2),
                DayId = 3 
            });
            modelBuilder.Entity<Times>().HasData(new Times
            {
                TimesId = 4,
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now.AddHours(2),
                DayId = 4 
            });
            modelBuilder.Entity<Times>().HasData(new Times
            {
                TimesId = 5,
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now.AddHours(2),
                DayId = 5 
            });
            modelBuilder.Entity<Times>().HasData(new Times
            {
                TimesId = 6,
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now.AddHours(2),
                DayId = 6 
            });
            modelBuilder.Entity<Times>().HasData(new Times
            {
                TimesId = 7,
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now.AddHours(2),
                DayId = 7 
            });
            modelBuilder.Entity<Times>().HasData(new Times
            {
                TimesId = 8,
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now.AddHours(2),
                DayId = 8 
            });
            modelBuilder.Entity<Times>().HasData(new Times
            {
                TimesId = 9,
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now.AddHours(2),
                DayId = 9 
            });
            modelBuilder.Entity<Times>().HasData(new Times
            {
                TimesId = 10,
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now.AddHours(2),
                DayId = 10 
            });
            modelBuilder.Entity<Times>().HasData(new Times
            {
                TimesId = 11,
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now.AddHours(2),
                DayId = 11 
            });

            //seed schedule
            modelBuilder.Entity<Schedule>().HasData(new Schedule { ScheduleId = 1, EventId = 1 });
            modelBuilder.Entity<Schedule>().HasData(new Schedule { ScheduleId = 2, EventId = 2 });
            modelBuilder.Entity<Schedule>().HasData(new Schedule { ScheduleId = 3, EventId = 3 });
            modelBuilder.Entity<Schedule>().HasData(new Schedule { ScheduleId = 4, EventId = 4 });
            modelBuilder.Entity<Schedule>().HasData(new Schedule { ScheduleId = 5, EventId = 5 });
            modelBuilder.Entity<Schedule>().HasData(new Schedule { ScheduleId = 6, EventId = 6 });
            modelBuilder.Entity<Schedule>().HasData(new Schedule { ScheduleId = 7, EventId = 7 });
            modelBuilder.Entity<Schedule>().HasData(new Schedule { ScheduleId = 8, EventId = 8 });
            modelBuilder.Entity<Schedule>().HasData(new Schedule { ScheduleId = 9, EventId = 9 });
            modelBuilder.Entity<Schedule>().HasData(new Schedule { ScheduleId = 10, EventId = 10 });
            modelBuilder.Entity<Schedule>().HasData(new Schedule { ScheduleId = 11, EventId = 11 });

            //seed teachers
            modelBuilder.Entity<Teachers>().HasData(new Teachers { TeachersId = 1, TeacherName = "Teacher One", TeachingAssistantName = "Teaching Assistant One" });
            modelBuilder.Entity<Teachers>().HasData(new Teachers { TeachersId = 2, TeacherName = "Teacher Two", TeachingAssistantName = "Teaching Assistant Two" });
            modelBuilder.Entity<Teachers>().HasData(new Teachers { TeachersId = 3, TeacherName = "Teacher Three", TeachingAssistantName = "Teaching Assistant Three" });
            modelBuilder.Entity<Teachers>().HasData(new Teachers { TeachersId = 4, TeacherName = "Teacher One", TeachingAssistantName = "Teaching Assistant One" });
            modelBuilder.Entity<Teachers>().HasData(new Teachers { TeachersId = 5, TeacherName = "Teacher Two", TeachingAssistantName = "Teaching Assistant Two" });
            modelBuilder.Entity<Teachers>().HasData(new Teachers { TeachersId = 6, TeacherName = "Teacher Three", TeachingAssistantName = "Teaching Assistant Three" });
            modelBuilder.Entity<Teachers>().HasData(new Teachers { TeachersId = 7, TeacherName = "Teacher Two", TeachingAssistantName = "Teaching Assistant Two" });
            modelBuilder.Entity<Teachers>().HasData(new Teachers { TeachersId = 8, TeacherName = "Teacher Three", TeachingAssistantName = "Teaching Assistant Three" });
            modelBuilder.Entity<Teachers>().HasData(new Teachers { TeachersId = 9, TeacherName = "Teacher One", TeachingAssistantName = "Teaching Assistant One" });
            modelBuilder.Entity<Teachers>().HasData(new Teachers { TeachersId = 10, TeacherName = "Teacher Two", TeachingAssistantName = "Teaching Assistant Two" });
            modelBuilder.Entity<Teachers>().HasData(new Teachers { TeachersId = 11, TeacherName = "Teacher Three", TeachingAssistantName = "Teaching Assistant Three" });

            //seed location
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 1, State = "Stockholm", Street = "vägen", StreetNumber = 1, City = "Stockholm län", ZipCode = 12345 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 2, State = "Stockholm", Street = "vägen", StreetNumber = 2, City = "Stockholm län", ZipCode = 12346 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 3, State = "Stockholm", Street = "vägen", StreetNumber = 3, City = "Stockholm län", ZipCode = 12347 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 4, State = "Stockholm", Street = "vägen", StreetNumber = 4, City = "Stockholm län", ZipCode = 12348 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 5, State = "Stockholm", Street = "vägen", StreetNumber = 5, City = "Stockholm län", ZipCode = 12349 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 6, State = "Stockholm", Street = "vägen", StreetNumber = 6, City = "Stockholm län", ZipCode = 12350 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 7, State = "Stockholm", Street = "vägen", StreetNumber = 7, City = "Stockholm län", ZipCode = 12351 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 8, State = "Stockholm", Street = "vägen", StreetNumber = 8, City = "Stockholm län", ZipCode = 12352 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 9, State = "Stockholm", Street = "vägen", StreetNumber = 9, City = "Stockholm län", ZipCode = 12353 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 10, State = "Stockholm", Street = "vägen", StreetNumber = 10, City = "Stockholm län", ZipCode = 12354 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 11, State = "Stockholm", Street = "vägen", StreetNumber = 11, City = "Stockholm län", ZipCode = 12355 });
 
            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Category One" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Category Two" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Category Three" });

            //seed tickets
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 1, TicketName = "Ticket One", TicketPrice = 50, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 10, EventId = 1 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 2, TicketName = "Ticket Two", TicketPrice = 100, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 20, EventId = 1 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 3, TicketName = "Ticket Three", TicketPrice = 150, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 15, EventId = 1 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 4, TicketName = "Ticket One", TicketPrice = 50, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 10, EventId = 1 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 5, TicketName = "Ticket Two", TicketPrice = 100, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 20, EventId = 2 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 6, TicketName = "Ticket Three", TicketPrice = 150, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 15, EventId = 2 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 7, TicketName = "Ticket One", TicketPrice = 50, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 10, EventId = 2 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 8, TicketName = "Ticket Two", TicketPrice = 100, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 20, EventId = 3 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 9, TicketName = "Ticket Three", TicketPrice = 150, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 15, EventId = 3 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 10, TicketName = "Ticket One", TicketPrice = 50, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 10, EventId = 3 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 11, TicketName = "Ticket Two", TicketPrice = 100, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 20, EventId = 4 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 12, TicketName = "Ticket Three", TicketPrice = 150, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 15, EventId = 4 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 13, TicketName = "Ticket One", TicketPrice = 50, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 10, EventId = 4 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 14, TicketName = "Ticket Two", TicketPrice = 100, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 20, EventId = 5 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 15, TicketName = "Ticket Three", TicketPrice = 150, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 15, EventId = 5 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 16, TicketName = "Ticket One", TicketPrice = 50, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 10, EventId = 5 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 17, TicketName = "Ticket Two", TicketPrice = 100, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 20, EventId = 6 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 18, TicketName = "Ticket Three", TicketPrice = 150, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 15, EventId = 6 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 19, TicketName = "Ticket One", TicketPrice = 50, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 10, EventId = 6 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 20, TicketName = "Ticket Two", TicketPrice = 100, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 20, EventId = 7 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 21, TicketName = "Ticket Three", TicketPrice = 150, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 15, EventId = 7 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 22, TicketName = "Ticket One", TicketPrice = 50, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 10, EventId = 7 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 23, TicketName = "Ticket Two", TicketPrice = 100, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 20, EventId = 8 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 24, TicketName = "Ticket Three", TicketPrice = 150, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 15, EventId = 8 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 25, TicketName = "Ticket Two", TicketPrice = 100, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 20, EventId = 8 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 26, TicketName = "Ticket Three", TicketPrice = 150, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 15, EventId = 9 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 27, TicketName = "Ticket One", TicketPrice = 50, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 10, EventId = 9 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 28, TicketName = "Ticket Two", TicketPrice = 100, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 20, EventId = 9 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 29, TicketName = "Ticket Three", TicketPrice = 150, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 15, EventId = 10 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 30, TicketName = "Ticket Two", TicketPrice = 100, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 20, EventId = 10 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 31, TicketName = "Ticket Three", TicketPrice = 150, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 15, EventId = 10 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 32, TicketName = "Ticket One", TicketPrice = 50, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 10, EventId = 11 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 33, TicketName = "Ticket Two", TicketPrice = 100, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 20, EventId = 11 });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { TicketId = 34, TicketName = "Ticket Three", TicketPrice = 150, Description = "Omnis et enim aperiam inventore", TotalAvailableTicket = 15, EventId = 11 });

            //seed events
            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 1,
                Name = "Event One",
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://www.nhm.ac.uk/content/dam/nhmwww/visit/Exhibitions/events/after-hours/silent-disco/silent-disco-calendar.jpg",
                InStock = true,
                IsHighlightedEvent = true,                
                LocationId = 1,
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
                TeachersId = 1
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 2,
                Name = "Event Two",              
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://i.ytimg.com/vi/5Cy_KvI2nME/maxresdefault.jpg",
                InStock = true,
                IsHighlightedEvent = true,               
                LocationId = 2,
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
                TeachersId = 2
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 3,
                Name = "Event Three",            
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://www.nhm.ac.uk/content/dam/nhmwww/visit/Exhibitions/events/after-hours/silent-disco/silent-disco-calendar.jpg",
                InStock = true,
                IsHighlightedEvent = false,                
                LocationId = 3,
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
                TeachersId = 3
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 4,
                Name = "Event Four",           
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 2,
                ImageUrl = "https://i.ytimg.com/vi/5Cy_KvI2nME/maxresdefault.jpg",
                InStock = true,
                IsHighlightedEvent = true,               
                LocationId = 4,
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
                TeachersId = 4
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 5,
                Name = "Event Five",           
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://www.nhm.ac.uk/content/dam/nhmwww/visit/Exhibitions/events/after-hours/silent-disco/silent-disco-calendar.jpg",
                InStock = true,
                IsHighlightedEvent = false,               
                LocationId = 5,
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
                TeachersId = 5
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 6,
                Name = "Event Six",              
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://i.ytimg.com/vi/5Cy_KvI2nME/maxresdefault.jpg",
                InStock = true,
                IsHighlightedEvent = false,               
                LocationId = 6,
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
                TeachersId = 6
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 7,
                Name = "Event Seven",              
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://www.nhm.ac.uk/content/dam/nhmwww/visit/Exhibitions/events/after-hours/silent-disco/silent-disco-calendar.jpg",
                InStock = true,
                IsHighlightedEvent = false,                
                LocationId = 7,
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
                TeachersId = 7
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 8,
                Name = "Event Eight",              
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://i.ytimg.com/vi/5Cy_KvI2nME/maxresdefault.jpg",
                InStock = true,
                IsHighlightedEvent = false,               
                LocationId = 8,
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
                TeachersId = 8
            });


            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 9,
                Name = "Event Nine",             
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://www.nhm.ac.uk/content/dam/nhmwww/visit/Exhibitions/events/after-hours/silent-disco/silent-disco-calendar.jpg",
                InStock = true,
                IsHighlightedEvent = true,                
                LocationId = 9,
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
                TeachersId = 9
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 10,
                Name = "Event Ten",             
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://i.ytimg.com/vi/5Cy_KvI2nME/maxresdefault.jpg",
                InStock = true,
                IsHighlightedEvent = false,               
                LocationId = 10,
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
                TeachersId = 10
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 11,
                Name = "Event Eleven",          
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://www.nhm.ac.uk/content/dam/nhmwww/visit/Exhibitions/events/after-hours/silent-disco/silent-disco-calendar.jpg",
                InStock = true,
                IsHighlightedEvent = true,                
                LocationId = 11,
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
                TeachersId = 11
            });
        }

    }
}
