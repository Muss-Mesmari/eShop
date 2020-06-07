using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Infrastructure.Migrations
{
    public partial class _2ndCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayOfWeekFive",
                table: "Day");

            migrationBuilder.DropColumn(
                name: "DayOfWeekFour",
                table: "Day");

            migrationBuilder.DropColumn(
                name: "DayOfWeekOne",
                table: "Day");

            migrationBuilder.DropColumn(
                name: "DayOfWeekSeven",
                table: "Day");

            migrationBuilder.DropColumn(
                name: "DayOfWeekSix",
                table: "Day");

            migrationBuilder.DropColumn(
                name: "DayOfWeekThree",
                table: "Day");

            migrationBuilder.DropColumn(
                name: "DayOfWeekTwo",
                table: "Day");

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeek",
                table: "Day",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 1,
                column: "DayOfWeek",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 2,
                column: "DayOfWeek",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 3,
                column: "DayOfWeek",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 4,
                column: "DayOfWeek",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 5,
                column: "DayOfWeek",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 6,
                column: "DayOfWeek",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 7,
                column: "DayOfWeek",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 8,
                column: "DayOfWeek",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 9,
                column: "DayOfWeek",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 10,
                column: "DayOfWeek",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 11,
                columns: new[] { "DayOfWeek", "DaysId" },
                values: new object[] { 1, 11 });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 8, 21, 587, DateTimeKind.Local).AddTicks(4823), new DateTime(2020, 5, 31, 21, 8, 21, 584, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 8, 21, 587, DateTimeKind.Local).AddTicks(6615), new DateTime(2020, 5, 31, 21, 8, 21, 587, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 8, 21, 587, DateTimeKind.Local).AddTicks(6676), new DateTime(2020, 5, 31, 21, 8, 21, 587, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 8, 21, 587, DateTimeKind.Local).AddTicks(6711), new DateTime(2020, 5, 31, 21, 8, 21, 587, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 8, 21, 587, DateTimeKind.Local).AddTicks(6744), new DateTime(2020, 5, 31, 21, 8, 21, 587, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 8, 21, 587, DateTimeKind.Local).AddTicks(6781), new DateTime(2020, 5, 31, 21, 8, 21, 587, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 8, 21, 587, DateTimeKind.Local).AddTicks(6813), new DateTime(2020, 5, 31, 21, 8, 21, 587, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 8, 21, 587, DateTimeKind.Local).AddTicks(6846), new DateTime(2020, 5, 31, 21, 8, 21, 587, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 8, 21, 587, DateTimeKind.Local).AddTicks(6880), new DateTime(2020, 5, 31, 21, 8, 21, 587, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 8, 21, 587, DateTimeKind.Local).AddTicks(6913), new DateTime(2020, 5, 31, 21, 8, 21, 587, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 8, 21, 587, DateTimeKind.Local).AddTicks(6945), new DateTime(2020, 5, 31, 21, 8, 21, 587, DateTimeKind.Local).AddTicks(6939) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "Day");

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeekFive",
                table: "Day",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeekFour",
                table: "Day",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeekOne",
                table: "Day",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeekSeven",
                table: "Day",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeekSix",
                table: "Day",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeekThree",
                table: "Day",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeekTwo",
                table: "Day",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 1,
                columns: new[] { "DayOfWeekFive", "DayOfWeekFour", "DayOfWeekOne", "DayOfWeekSeven", "DayOfWeekSix", "DayOfWeekThree", "DayOfWeekTwo" },
                values: new object[] { 1, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 2,
                columns: new[] { "DayOfWeekFive", "DayOfWeekFour", "DayOfWeekOne", "DayOfWeekSeven", "DayOfWeekSix", "DayOfWeekThree", "DayOfWeekTwo" },
                values: new object[] { 1, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 3,
                columns: new[] { "DayOfWeekFive", "DayOfWeekFour", "DayOfWeekOne", "DayOfWeekSeven", "DayOfWeekSix", "DayOfWeekThree", "DayOfWeekTwo" },
                values: new object[] { 1, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 4,
                columns: new[] { "DayOfWeekFive", "DayOfWeekFour", "DayOfWeekOne", "DayOfWeekSeven", "DayOfWeekSix", "DayOfWeekThree", "DayOfWeekTwo" },
                values: new object[] { 1, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 5,
                columns: new[] { "DayOfWeekFive", "DayOfWeekFour", "DayOfWeekOne", "DayOfWeekSeven", "DayOfWeekSix", "DayOfWeekThree", "DayOfWeekTwo" },
                values: new object[] { 1, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 6,
                columns: new[] { "DayOfWeekFive", "DayOfWeekFour", "DayOfWeekOne", "DayOfWeekSeven", "DayOfWeekSix", "DayOfWeekThree", "DayOfWeekTwo" },
                values: new object[] { 1, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 7,
                columns: new[] { "DayOfWeekFive", "DayOfWeekFour", "DayOfWeekOne", "DayOfWeekSeven", "DayOfWeekSix", "DayOfWeekThree", "DayOfWeekTwo" },
                values: new object[] { 1, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 8,
                columns: new[] { "DayOfWeekFive", "DayOfWeekFour", "DayOfWeekOne", "DayOfWeekSeven", "DayOfWeekSix", "DayOfWeekThree", "DayOfWeekTwo" },
                values: new object[] { 1, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 9,
                columns: new[] { "DayOfWeekFive", "DayOfWeekFour", "DayOfWeekOne", "DayOfWeekSeven", "DayOfWeekSix", "DayOfWeekThree", "DayOfWeekTwo" },
                values: new object[] { 1, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 10,
                columns: new[] { "DayOfWeekFive", "DayOfWeekFour", "DayOfWeekOne", "DayOfWeekSeven", "DayOfWeekSix", "DayOfWeekThree", "DayOfWeekTwo" },
                values: new object[] { 1, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 11,
                columns: new[] { "DayOfWeekFive", "DayOfWeekFour", "DayOfWeekOne", "DayOfWeekSeven", "DayOfWeekSix", "DayOfWeekThree", "DayOfWeekTwo", "DaysId" },
                values: new object[] { 1, 1, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 1, 21, 810, DateTimeKind.Local).AddTicks(4366), new DateTime(2020, 5, 31, 21, 1, 21, 807, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 1, 21, 810, DateTimeKind.Local).AddTicks(6094), new DateTime(2020, 5, 31, 21, 1, 21, 810, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 1, 21, 810, DateTimeKind.Local).AddTicks(6151), new DateTime(2020, 5, 31, 21, 1, 21, 810, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 1, 21, 810, DateTimeKind.Local).AddTicks(6180), new DateTime(2020, 5, 31, 21, 1, 21, 810, DateTimeKind.Local).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 1, 21, 810, DateTimeKind.Local).AddTicks(6210), new DateTime(2020, 5, 31, 21, 1, 21, 810, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 1, 21, 810, DateTimeKind.Local).AddTicks(6257), new DateTime(2020, 5, 31, 21, 1, 21, 810, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 1, 21, 810, DateTimeKind.Local).AddTicks(6287), new DateTime(2020, 5, 31, 21, 1, 21, 810, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 1, 21, 810, DateTimeKind.Local).AddTicks(6317), new DateTime(2020, 5, 31, 21, 1, 21, 810, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 1, 21, 810, DateTimeKind.Local).AddTicks(6346), new DateTime(2020, 5, 31, 21, 1, 21, 810, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 1, 21, 810, DateTimeKind.Local).AddTicks(6376), new DateTime(2020, 5, 31, 21, 1, 21, 810, DateTimeKind.Local).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 5, 31, 23, 1, 21, 810, DateTimeKind.Local).AddTicks(6405), new DateTime(2020, 5, 31, 21, 1, 21, 810, DateTimeKind.Local).AddTicks(6401) });
        }
    }
}
