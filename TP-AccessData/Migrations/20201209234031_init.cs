using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TP_AccessData.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoriaClinica",
                columns: table => new
                {
                    HistoriaClinicaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(nullable: false),
                    RegistroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaClinica", x => x.HistoriaClinicaId);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    RegistroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EspecialistaId = table.Column<int>(nullable: false),
                    MotivoConsulta = table.Column<string>(nullable: true),
                    ProximaRevision = table.Column<DateTime>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    Diagnostico = table.Column<string>(nullable: true),
                    Analisis = table.Column<string>(nullable: true),
                    Receta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.RegistroId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoriaClinica");

            migrationBuilder.DropTable(
                name: "Registros");
        }
    }
}
