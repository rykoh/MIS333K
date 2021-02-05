using Microsoft.EntityFrameworkCore.Migrations;

namespace sp20team13finalproject.Migrations
{
    public partial class newModelStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationNotes",
                table: "Reservations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReservationNotes",
                table: "Reservations",
                nullable: true);
        }
    }
}
