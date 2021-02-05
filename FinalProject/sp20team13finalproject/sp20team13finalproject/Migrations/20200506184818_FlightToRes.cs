using Microsoft.EntityFrameworkCore.Migrations;

namespace sp20team13finalproject.Migrations
{
    public partial class FlightToRes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FlightDetailID",
                table: "Reservations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_FlightDetailID",
                table: "Reservations",
                column: "FlightDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_FlightDetails_FlightDetailID",
                table: "Reservations",
                column: "FlightDetailID",
                principalTable: "FlightDetails",
                principalColumn: "FlightDetailID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_FlightDetails_FlightDetailID",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_FlightDetailID",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "FlightDetailID",
                table: "Reservations");
        }
    }
}
