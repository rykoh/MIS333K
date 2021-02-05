using Microsoft.EntityFrameworkCore.Migrations;

namespace sp20team13finalproject.Migrations
{
    public partial class SeatsLeft : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatsLeft",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "SeatsLeft",
                table: "FlightDetails",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatsLeft",
                table: "FlightDetails");

            migrationBuilder.AddColumn<int>(
                name: "SeatsLeft",
                table: "Tickets",
                nullable: false,
                defaultValue: 0);
        }
    }
}
