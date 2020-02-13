using Microsoft.EntityFrameworkCore.Migrations;

namespace CasaDeShows.Migrations
{
    public partial class CasasDeShowSeila : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StatusString",
                table: "casasDeShow",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusString",
                table: "casasDeShow");
        }
    }
}
