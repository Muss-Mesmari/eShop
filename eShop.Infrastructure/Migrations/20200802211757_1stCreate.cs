using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Infrastructure.Migrations
{
    public partial class _1stCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    DanceRole = table.Column<int>(nullable: false),
                    DanceLevel = table.Column<int>(nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotalSEK = table.Column<decimal>(nullable: false),
                    OrderTotalEUR = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    HowToGo = table.Column<string>(nullable: true),
                    Currency = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsHighlightedEvent = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Location_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.ScheduleId);
                    table.ForeignKey(
                        name: "FK_Schedule_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(nullable: false),
                    TeacherName = table.Column<string>(nullable: true),
                    TeacherDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_Teacher_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TicketId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(nullable: false),
                    TicketName = table.Column<string>(nullable: true),
                    TicketPrice = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TotalAvailableTicket = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Ticket_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Week",
                columns: table => new
                {
                    WeekId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Week", x => x.WeekId);
                    table.ForeignKey(
                        name: "FK_Week_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "ScheduleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true),
                    TicketId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    DayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    WeekId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.DayId);
                    table.ForeignKey(
                        name: "FK_Day_Week_WeekId",
                        column: x => x.WeekId,
                        principalTable: "Week",
                        principalColumn: "WeekId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    TimesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    DayId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.TimesId);
                    table.ForeignKey(
                        name: "FK_Times_Day_DayId",
                        column: x => x.DayId,
                        principalTable: "Day",
                        principalColumn: "DayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Category One", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Category Two", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Category Three", null });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "CategoryId", "Currency", "HowToGo", "ImageUrl", "InStock", "IsHighlightedEvent", "LongDescription", "Name", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.", "https://www.nhm.ac.uk/content/dam/nhmwww/visit/Exhibitions/events/after-hours/silent-disco/silent-disco-calendar.jpg", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event One", "Lorem Ipsum" },
                    { 2, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.", "https://i.ytimg.com/vi/5Cy_KvI2nME/maxresdefault.jpg", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Two", "Lorem Ipsum" },
                    { 3, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.", "https://www.nhm.ac.uk/content/dam/nhmwww/visit/Exhibitions/events/after-hours/silent-disco/silent-disco-calendar.jpg", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Three", "Lorem Ipsum" },
                    { 5, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.", "https://www.nhm.ac.uk/content/dam/nhmwww/visit/Exhibitions/events/after-hours/silent-disco/silent-disco-calendar.jpg", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Five", "Lorem Ipsum" },
                    { 6, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.", "https://i.ytimg.com/vi/5Cy_KvI2nME/maxresdefault.jpg", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Six", "Lorem Ipsum" },
                    { 7, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.", "https://www.nhm.ac.uk/content/dam/nhmwww/visit/Exhibitions/events/after-hours/silent-disco/silent-disco-calendar.jpg", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Seven", "Lorem Ipsum" },
                    { 8, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.", "https://i.ytimg.com/vi/5Cy_KvI2nME/maxresdefault.jpg", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Eight", "Lorem Ipsum" },
                    { 9, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.", "https://www.nhm.ac.uk/content/dam/nhmwww/visit/Exhibitions/events/after-hours/silent-disco/silent-disco-calendar.jpg", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Nine", "Lorem Ipsum" },
                    { 10, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.", "https://i.ytimg.com/vi/5Cy_KvI2nME/maxresdefault.jpg", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Ten", "Lorem Ipsum" },
                    { 11, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.", "https://www.nhm.ac.uk/content/dam/nhmwww/visit/Exhibitions/events/after-hours/silent-disco/silent-disco-calendar.jpg", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Eleven", "Lorem Ipsum" },
                    { 4, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.", "https://i.ytimg.com/vi/5Cy_KvI2nME/maxresdefault.jpg", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Four", "Lorem Ipsum" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "City", "EventId", "State", "Street", "StreetNumber", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Stockholm län", 1, "Stockholm", "vägen", 1, 12345 },
                    { 14, "Stockholm län", 7, "Stockholm", "vägen", 14, 12353 },
                    { 13, "Stockholm län", 7, "Stockholm", "vägen", 13, 12352 },
                    { 15, "Stockholm län", 8, "Stockholm", "vägen", 15, 12354 },
                    { 16, "Stockholm län", 8, "Stockholm", "vägen", 16, 12355 },
                    { 12, "Stockholm län", 6, "Stockholm", "vägen", 12, 12351 },
                    { 11, "Stockholm län", 6, "Stockholm", "vägen", 11, 12355 },
                    { 17, "Stockholm län", 9, "Stockholm", "vägen", 17, 12352 },
                    { 18, "Stockholm län", 9, "Stockholm", "vägen", 18, 12353 },
                    { 10, "Stockholm län", 5, "Stockholm", "vägen", 10, 12354 },
                    { 9, "Stockholm län", 5, "Stockholm", "vägen", 9, 12353 },
                    { 19, "Stockholm län", 10, "Stockholm", "vägen", 19, 12354 },
                    { 6, "Stockholm län", 3, "Stockholm", "vägen", 6, 12350 },
                    { 5, "Stockholm län", 3, "Stockholm", "vägen", 5, 12349 },
                    { 21, "Stockholm län", 11, "Stockholm", "vägen", 21, 12354 },
                    { 22, "Stockholm län", 11, "Stockholm", "vägen", 22, 12355 },
                    { 20, "Stockholm län", 10, "Stockholm", "vägen", 20, 12355 },
                    { 2, "Stockholm län", 1, "Stockholm", "vägen", 2, 12346 },
                    { 7, "Stockholm län", 4, "Stockholm", "vägen", 7, 12351 },
                    { 3, "Stockholm län", 2, "Stockholm", "vägen", 3, 12347 },
                    { 8, "Stockholm län", 4, "Stockholm", "vägen", 8, 12352 },
                    { 4, "Stockholm län", 2, "Stockholm", "vägen", 4, 12348 }
                });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "ScheduleId", "EventId" },
                values: new object[,]
                {
                    { 9, 9 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 10, 10 },
                    { 4, 4 },
                    { 3, 3 },
                    { 2, 2 },
                    { 1, 1 },
                    { 8, 8 },
                    { 11, 11 }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "TeacherId", "EventId", "TeacherDescription", "TeacherName" },
                values: new object[,]
                {
                    { 25, 8, "Teacher Assistant Two Description", "Teacher Two" },
                    { 14, 4, "Teacher Assistant One Description", "Teacher One" },
                    { 24, 7, "Teacher Assistant One Description", "Teacher One" },
                    { 23, 7, "Teacher Assistant Three Description", "Teacher Three" },
                    { 13, 4, "Teacher Assistant Three Description", "Teacher Three" },
                    { 12, 4, "Teacher Assistant Two Description", "Teacher Two" },
                    { 34, 11, "Teacher Assistant One Description", "Teacher One" },
                    { 26, 8, "Teacher Assistant Three Description", "Teacher Three" },
                    { 27, 8, "Teacher Assistant Four Description", "Teacher One" },
                    { 28, 9, "Teacher Assistant One Description", "Teacher Two" },
                    { 29, 9, "Teacher Assistant Two Description", "Teacher Three" },
                    { 30, 9, "Teacher Assistant Three Description", "Teacher One" },
                    { 31, 10, "Teacher Assistant One Description", "Teacher One" },
                    { 35, 11, "Teacher Assistant One Description", "Teacher One" },
                    { 32, 10, "Teacher Assistant Two Description", "Teacher Two" },
                    { 33, 10, "Teacher Assistant Three Description", "Teacher Three" },
                    { 11, 4, "Teacher Assistant One Description", "Teacher One" },
                    { 22, 7, "Teacher Assistant Two Description", "Teacher Two" },
                    { 21, 7, "Teacher Assistant One Description", "Teacher One" },
                    { 10, 3, "Teacher Assistant Three Description", "Teacher One" },
                    { 16, 5, "Teacher Assistant Three Description", "Teacher Three" },
                    { 17, 5, "Teacher Assistant Four Description", "Teacher One" },
                    { 5, 2, "Teacher Assistant Two Description", "Teacher Two" },
                    { 8, 3, "Teacher Assistant One Description", "Teacher Two" },
                    { 6, 2, "Teacher Assistant Three Description", "Teacher Three" },
                    { 7, 2, "Teacher Assistant Four Description", "Teacher One" },
                    { 15, 5, "Teacher Assistant Two Description", "Teacher Two" },
                    { 4, 2, "Teacher Assistant One Description", "Teacher One" },
                    { 19, 6, "Teacher Assistant Two Description", "Teacher Three" },
                    { 20, 6, "Teacher Assistant Three Description", "Teacher One" },
                    { 3, 1, "Teacher Assistant Three Description", "Teacher Three" },
                    { 2, 1, "Teacher Assistant Two Description", "Teacher Two" },
                    { 1, 1, "Teacher Assistant One Description", "Teacher One" },
                    { 9, 3, "Teacher Assistant Two Description", "Teacher Three" },
                    { 18, 6, "Teacher Assistant One Description", "Teacher Two" }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "TicketId", "Description", "EventId", "TicketName", "TicketPrice", "TotalAvailableTicket" },
                values: new object[,]
                {
                    { 5, "Omnis et enim aperiam inventore", 2, "Ticket Two", 100m, 20 },
                    { 30, "Omnis et enim aperiam inventore", 10, "Ticket Two", 100m, 20 },
                    { 31, "Omnis et enim aperiam inventore", 10, "Ticket Three", 150m, 15 },
                    { 33, "Omnis et enim aperiam inventore", 11, "Ticket Two", 100m, 20 },
                    { 34, "Omnis et enim aperiam inventore", 11, "Ticket Three", 150m, 15 },
                    { 4, "Omnis et enim aperiam inventore", 1, "Ticket One", 50m, 10 },
                    { 3, "Omnis et enim aperiam inventore", 1, "Ticket Three", 150m, 15 },
                    { 2, "Omnis et enim aperiam inventore", 1, "Ticket Two", 100m, 20 },
                    { 1, "Omnis et enim aperiam inventore", 1, "Ticket One", 50m, 10 },
                    { 11, "Omnis et enim aperiam inventore", 4, "Ticket Two", 100m, 20 },
                    { 32, "Omnis et enim aperiam inventore", 11, "Ticket One", 50m, 10 },
                    { 29, "Omnis et enim aperiam inventore", 10, "Ticket Three", 150m, 15 },
                    { 19, "Omnis et enim aperiam inventore", 6, "Ticket One", 50m, 10 },
                    { 7, "Omnis et enim aperiam inventore", 2, "Ticket One", 50m, 10 },
                    { 18, "Omnis et enim aperiam inventore", 6, "Ticket Three", 150m, 15 },
                    { 20, "Omnis et enim aperiam inventore", 7, "Ticket Two", 100m, 20 },
                    { 21, "Omnis et enim aperiam inventore", 7, "Ticket Three", 150m, 15 },
                    { 22, "Omnis et enim aperiam inventore", 7, "Ticket One", 50m, 10 },
                    { 17, "Omnis et enim aperiam inventore", 6, "Ticket Two", 100m, 20 },
                    { 16, "Omnis et enim aperiam inventore", 5, "Ticket One", 50m, 10 },
                    { 15, "Omnis et enim aperiam inventore", 5, "Ticket Three", 150m, 15 },
                    { 23, "Omnis et enim aperiam inventore", 8, "Ticket Two", 100m, 20 },
                    { 6, "Omnis et enim aperiam inventore", 2, "Ticket Three", 150m, 15 },
                    { 24, "Omnis et enim aperiam inventore", 8, "Ticket Three", 150m, 15 },
                    { 14, "Omnis et enim aperiam inventore", 5, "Ticket Two", 100m, 20 },
                    { 10, "Omnis et enim aperiam inventore", 3, "Ticket One", 50m, 10 },
                    { 9, "Omnis et enim aperiam inventore", 3, "Ticket Three", 150m, 15 },
                    { 26, "Omnis et enim aperiam inventore", 9, "Ticket Three", 150m, 15 },
                    { 27, "Omnis et enim aperiam inventore", 9, "Ticket One", 50m, 10 },
                    { 28, "Omnis et enim aperiam inventore", 9, "Ticket Two", 100m, 20 },
                    { 8, "Omnis et enim aperiam inventore", 3, "Ticket Two", 100m, 20 },
                    { 12, "Omnis et enim aperiam inventore", 4, "Ticket Three", 150m, 15 },
                    { 25, "Omnis et enim aperiam inventore", 8, "Ticket Two", 100m, 20 },
                    { 13, "Omnis et enim aperiam inventore", 4, "Ticket One", 50m, 10 }
                });

            migrationBuilder.InsertData(
                table: "Week",
                columns: new[] { "WeekId", "ScheduleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 },
                    { 11, 11 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Day",
                columns: new[] { "DayId", "Date", "WeekId" },
                values: new object[,]
                {
                    { 1, new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 5, new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 6, new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 7, new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 8, new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 9, new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 10, new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 11, new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 4, new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimesId", "DayId", "TimeEnd", "TimeStart" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 8, 3, 1, 17, 56, 938, DateTimeKind.Local).AddTicks(2431), new DateTime(2020, 8, 2, 23, 17, 56, 935, DateTimeKind.Local).AddTicks(2535) },
                    { 2, 2, new DateTime(2020, 8, 3, 1, 17, 56, 938, DateTimeKind.Local).AddTicks(4164), new DateTime(2020, 8, 2, 23, 17, 56, 938, DateTimeKind.Local).AddTicks(4134) },
                    { 3, 3, new DateTime(2020, 8, 3, 1, 17, 56, 938, DateTimeKind.Local).AddTicks(4223), new DateTime(2020, 8, 2, 23, 17, 56, 938, DateTimeKind.Local).AddTicks(4218) },
                    { 5, 5, new DateTime(2020, 8, 3, 1, 17, 56, 938, DateTimeKind.Local).AddTicks(4286), new DateTime(2020, 8, 2, 23, 17, 56, 938, DateTimeKind.Local).AddTicks(4282) },
                    { 6, 6, new DateTime(2020, 8, 3, 1, 17, 56, 938, DateTimeKind.Local).AddTicks(4321), new DateTime(2020, 8, 2, 23, 17, 56, 938, DateTimeKind.Local).AddTicks(4317) },
                    { 7, 7, new DateTime(2020, 8, 3, 1, 17, 56, 938, DateTimeKind.Local).AddTicks(4351), new DateTime(2020, 8, 2, 23, 17, 56, 938, DateTimeKind.Local).AddTicks(4347) },
                    { 8, 8, new DateTime(2020, 8, 3, 1, 17, 56, 938, DateTimeKind.Local).AddTicks(4381), new DateTime(2020, 8, 2, 23, 17, 56, 938, DateTimeKind.Local).AddTicks(4377) },
                    { 9, 9, new DateTime(2020, 8, 3, 1, 17, 56, 938, DateTimeKind.Local).AddTicks(4412), new DateTime(2020, 8, 2, 23, 17, 56, 938, DateTimeKind.Local).AddTicks(4408) },
                    { 10, 10, new DateTime(2020, 8, 3, 1, 17, 56, 938, DateTimeKind.Local).AddTicks(4443), new DateTime(2020, 8, 2, 23, 17, 56, 938, DateTimeKind.Local).AddTicks(4440) },
                    { 11, 11, new DateTime(2020, 8, 3, 1, 17, 56, 938, DateTimeKind.Local).AddTicks(4474), new DateTime(2020, 8, 2, 23, 17, 56, 938, DateTimeKind.Local).AddTicks(4470) },
                    { 4, 4, new DateTime(2020, 8, 3, 1, 17, 56, 938, DateTimeKind.Local).AddTicks(4256), new DateTime(2020, 8, 2, 23, 17, 56, 938, DateTimeKind.Local).AddTicks(4252) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Day_WeekId",
                table: "Day",
                column: "WeekId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryId",
                table: "Events",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_EventId",
                table: "Location",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_EventId",
                table: "OrderDetails",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_EventId",
                table: "Schedule",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_EventId",
                table: "ShoppingCartItems",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_TicketId",
                table: "ShoppingCartItems",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_EventId",
                table: "Teacher",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_EventId",
                table: "Ticket",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Times_DayId",
                table: "Times",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Week_ScheduleId",
                table: "Week",
                column: "ScheduleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Times");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Day");

            migrationBuilder.DropTable(
                name: "Week");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
