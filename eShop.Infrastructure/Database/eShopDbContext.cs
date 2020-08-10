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

        public DbSet<FAQ> FAQ { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
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
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 1, WeekId = 1, /*DayOfWeek = DayOfWeek.Monday,*/ Date = DateTime.Parse("10/22/2015") });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 2, WeekId = 2, /*DayOfWeek = DayOfWeek.Monday,*/ Date = DateTime.Parse("10/22/2015") });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 3, WeekId = 3, /*DayOfWeek = DayOfWeek.Monday,*/ Date = DateTime.Parse("10/22/2015") });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 4, WeekId = 4, /*DayOfWeek = DayOfWeek.Monday,*/ Date = DateTime.Parse("10/22/2015") });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 5, WeekId = 5, /*DayOfWeek = DayOfWeek.Monday,*/ Date = DateTime.Parse("10/22/2015") });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 6, WeekId = 6, /*DayOfWeek = DayOfWeek.Monday,*/ Date = DateTime.Parse("10/22/2015") });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 7, WeekId = 7, /*DayOfWeek = DayOfWeek.Monday,*/ Date = DateTime.Parse("10/22/2015") });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 8, WeekId = 8, /*DayOfWeek = DayOfWeek.Monday,*/ Date = DateTime.Parse("10/22/2015") });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 9, WeekId = 9, /*DayOfWeek = DayOfWeek.Monday,*/ Date = DateTime.Parse("10/22/2015") });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 10, WeekId = 10, /*DayOfWeek = DayOfWeek.Monday,*/ Date = DateTime.Parse("10/22/2015") });
            modelBuilder.Entity<Day>().HasData(new Day { DayId = 11, WeekId = 11, /*DayOfWeek = DayOfWeek.Monday,*/ Date = DateTime.Parse("10/22/2015") });

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

            //seed location
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 1, State = "Stockholm", Street = "vägen", StreetNumber = 1, City = "Stockholm län", ZipCode = 12345, EventId = 1 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 2, State = "Stockholm", Street = "vägen", StreetNumber = 2, City = "Stockholm län", ZipCode = 12346, EventId = 1 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 3, State = "Stockholm", Street = "vägen", StreetNumber = 3, City = "Stockholm län", ZipCode = 12347, EventId = 2 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 4, State = "Stockholm", Street = "vägen", StreetNumber = 4, City = "Stockholm län", ZipCode = 12348, EventId = 2 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 5, State = "Stockholm", Street = "vägen", StreetNumber = 5, City = "Stockholm län", ZipCode = 12349, EventId = 3 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 6, State = "Stockholm", Street = "vägen", StreetNumber = 6, City = "Stockholm län", ZipCode = 12350, EventId = 3 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 7, State = "Stockholm", Street = "vägen", StreetNumber = 7, City = "Stockholm län", ZipCode = 12351, EventId = 4 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 8, State = "Stockholm", Street = "vägen", StreetNumber = 8, City = "Stockholm län", ZipCode = 12352, EventId = 4 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 9, State = "Stockholm", Street = "vägen", StreetNumber = 9, City = "Stockholm län", ZipCode = 12353, EventId = 5 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 10, State = "Stockholm", Street = "vägen", StreetNumber = 10, City = "Stockholm län", ZipCode = 12354, EventId = 5 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 11, State = "Stockholm", Street = "vägen", StreetNumber = 11, City = "Stockholm län", ZipCode = 12355, EventId = 6 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 12, State = "Stockholm", Street = "vägen", StreetNumber = 12, City = "Stockholm län", ZipCode = 12351, EventId = 6 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 13, State = "Stockholm", Street = "vägen", StreetNumber = 13, City = "Stockholm län", ZipCode = 12352, EventId = 7 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 14, State = "Stockholm", Street = "vägen", StreetNumber = 14, City = "Stockholm län", ZipCode = 12353, EventId = 7 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 15, State = "Stockholm", Street = "vägen", StreetNumber = 15, City = "Stockholm län", ZipCode = 12354, EventId = 8 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 16, State = "Stockholm", Street = "vägen", StreetNumber = 16, City = "Stockholm län", ZipCode = 12355, EventId = 8 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 17, State = "Stockholm", Street = "vägen", StreetNumber = 17, City = "Stockholm län", ZipCode = 12352, EventId = 9 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 18, State = "Stockholm", Street = "vägen", StreetNumber = 18, City = "Stockholm län", ZipCode = 12353, EventId = 9 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 19, State = "Stockholm", Street = "vägen", StreetNumber = 19, City = "Stockholm län", ZipCode = 12354, EventId = 10 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 20, State = "Stockholm", Street = "vägen", StreetNumber = 20, City = "Stockholm län", ZipCode = 12355, EventId = 10 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 21, State = "Stockholm", Street = "vägen", StreetNumber = 21, City = "Stockholm län", ZipCode = 12354, EventId = 11 });
            modelBuilder.Entity<Location>().HasData(new Location { LocationId = 22, State = "Stockholm", Street = "vägen", StreetNumber = 22, City = "Stockholm län", ZipCode = 12355, EventId = 11 });

            //seed faq
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 1, Question = "Question no.1", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 1 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 2, Question = "Question no.2", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 1 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 3, Question = "Question no.3", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 2 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 4, Question = "Question no.1", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 2 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 5, Question = "Question no.2", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 2 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 6, Question = "Question no.3", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 2 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 7, Question = "Question no.1", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 3 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 8, Question = "Question no.2", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 3 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 9, Question = "Question no.3", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 3 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 10, Question = "Question no.1", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 4 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 11, Question = "Question no.2", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 4 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 12, Question = "Question no.3", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 4 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 13, Question = "Question no.1", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 5 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 14, Question = "Question no.2", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 5 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 15, Question = "Question no.3", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 5 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 16, Question = "Question no.1", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 6 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 17, Question = "Question no.2", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 6 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 18, Question = "Question no.3", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 6 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 19, Question = "Question no.1", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 7 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 20, Question = "Question no.2", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 7 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 21, Question = "Question no.3", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 7 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 22, Question = "Question no.1", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 8 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 23, Question = "Question no.2", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 8 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 24, Question = "Question no.3", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 8 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 25, Question = "Question no.1", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 9 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 26, Question = "Question no.2", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 9 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 27, Question = "Question no.3", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 9 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 28, Question = "Question no.1", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 10 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 29, Question = "Question no.2", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 10 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 30, Question = "Question no.3", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 10 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 31, Question = "Question no.1", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 11 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 32, Question = "Question no.2", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 11 });
            modelBuilder.Entity<FAQ>().HasData(new FAQ { FAQId = 33, Question = "Question no.3", Answer = "Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch.Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.", EventId = 11});

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

            //seed teachers
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 1, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant One Description", EventId = 1 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 2, TeacherName = "Teacher Two", TeacherDescription = "Teacher Assistant Two Description", EventId = 1 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 3, TeacherName = "Teacher Three", TeacherDescription = "Teacher Assistant Three Description", EventId = 1 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 4, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant One Description", EventId = 2 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 5, TeacherName = "Teacher Two", TeacherDescription = "Teacher Assistant Two Description", EventId = 2 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 6, TeacherName = "Teacher Three", TeacherDescription = "Teacher Assistant Three Description", EventId = 2 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 7, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant Four Description", EventId = 2 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 8, TeacherName = "Teacher Two", TeacherDescription = "Teacher Assistant One Description",  EventId = 3 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 9, TeacherName = "Teacher Three", TeacherDescription = "Teacher Assistant Two Description", EventId = 3 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 10, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant Three Description",  EventId = 3 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 11, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant One Description", EventId = 4 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 12, TeacherName = "Teacher Two", TeacherDescription = "Teacher Assistant Two Description", EventId = 4 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 13, TeacherName = "Teacher Three", TeacherDescription = "Teacher Assistant Three Description", EventId = 4 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 14, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant One Description", EventId = 4 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 15, TeacherName = "Teacher Two", TeacherDescription = "Teacher Assistant Two Description", EventId = 5 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 16, TeacherName = "Teacher Three", TeacherDescription = "Teacher Assistant Three Description", EventId = 5 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 17, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant Four Description", EventId = 5 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 18, TeacherName = "Teacher Two", TeacherDescription = "Teacher Assistant One Description", EventId = 6 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 19, TeacherName = "Teacher Three", TeacherDescription = "Teacher Assistant Two Description", EventId = 6 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 20, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant Three Description", EventId = 6 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 21, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant One Description", EventId = 7 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 22, TeacherName = "Teacher Two", TeacherDescription = "Teacher Assistant Two Description", EventId = 7 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 23, TeacherName = "Teacher Three", TeacherDescription = "Teacher Assistant Three Description", EventId = 7 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 24, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant One Description", EventId = 7 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 25, TeacherName = "Teacher Two", TeacherDescription = "Teacher Assistant Two Description", EventId = 8 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 26, TeacherName = "Teacher Three", TeacherDescription = "Teacher Assistant Three Description", EventId = 8 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 27, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant Four Description", EventId = 8 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 28, TeacherName = "Teacher Two", TeacherDescription = "Teacher Assistant One Description", EventId = 9 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 29, TeacherName = "Teacher Three", TeacherDescription = "Teacher Assistant Two Description", EventId = 9 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 30, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant Three Description", EventId = 9 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 31, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant One Description", EventId = 10 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 32, TeacherName = "Teacher Two", TeacherDescription = "Teacher Assistant Two Description", EventId = 10 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 33, TeacherName = "Teacher Three", TeacherDescription = "Teacher Assistant Three Description", EventId = 10 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 34, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant One Description", EventId = 11 });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { TeacherId = 35, TeacherName = "Teacher One", TeacherDescription = "Teacher Assistant One Description", EventId = 11 });
           
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
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
               
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
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
             
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
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
             
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
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
              
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
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
              
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
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
            
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
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
              
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
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
      
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
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
             
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
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
           
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
                HowToGo = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.",
           
            });
        }

    }
}
