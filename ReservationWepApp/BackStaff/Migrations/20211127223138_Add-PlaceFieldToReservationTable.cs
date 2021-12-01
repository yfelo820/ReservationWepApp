using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservationWepApp.Migrations
{
    public partial class AddPlaceFieldToReservationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Place",
                table: "Reservations");
        }
    }
}
