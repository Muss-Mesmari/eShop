using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Infrastructure.Migrations
{
    public partial class _3rdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Day_Days_DaysId",
                table: "Day");

            migrationBuilder.DropIndex(
                name: "IX_Day_DaysId",
                table: "Day");

            migrationBuilder.DropColumn(
                name: "DaysId",
                table: "Day");

            migrationBuilder.AddColumn<int>(
                name: "DayId",
                table: "Days",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "DaysId",
                keyValue: 1,
                column: "DayId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "DaysId",
                keyValue: 2,
                column: "DayId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "DaysId",
                keyValue: 3,
                column: "DayId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "DaysId",
                keyValue: 4,
                column: "DayId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "DaysId",
                keyValue: 5,
                column: "DayId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "DaysId",
                keyValue: 6,
                column: "DayId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "DaysId",
                keyValue: 7,
                column: "DayId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "DaysId",
                keyValue: 8,
                column: "DayId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "DaysId",
                keyValue: 9,
                column: "DayId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "DaysId",
                keyValue: 10,
                column: "DayId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Days",
                keyColumn: "DaysId",
                keyValue: 11,
                column: "DayId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 50, 44, 854, DateTimeKind.Local).AddTicks(9961), new DateTime(2020, 5, 31, 22, 50, 44, 852, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 50, 44, 855, DateTimeKind.Local).AddTicks(1653), new DateTime(2020, 5, 31, 22, 50, 44, 855, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 50, 44, 855, DateTimeKind.Local).AddTicks(1710), new DateTime(2020, 5, 31, 22, 50, 44, 855, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 50, 44, 855, DateTimeKind.Local).AddTicks(1740), new DateTime(2020, 5, 31, 22, 50, 44, 855, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 50, 44, 855, DateTimeKind.Local).AddTicks(1768), new DateTime(2020, 5, 31, 22, 50, 44, 855, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 50, 44, 855, DateTimeKind.Local).AddTicks(1801), new DateTime(2020, 5, 31, 22, 50, 44, 855, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 50, 44, 855, DateTimeKind.Local).AddTicks(1829), new DateTime(2020, 5, 31, 22, 50, 44, 855, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 50, 44, 855, DateTimeKind.Local).AddTicks(1857), new DateTime(2020, 5, 31, 22, 50, 44, 855, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 50, 44, 855, DateTimeKind.Local).AddTicks(1885), new DateTime(2020, 5, 31, 22, 50, 44, 855, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 50, 44, 855, DateTimeKind.Local).AddTicks(1914), new DateTime(2020, 5, 31, 22, 50, 44, 855, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 0, 50, 44, 855, DateTimeKind.Local).AddTicks(1942), new DateTime(2020, 5, 31, 22, 50, 44, 855, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.CreateIndex(
                name: "IX_Days_DayId",
                table: "Days",
                column: "DayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Days_Day_DayId",
                table: "Days",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "DayId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Days_Day_DayId",
                table: "Days");

            migrationBuilder.DropIndex(
                name: "IX_Days_DayId",
                table: "Days");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "Days");

            migrationBuilder.AddColumn<int>(
                name: "DaysId",
                table: "Day",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 1,
                column: "DaysId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 2,
                column: "DaysId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 3,
                column: "DaysId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 4,
                column: "DaysId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 5,
                column: "DaysId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 6,
                column: "DaysId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 7,
                column: "DaysId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 8,
                column: "DaysId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 9,
                column: "DaysId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 10,
                column: "DaysId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 11,
                column: "DaysId",
                value: 11);

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

            migrationBuilder.CreateIndex(
                name: "IX_Day_DaysId",
                table: "Day",
                column: "DaysId");

            migrationBuilder.AddForeignKey(
                name: "FK_Day_Days_DaysId",
                table: "Day",
                column: "DaysId",
                principalTable: "Days",
                principalColumn: "DaysId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
