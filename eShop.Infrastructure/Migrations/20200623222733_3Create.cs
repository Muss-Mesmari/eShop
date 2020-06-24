using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Infrastructure.Migrations
{
    public partial class _3Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TicketPrice",
                table: "Ticket",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "TicketId", "Description", "EventId", "TicketName", "TicketPrice", "TotalAvailableTicket" },
                values: new object[,]
                {
                    { 1, "Omnis et enim aperiam inventore", 1, "Ticket One", 50m, 10 },
                    { 24, "Omnis et enim aperiam inventore", 11, "Ticket Three", 150m, 15 },
                    { 23, "Omnis et enim aperiam inventore", 11, "Ticket Two", 100m, 20 },
                    { 22, "Omnis et enim aperiam inventore", 10, "Ticket One", 50m, 10 },
                    { 21, "Omnis et enim aperiam inventore", 10, "Ticket Three", 150m, 15 },
                    { 20, "Omnis et enim aperiam inventore", 9, "Ticket Two", 100m, 20 },
                    { 19, "Omnis et enim aperiam inventore", 9, "Ticket One", 50m, 10 },
                    { 17, "Omnis et enim aperiam inventore", 8, "Ticket Two", 100m, 20 },
                    { 16, "Omnis et enim aperiam inventore", 7, "Ticket One", 50m, 10 },
                    { 15, "Omnis et enim aperiam inventore", 7, "Ticket Three", 150m, 15 },
                    { 14, "Omnis et enim aperiam inventore", 6, "Ticket Two", 100m, 20 },
                    { 13, "Omnis et enim aperiam inventore", 6, "Ticket One", 50m, 10 },
                    { 18, "Omnis et enim aperiam inventore", 8, "Ticket Three", 150m, 15 },
                    { 11, "Omnis et enim aperiam inventore", 5, "Ticket Two", 100m, 20 },
                    { 12, "Omnis et enim aperiam inventore", 5, "Ticket Three", 150m, 15 },
                    { 3, "Omnis et enim aperiam inventore", 1, "Ticket Three", 150m, 15 },
                    { 4, "Omnis et enim aperiam inventore", 2, "Ticket One", 50m, 10 },
                    { 5, "Omnis et enim aperiam inventore", 2, "Ticket Two", 100m, 20 },
                    { 6, "Omnis et enim aperiam inventore", 3, "Ticket Three", 150m, 15 },
                    { 2, "Omnis et enim aperiam inventore", 1, "Ticket Two", 100m, 20 },
                    { 8, "Omnis et enim aperiam inventore", 4, "Ticket Two", 100m, 20 },
                    { 9, "Omnis et enim aperiam inventore", 4, "Ticket Three", 150m, 15 },
                    { 10, "Omnis et enim aperiam inventore", 5, "Ticket One", 50m, 10 },
                    { 7, "Omnis et enim aperiam inventore", 3, "Ticket One", 50m, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 27, 33, 138, DateTimeKind.Local).AddTicks(9312), new DateTime(2020, 6, 24, 0, 27, 33, 135, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 27, 33, 139, DateTimeKind.Local).AddTicks(1321), new DateTime(2020, 6, 24, 0, 27, 33, 139, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 27, 33, 139, DateTimeKind.Local).AddTicks(1380), new DateTime(2020, 6, 24, 0, 27, 33, 139, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 27, 33, 139, DateTimeKind.Local).AddTicks(1412), new DateTime(2020, 6, 24, 0, 27, 33, 139, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 27, 33, 139, DateTimeKind.Local).AddTicks(1442), new DateTime(2020, 6, 24, 0, 27, 33, 139, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 6,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 27, 33, 139, DateTimeKind.Local).AddTicks(1477), new DateTime(2020, 6, 24, 0, 27, 33, 139, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 7,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 27, 33, 139, DateTimeKind.Local).AddTicks(1507), new DateTime(2020, 6, 24, 0, 27, 33, 139, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 8,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 27, 33, 139, DateTimeKind.Local).AddTicks(1536), new DateTime(2020, 6, 24, 0, 27, 33, 139, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 9,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 27, 33, 139, DateTimeKind.Local).AddTicks(1565), new DateTime(2020, 6, 24, 0, 27, 33, 139, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 10,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 27, 33, 139, DateTimeKind.Local).AddTicks(1597), new DateTime(2020, 6, 24, 0, 27, 33, 139, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "TimesId",
                keyValue: 11,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2020, 6, 24, 2, 27, 33, 139, DateTimeKind.Local).AddTicks(1626), new DateTime(2020, 6, 24, 0, 27, 33, 139, DateTimeKind.Local).AddTicks(1622) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 24);

            migrationBuilder.AlterColumn<string>(
                name: "TicketPrice",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal));

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
        }
    }
}
