using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Infrastructure.Migrations
{
    public partial class _2ndCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "Day");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Day",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 48, 53, 412, DateTimeKind.Local).AddTicks(7655), new DateTime(2020, 7, 26, 22, 48, 53, 409, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 48, 53, 412, DateTimeKind.Local).AddTicks(9543), new DateTime(2020, 7, 26, 22, 48, 53, 412, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 48, 53, 412, DateTimeKind.Local).AddTicks(9609), new DateTime(2020, 7, 26, 22, 48, 53, 412, DateTimeKind.Local).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 48, 53, 412, DateTimeKind.Local).AddTicks(9639), new DateTime(2020, 7, 26, 22, 48, 53, 412, DateTimeKind.Local).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 48, 53, 412, DateTimeKind.Local).AddTicks(9668), new DateTime(2020, 7, 26, 22, 48, 53, 412, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 48, 53, 412, DateTimeKind.Local).AddTicks(9698), new DateTime(2020, 7, 26, 22, 48, 53, 412, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 48, 53, 412, DateTimeKind.Local).AddTicks(9727), new DateTime(2020, 7, 26, 22, 48, 53, 412, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 48, 53, 412, DateTimeKind.Local).AddTicks(9755), new DateTime(2020, 7, 26, 22, 48, 53, 412, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 48, 53, 412, DateTimeKind.Local).AddTicks(9782), new DateTime(2020, 7, 26, 22, 48, 53, 412, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 48, 53, 412, DateTimeKind.Local).AddTicks(9811), new DateTime(2020, 7, 26, 22, 48, 53, 412, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 48, 53, 412, DateTimeKind.Local).AddTicks(9839), new DateTime(2020, 7, 26, 22, 48, 53, 412, DateTimeKind.Local).AddTicks(9835) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Day");

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeek",
                table: "Day",
                type: "int",
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
                column: "DayOfWeek",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 15, 24, 911, DateTimeKind.Local).AddTicks(2155), new DateTime(2020, 7, 26, 22, 15, 24, 908, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 15, 24, 911, DateTimeKind.Local).AddTicks(4067), new DateTime(2020, 7, 26, 22, 15, 24, 911, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 15, 24, 911, DateTimeKind.Local).AddTicks(4125), new DateTime(2020, 7, 26, 22, 15, 24, 911, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 15, 24, 911, DateTimeKind.Local).AddTicks(4156), new DateTime(2020, 7, 26, 22, 15, 24, 911, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 15, 24, 911, DateTimeKind.Local).AddTicks(4182), new DateTime(2020, 7, 26, 22, 15, 24, 911, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 15, 24, 911, DateTimeKind.Local).AddTicks(4217), new DateTime(2020, 7, 26, 22, 15, 24, 911, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 15, 24, 911, DateTimeKind.Local).AddTicks(4245), new DateTime(2020, 7, 26, 22, 15, 24, 911, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 15, 24, 911, DateTimeKind.Local).AddTicks(4273), new DateTime(2020, 7, 26, 22, 15, 24, 911, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 15, 24, 911, DateTimeKind.Local).AddTicks(4301), new DateTime(2020, 7, 26, 22, 15, 24, 911, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 15, 24, 911, DateTimeKind.Local).AddTicks(4332), new DateTime(2020, 7, 26, 22, 15, 24, 911, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 7, 27, 0, 15, 24, 911, DateTimeKind.Local).AddTicks(4361), new DateTime(2020, 7, 26, 22, 15, 24, 911, DateTimeKind.Local).AddTicks(4357) });
        }
    }
}
