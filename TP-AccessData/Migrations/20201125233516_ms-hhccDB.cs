using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TP_AccessData.Migrations
{
    public partial class mshhccDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoriaClinica",
                columns: table => new
                {
                    HistoriaClinicaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaClinica", x => x.HistoriaClinicaId);
                });

            migrationBuilder.CreateTable(
                name: "Registro",
                columns: table => new
                {
                    RegistroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotivoConsulta = table.Column<string>(nullable: true),
                    Diagnostico = table.Column<string>(nullable: true),
                    ProximaRevision = table.Column<DateTime>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    EspecialistaId = table.Column<int>(nullable: false),
                    HistoriaClinicaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro", x => x.RegistroId);
                    table.ForeignKey(
                        name: "FK_Registro_HistoriaClinica_HistoriaClinicaId",
                        column: x => x.HistoriaClinicaId,
                        principalTable: "HistoriaClinica",
                        principalColumn: "HistoriaClinicaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Analisis",
                columns: table => new
                {
                    AnalisisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionAnalisis = table.Column<string>(nullable: true),
                    RegistroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analisis", x => x.AnalisisId);
                    table.ForeignKey(
                        name: "FK_Analisis_Registro_RegistroId",
                        column: x => x.RegistroId,
                        principalTable: "Registro",
                        principalColumn: "RegistroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receta",
                columns: table => new
                {
                    RecetaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionReceta = table.Column<string>(nullable: true),
                    RegistroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receta", x => x.RecetaId);
                    table.ForeignKey(
                        name: "FK_Receta_Registro_RegistroId",
                        column: x => x.RegistroId,
                        principalTable: "Registro",
                        principalColumn: "RegistroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analisis_RegistroId",
                table: "Analisis",
                column: "RegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Receta_RegistroId",
                table: "Receta",
                column: "RegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Registro_HistoriaClinicaId",
                table: "Registro",
                column: "HistoriaClinicaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Analisis");

            migrationBuilder.DropTable(
                name: "Receta");

            migrationBuilder.DropTable(
                name: "Registro");

            migrationBuilder.DropTable(
                name: "HistoriaClinica");
        }
    }
}
