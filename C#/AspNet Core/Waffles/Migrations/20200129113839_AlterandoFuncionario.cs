using Microsoft.EntityFrameworkCore.Migrations;

namespace Waffles.Migrations
{
    public partial class AlterandoFuncionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cpf",
                table: "Funcionarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cpf",
                table: "Funcionarios");
        }
    }
}
