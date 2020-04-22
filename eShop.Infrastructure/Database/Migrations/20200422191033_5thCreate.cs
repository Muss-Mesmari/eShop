using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Infrastructure.Database.Migrations
{
    public partial class _5thCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderTotal",
                table: "Orders");

            migrationBuilder.AddColumn<decimal>(
                name: "OrderTotalEUR",
                table: "Orders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OrderTotalSEK",
                table: "Orders",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderTotalEUR",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderTotalSEK",
                table: "Orders");

            migrationBuilder.AddColumn<decimal>(
                name: "OrderTotal",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
