using Microsoft.EntityFrameworkCore.Migrations;

namespace sp20team13finalproject.Migrations
{
    public partial class Seats1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatsLeft",
                table: "FlightDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeatsLeft",
                table: "FlightDetails",
                nullable: false,
                defaultValue: 0);
        }
    }
}
