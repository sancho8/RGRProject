using Microsoft.EntityFrameworkCore.Migrations;

namespace RGRProject.Migrations
{
    public partial class ApiWithDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlaceID",
                table: "Bookings",
                newName: "PlaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlaceId",
                table: "Bookings",
                newName: "PlaceID");
        }
    }
}
