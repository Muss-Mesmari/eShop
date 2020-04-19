using System;
using System.Collections.Generic;
using System.Text;
using eShop.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eShop.Data.Data
{
    public class eShopDbContext : IdentityDbContext<IdentityUser>
    {
        public eShopDbContext(DbContextOptions<eShopDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Category One" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Category Two" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Category Three" });

            //seed events

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 1,
                Name = "Event One",
                Price = 12.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsHighlightedEvent = true
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 2,
                Name = "Event Two",
                Price = 12.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsHighlightedEvent = true
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 3,
                Name = "Event Three",
                Price = 12.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsHighlightedEvent = false
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 4,
                Name = "Event Four",
                Price = 12.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 2,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsHighlightedEvent = true
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 5,
                Name = "Event Five",
                Price = 12.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsHighlightedEvent = false
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 6,
                Name = "Event Six",
                Price = 12.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsHighlightedEvent = false
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 7,
                Name = "Event Seven",
                Price = 12.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsHighlightedEvent = false
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 8,
                Name = "Event Eight",
                Price = 12.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsHighlightedEvent = false
            });


            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 9,
                Name = "Event Nine",
                Price = 12.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsHighlightedEvent = true
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 10,
                Name = "Event Ten",
                Price = 12.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsHighlightedEvent = false
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 11,
                Name = "Event Eleven",
                Price = 12.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsHighlightedEvent = true
            });
        }

    }
}
