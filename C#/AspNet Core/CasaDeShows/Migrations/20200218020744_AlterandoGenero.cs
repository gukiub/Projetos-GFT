using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CasaDeShows.Migrations
{
    public partial class AlterandoGenero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Generos_Generoid",
                table: "Eventos");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_Generoid",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "Generoid",
                table: "Eventos");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "Eventos",
                newName: "Data");

            migrationBuilder.AddColumn<int>(
                name: "Genero",
                table: "Eventos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Eventos");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Eventos",
                newName: "data");

            migrationBuilder.AddColumn<int>(
                name: "Generoid",
                table: "Eventos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    imagem = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_Generoid",
                table: "Eventos",
                column: "Generoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Generos_Generoid",
                table: "Eventos",
                column: "Generoid",
                principalTable: "Generos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
