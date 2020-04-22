using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Infrastructure.Database.Migrations
{
    public partial class _4thCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Currency",
                table: "Events",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Events");
        }
    }
}
