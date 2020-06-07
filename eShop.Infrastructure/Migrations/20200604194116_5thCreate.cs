using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Infrastructure.Migrations
{
    public partial class _5thCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Day_Days_DaysId",
                table: "Day");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropIndex(
                name: "IX_Day_DaysId",
                table: "Day");

            migrationBuilder.DropColumn(
                name: "DaysId",
                table: "Day");

            migrationBuilder.AddColumn<int>(
                name: "WeekId",
                table: "Day",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 4, 23, 41, 15, 711, DateTimeKind.Local).AddTicks(7881), new DateTime(2020, 6, 4, 21, 41, 15, 706, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 4, 23, 41, 15, 712, DateTimeKind.Local).AddTicks(969), new DateTime(2020, 6, 4, 21, 41, 15, 712, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 4, 23, 41, 15, 712, DateTimeKind.Local).AddTicks(1123), new DateTime(2020, 6, 4, 21, 41, 15, 712, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 4, 23, 41, 15, 712, DateTimeKind.Local).AddTicks(1202), new DateTime(2020, 6, 4, 21, 41, 15, 712, DateTimeKind.Local).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 4, 23, 41, 15, 712, DateTimeKind.Local).AddTicks(1276), new DateTime(2020, 6, 4, 21, 41, 15, 712, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 4, 23, 41, 15, 712, DateTimeKind.Local).AddTicks(1331), new DateTime(2020, 6, 4, 21, 41, 15, 712, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 4, 23, 41, 15, 712, DateTimeKind.Local).AddTicks(1394), new DateTime(2020, 6, 4, 21, 41, 15, 712, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 4, 23, 41, 15, 712, DateTimeKind.Local).AddTicks(1477), new DateTime(2020, 6, 4, 21, 41, 15, 712, DateTimeKind.Local).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 4, 23, 41, 15, 712, DateTimeKind.Local).AddTicks(1560), new DateTime(2020, 6, 4, 21, 41, 15, 712, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 4, 23, 41, 15, 712, DateTimeKind.Local).AddTicks(1643), new DateTime(2020, 6, 4, 21, 41, 15, 712, DateTimeKind.Local).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 4, 23, 41, 15, 712, DateTimeKind.Local).AddTicks(1725), new DateTime(2020, 6, 4, 21, 41, 15, 712, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.InsertData(
                table: "Week",
                columns: new[] { "WeekId", "ScheduleId" },
                values: new object[,]
                {
                    { 11, 11 },
                    { 9, 9 },
                    { 8, 8 },
                    { 7, 7 },
                    { 6, 6 },
                    { 5, 5 },
                    { 4, 4 },
                    { 3, 3 },
                    { 2, 2 },
                    { 10, 10 },
                    { 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 1,
                column: "WeekId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 2,
                column: "WeekId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 3,
                column: "WeekId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 4,
                column: "WeekId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 5,
                column: "WeekId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 6,
                column: "WeekId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 7,
                column: "WeekId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 8,
                column: "WeekId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 9,
                column: "WeekId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 10,
                column: "WeekId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Day",
                keyColumn: "DayId",
                keyValue: 11,
                column: "WeekId",
                value: 11);

            migrationBuilder.CreateIndex(
                name: "IX_Day_WeekId",
                table: "Day",
                column: "WeekId");

            migrationBuilder.CreateIndex(
                name: "IX_Week_ScheduleId",
                table: "Week",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Day_Week_WeekId",
                table: "Day",
                column: "WeekId",
                principalTable: "Week",
                principalColumn: "WeekId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Day_Week_WeekId",
                table: "Day");

            migrationBuilder.DropTable(
                name: "Week");

            migrationBuilder.DropIndex(
                name: "IX_Day_WeekId",
                table: "Day");

            migrationBuilder.DropColumn(
                name: "WeekId",
                table: "Day");

            migrationBuilder.AddColumn<int>(
                name: "DaysId",
                table: "Day",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    DaysId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.DaysId);
                    table.ForeignKey(
                        name: "FK_Days_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "ScheduleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "DaysId", "ScheduleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 10, 10 },
                    { 9, 9 },
                    { 8, 8 },
                    { 7, 7 },
                    { 11, 11 },
                    { 5, 5 },
                    { 4, 4 },
                    { 3, 3 },
                    { 2, 2 },
                    { 6, 6 }
                });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 1, 54, 12, 715, DateTimeKind.Local).AddTicks(2528), new DateTime(2020, 5, 31, 23, 54, 12, 712, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 1, 54, 12, 715, DateTimeKind.Local).AddTicks(4246), new DateTime(2020, 5, 31, 23, 54, 12, 715, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 1, 54, 12, 715, DateTimeKind.Local).AddTicks(4308), new DateTime(2020, 5, 31, 23, 54, 12, 715, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 1, 54, 12, 715, DateTimeKind.Local).AddTicks(4340), new DateTime(2020, 5, 31, 23, 54, 12, 715, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 1, 54, 12, 715, DateTimeKind.Local).AddTicks(4371), new DateTime(2020, 5, 31, 23, 54, 12, 715, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 1, 54, 12, 715, DateTimeKind.Local).AddTicks(4405), new DateTime(2020, 5, 31, 23, 54, 12, 715, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 1, 54, 12, 715, DateTimeKind.Local).AddTicks(4435), new DateTime(2020, 5, 31, 23, 54, 12, 715, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 1, 54, 12, 715, DateTimeKind.Local).AddTicks(4465), new DateTime(2020, 5, 31, 23, 54, 12, 715, DateTimeKind.Local).AddTicks(4461) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 1, 54, 12, 715, DateTimeKind.Local).AddTicks(4494), new DateTime(2020, 5, 31, 23, 54, 12, 715, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 1, 54, 12, 715, DateTimeKind.Local).AddTicks(4525), new DateTime(2020, 5, 31, 23, 54, 12, 715, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 1, 1, 54, 12, 715, DateTimeKind.Local).AddTicks(4554), new DateTime(2020, 5, 31, 23, 54, 12, 715, DateTimeKind.Local).AddTicks(4550) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Day_DaysId",
                table: "Day",
                column: "DaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Days_ScheduleId",
                table: "Days",
                column: "ScheduleId");

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
