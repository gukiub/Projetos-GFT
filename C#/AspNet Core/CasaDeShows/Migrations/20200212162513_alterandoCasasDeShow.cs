using Microsoft.EntityFrameworkCore.Migrations;

namespace CasaDeShows.Migrations
{
    public partial class alterandoCasasDeShow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bandas_casasDeShow_CasasDeShowId",
                table: "Bandas");

            migrationBuilder.DropForeignKey(
                name: "FK_Bandas_Ingressos_IngressosId",
                table: "Bandas");

            migrationBuilder.DropForeignKey(
                name: "FK_Historicos_casasDeShow_CasasDeShowId",
                table: "Historicos");

            migrationBuilder.DropIndex(
                name: "IX_Historicos_CasasDeShowId",
                table: "Historicos");

            migrationBuilder.DropIndex(
                name: "IX_Bandas_CasasDeShowId",
                table: "Bandas");

            migrationBuilder.DropIndex(
                name: "IX_Bandas_IngressosId",
                table: "Bandas");

            migrationBuilder.DropColumn(
                name: "CasasDeShowId",
                table: "Historicos");

            migrationBuilder.DropColumn(
                name: "CasasDeShowId",
                table: "Bandas");

            migrationBuilder.DropColumn(
                name: "IngressosId",
                table: "Bandas");

            migrationBuilder.AddColumn<int>(
                name: "BandasId",
                table: "Ingressos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BandasId",
                table: "casasDeShow",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HistoricoId",
                table: "casasDeShow",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingressos_BandasId",
                table: "Ingressos",
                column: "BandasId");

            migrationBuilder.CreateIndex(
                name: "IX_casasDeShow_BandasId",
                table: "casasDeShow",
                column: "BandasId");

            migrationBuilder.CreateIndex(
                name: "IX_casasDeShow_HistoricoId",
                table: "casasDeShow",
                column: "HistoricoId");

            migrationBuilder.AddForeignKey(
                name: "FK_casasDeShow_Bandas_BandasId",
                table: "casasDeShow",
                column: "BandasId",
                principalTable: "Bandas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_casasDeShow_Historicos_HistoricoId",
                table: "casasDeShow",
                column: "HistoricoId",
                principalTable: "Historicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingressos_Bandas_BandasId",
                table: "Ingressos",
                column: "BandasId",
                principalTable: "Bandas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_casasDeShow_Bandas_BandasId",
                table: "casasDeShow");

            migrationBuilder.DropForeignKey(
                name: "FK_casasDeShow_Historicos_HistoricoId",
                table: "casasDeShow");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingressos_Bandas_BandasId",
                table: "Ingressos");

            migrationBuilder.DropIndex(
                name: "IX_Ingressos_BandasId",
                table: "Ingressos");

            migrationBuilder.DropIndex(
                name: "IX_casasDeShow_BandasId",
                table: "casasDeShow");

            migrationBuilder.DropIndex(
                name: "IX_casasDeShow_HistoricoId",
                table: "casasDeShow");

            migrationBuilder.DropColumn(
                name: "BandasId",
                table: "Ingressos");

            migrationBuilder.DropColumn(
                name: "BandasId",
                table: "casasDeShow");

            migrationBuilder.DropColumn(
                name: "HistoricoId",
                table: "casasDeShow");

            migrationBuilder.AddColumn<int>(
                name: "CasasDeShowId",
                table: "Historicos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CasasDeShowId",
                table: "Bandas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IngressosId",
                table: "Bandas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_CasasDeShowId",
                table: "Historicos",
                column: "CasasDeShowId");

            migrationBuilder.CreateIndex(
                name: "IX_Bandas_CasasDeShowId",
                table: "Bandas",
                column: "CasasDeShowId");

            migrationBuilder.CreateIndex(
                name: "IX_Bandas_IngressosId",
                table: "Bandas",
                column: "IngressosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bandas_casasDeShow_CasasDeShowId",
                table: "Bandas",
                column: "CasasDeShowId",
                principalTable: "casasDeShow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bandas_Ingressos_IngressosId",
                table: "Bandas",
                column: "IngressosId",
                principalTable: "Ingressos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Historicos_casasDeShow_CasasDeShowId",
                table: "Historicos",
                column: "CasasDeShowId",
                principalTable: "casasDeShow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
