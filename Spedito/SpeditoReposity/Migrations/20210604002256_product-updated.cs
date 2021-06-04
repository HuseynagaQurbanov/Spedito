using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeditoReposity.Migrations
{
    public partial class productupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDealOfWeek",
                table: "Products",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDealOfWeek",
                table: "Products");
        }
    }
}
