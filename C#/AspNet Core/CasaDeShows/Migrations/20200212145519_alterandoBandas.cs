using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CasaDeShows.Migrations
{
    public partial class alterandoBandas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Preco = table.Column<double>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    LocalId = table.Column<int>(nullable: true),
                    BandaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "casasDeShow",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Capacidade = table.Column<int>(nullable: false),
                    IngressosDisp = table.Column<int>(nullable: false),
                    Local = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    EventosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_casasDeShow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_casasDeShow_Eventos_EventosId",
                        column: x => x.EventosId,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CasasDeShowId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_casasDeShow_CasasDeShowId",
                        column: x => x.CasasDeShowId,
                        principalTable: "casasDeShow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingressos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PrecoId = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    LocalId = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingressos", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Bandas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Estilo = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    CasasDeShowId = table.Column<int>(nullable: true),
                    IngressosId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bandas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bandas_casasDeShow_CasasDeShowId",
                        column: x => x.CasasDeShowId,
                        principalTable: "casasDeShow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bandas_Ingressos_IngressosId",
                        column: x => x.IngressosId,
                        principalTable: "Ingressos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bandas_CasasDeShowId",
                table: "Bandas",
                column: "CasasDeShowId");

            migrationBuilder.CreateIndex(
                name: "IX_Bandas_IngressosId",
                table: "Bandas",
                column: "IngressosId");

            migrationBuilder.CreateIndex(
                name: "IX_casasDeShow_EventosId",
                table: "casasDeShow",
                column: "EventosId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_BandaId",
                table: "Eventos",
                column: "BandaId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_LocalId",
                table: "Eventos",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_CasasDeShowId",
                table: "Historicos",
                column: "CasasDeShowId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingressos_LocalId",
                table: "Ingressos",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingressos_PrecoId",
                table: "Ingressos",
                column: "PrecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_casasDeShow_LocalId",
                table: "Eventos",
                column: "LocalId",
                principalTable: "casasDeShow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Bandas_BandaId",
                table: "Eventos",
                column: "BandaId",
                principalTable: "Bandas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bandas_casasDeShow_CasasDeShowId",
                table: "Bandas");

            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_casasDeShow_LocalId",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingressos_casasDeShow_LocalId",
                table: "Ingressos");

            migrationBuilder.DropForeignKey(
                name: "FK_Bandas_Ingressos_IngressosId",
                table: "Bandas");

            migrationBuilder.DropTable(
                name: "Historicos");

            migrationBuilder.DropTable(
                name: "casasDeShow");

            migrationBuilder.DropTable(
                name: "Ingressos");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Bandas");
        }
    }
}
