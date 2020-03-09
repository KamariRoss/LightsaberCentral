using Microsoft.EntityFrameworkCore.Migrations;

namespace LightsaberCentral.Migrations
{
    public partial class AddedTableSaberLocationDBset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaberLocation_Locations_LocationId",
                table: "SaberLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_SaberLocation_Sabers_SaberId",
                table: "SaberLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaberLocation",
                table: "SaberLocation");

            migrationBuilder.RenameTable(
                name: "SaberLocation",
                newName: "SaberLocations");

            migrationBuilder.RenameIndex(
                name: "IX_SaberLocation_SaberId",
                table: "SaberLocations",
                newName: "IX_SaberLocations_SaberId");

            migrationBuilder.RenameIndex(
                name: "IX_SaberLocation_LocationId",
                table: "SaberLocations",
                newName: "IX_SaberLocations_LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaberLocations",
                table: "SaberLocations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaberLocations_Locations_LocationId",
                table: "SaberLocations",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaberLocations_Sabers_SaberId",
                table: "SaberLocations",
                column: "SaberId",
                principalTable: "Sabers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaberLocations_Locations_LocationId",
                table: "SaberLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_SaberLocations_Sabers_SaberId",
                table: "SaberLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaberLocations",
                table: "SaberLocations");

            migrationBuilder.RenameTable(
                name: "SaberLocations",
                newName: "SaberLocation");

            migrationBuilder.RenameIndex(
                name: "IX_SaberLocations_SaberId",
                table: "SaberLocation",
                newName: "IX_SaberLocation_SaberId");

            migrationBuilder.RenameIndex(
                name: "IX_SaberLocations_LocationId",
                table: "SaberLocation",
                newName: "IX_SaberLocation_LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaberLocation",
                table: "SaberLocation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaberLocation_Locations_LocationId",
                table: "SaberLocation",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaberLocation_Sabers_SaberId",
                table: "SaberLocation",
                column: "SaberId",
                principalTable: "Sabers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
