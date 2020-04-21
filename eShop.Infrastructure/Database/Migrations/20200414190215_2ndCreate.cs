using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Infrastructure.Database.Migrations
{
    public partial class _2ndCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "EventId", "CategoryId", "ImageUrl", "InStock", "IsHighlightedEvent", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event One", 12.95m, "Lorem Ipsum" },
                    { 2, 1, "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Two", 12.95m, "Lorem Ipsum" },
                    { 3, 1, "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Three", 12.95m, "Lorem Ipsum" },
                    { 5, 1, "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Five", 12.95m, "Lorem Ipsum" },
                    { 6, 1, "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Six", 12.95m, "Lorem Ipsum" },
                    { 7, 1, "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Seven", 12.95m, "Lorem Ipsum" },
                    { 8, 1, "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Eight", 12.95m, "Lorem Ipsum" },
                    { 9, 1, "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Nine", 12.95m, "Lorem Ipsum" },
                    { 10, 1, "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", true, false, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Ten", 12.95m, "Lorem Ipsum" },
                    { 11, 1, "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Eleven", 12.95m, "Lorem Ipsum" },
                    { 4, 2, "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png", true, true, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Event Four", 12.95m, "Lorem Ipsum" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
