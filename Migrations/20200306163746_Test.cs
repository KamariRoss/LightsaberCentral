using Microsoft.EntityFrameworkCore.Migrations;

namespace LightsaberCentral.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Sabers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Sabers",
                type: "integer",
                nullable: true);
        }
    }
}
