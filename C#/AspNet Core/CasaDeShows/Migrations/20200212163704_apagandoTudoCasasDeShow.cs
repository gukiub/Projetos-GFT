using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CasaDeShows.Migrations
{
    public partial class apagandoTudoCasasDeShow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_casasDeShow_Bandas_BandasId",
                table: "casasDeShow");

            migrationBuilder.DropForeignKey(
                name: "FK_casasDeShow_Eventos_EventosId",
                table: "casasDeShow");

            migrationBuilder.DropForeignKey(
                name: "FK_casasDeShow_Historicos_HistoricoId",
                table: "casasDeShow");

            migrationBuilder.DropTable(
                name: "Historicos");

            migrationBuilder.DropTable(
                name: "Ingressos");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Bandas");

            migrationBuilder.DropIndex(
                name: "IX_casasDeShow_BandasId",
                table: "casasDeShow");

            migrationBuilder.DropIndex(
                name: "IX_casasDeShow_EventosId",
                table: "casasDeShow");

            migrationBuilder.DropIndex(
                name: "IX_casasDeShow_HistoricoId",
                table: "casasDeShow");

            migrationBuilder.DropColumn(
                name: "BandasId",
                table: "casasDeShow");

            migrationBuilder.DropColumn(
                name: "EventosId",
                table: "casasDeShow");

            migrationBuilder.DropColumn(
                name: "HistoricoId",
                table: "casasDeShow");

            migrationBuilder.AddColumn<string>(
                name: "Bandas",
                table: "casasDeShow",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bandas",
                table: "casasDeShow");

            migrationBuilder.AddColumn<int>(
                name: "BandasId",
                table: "casasDeShow",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventosId",
                table: "casasDeShow",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HistoricoId",
                table: "casasDeShow",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bandas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Estilo = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bandas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Historicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BandaId = table.Column<int>(type: "int", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LocalId = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Preco = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eventos_Bandas_BandaId",
                        column: x => x.BandaId,
                        principalTable: "Bandas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Eventos_casasDeShow_LocalId",
                        column: x => x.LocalId,
                        principalTable: "casasDeShow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingressos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BandasId = table.Column<int>(type: "int", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LocalId = table.Column<int>(type: "int", nullable: true),
                    PrecoId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingressos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingressos_Bandas_BandasId",
                        column: x => x.BandasId,
                        principalTable: "Bandas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ingressos_casasDeShow_LocalId",
                        column: x => x.LocalId,
                        principalTable: "casasDeShow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ingressos_Eventos_PrecoId",
                        column: x => x.PrecoId,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_casasDeShow_BandasId",
                table: "casasDeShow",
                column: "BandasId");

            migrationBuilder.CreateIndex(
                name: "IX_casasDeShow_EventosId",
                table: "casasDeShow",
                column: "EventosId");

            migrationBuilder.CreateIndex(
                name: "IX_casasDeShow_HistoricoId",
                table: "casasDeShow",
                column: "HistoricoId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_BandaId",
                table: "Eventos",
                column: "BandaId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_LocalId",
                table: "Eventos",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingressos_BandasId",
                table: "Ingressos",
                column: "BandasId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingressos_LocalId",
                table: "Ingressos",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingressos_PrecoId",
                table: "Ingressos",
                column: "PrecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_casasDeShow_Bandas_BandasId",
                table: "casasDeShow",
                column: "BandasId",
                principalTable: "Bandas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_casasDeShow_Eventos_EventosId",
                table: "casasDeShow",
                column: "EventosId",
                principalTable: "Eventos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_casasDeShow_Historicos_HistoricoId",
                table: "casasDeShow",
                column: "HistoricoId",
                principalTable: "Historicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
