using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Infrastructure.Migrations
{
    public partial class _2Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TicketId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(nullable: false),
                    TicketName = table.Column<string>(nullable: true),
                    TicketPrice = table.Column<string>(nullable: true),
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

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 9, 46, 58, DateTimeKind.Local).AddTicks(2701), new DateTime(2020, 6, 24, 0, 9, 46, 55, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 9, 46, 58, DateTimeKind.Local).AddTicks(5994), new DateTime(2020, 6, 24, 0, 9, 46, 58, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 9, 46, 58, DateTimeKind.Local).AddTicks(6167), new DateTime(2020, 6, 24, 0, 9, 46, 58, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 9, 46, 58, DateTimeKind.Local).AddTicks(6276), new DateTime(2020, 6, 24, 0, 9, 46, 58, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 9, 46, 58, DateTimeKind.Local).AddTicks(6383), new DateTime(2020, 6, 24, 0, 9, 46, 58, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 9, 46, 58, DateTimeKind.Local).AddTicks(6492), new DateTime(2020, 6, 24, 0, 9, 46, 58, DateTimeKind.Local).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 9, 46, 58, DateTimeKind.Local).AddTicks(6585), new DateTime(2020, 6, 24, 0, 9, 46, 58, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 9, 46, 58, DateTimeKind.Local).AddTicks(6689), new DateTime(2020, 6, 24, 0, 9, 46, 58, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 9, 46, 58, DateTimeKind.Local).AddTicks(6792), new DateTime(2020, 6, 24, 0, 9, 46, 58, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 9, 46, 58, DateTimeKind.Local).AddTicks(6995), new DateTime(2020, 6, 24, 0, 9, 46, 58, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 9, 46, 58, DateTimeKind.Local).AddTicks(7095), new DateTime(2020, 6, 24, 0, 9, 46, 58, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_EventId",
                table: "Ticket",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 21, 23, 2, 11, 534, DateTimeKind.Local).AddTicks(765), new DateTime(2020, 6, 21, 21, 2, 11, 527, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 21, 23, 2, 11, 534, DateTimeKind.Local).AddTicks(2626), new DateTime(2020, 6, 21, 21, 2, 11, 534, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 21, 23, 2, 11, 534, DateTimeKind.Local).AddTicks(2687), new DateTime(2020, 6, 21, 21, 2, 11, 534, DateTimeKind.Local).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 21, 23, 2, 11, 534, DateTimeKind.Local).AddTicks(2719), new DateTime(2020, 6, 21, 21, 2, 11, 534, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 21, 23, 2, 11, 534, DateTimeKind.Local).AddTicks(2750), new DateTime(2020, 6, 21, 21, 2, 11, 534, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 21, 23, 2, 11, 534, DateTimeKind.Local).AddTicks(2784), new DateTime(2020, 6, 21, 21, 2, 11, 534, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 21, 23, 2, 11, 534, DateTimeKind.Local).AddTicks(2812), new DateTime(2020, 6, 21, 21, 2, 11, 534, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 21, 23, 2, 11, 534, DateTimeKind.Local).AddTicks(2842), new DateTime(2020, 6, 21, 21, 2, 11, 534, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 21, 23, 2, 11, 534, DateTimeKind.Local).AddTicks(2871), new DateTime(2020, 6, 21, 21, 2, 11, 534, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 21, 23, 2, 11, 534, DateTimeKind.Local).AddTicks(2903), new DateTime(2020, 6, 21, 21, 2, 11, 534, DateTimeKind.Local).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 21, 23, 2, 11, 534, DateTimeKind.Local).AddTicks(2931), new DateTime(2020, 6, 21, 21, 2, 11, 534, DateTimeKind.Local).AddTicks(2927) });
        }
    }
}
