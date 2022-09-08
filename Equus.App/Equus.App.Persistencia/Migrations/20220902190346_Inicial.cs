using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Equus.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalId = table.Column<int>(type: "int", nullable: true),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoriasClinicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperatura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    FrecuenciaRespiratoria = table.Column<float>(type: "real", nullable: false),
                    FrecuenciaCardiaca = table.Column<float>(type: "real", nullable: false),
                    EstadoAnimo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaVisita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Recomendacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VeterinarioDesignadoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasClinicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoriasClinicas_Personas_VeterinarioDesignadoId",
                        column: x => x.VeterinarioDesignadoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Animales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Historia_ClinicaId = table.Column<int>(type: "int", nullable: true),
                    VeterinarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animales_HistoriasClinicas_Historia_ClinicaId",
                        column: x => x.Historia_ClinicaId,
                        principalTable: "HistoriasClinicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Animales_Personas_VeterinarioId",
                        column: x => x.VeterinarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animales_Historia_ClinicaId",
                table: "Animales",
                column: "Historia_ClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Animales_VeterinarioId",
                table: "Animales",
                column: "VeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriasClinicas_VeterinarioDesignadoId",
                table: "HistoriasClinicas",
                column: "VeterinarioDesignadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_AnimalId",
                table: "Personas",
                column: "AnimalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Animales_AnimalId",
                table: "Personas",
                column: "AnimalId",
                principalTable: "Animales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animales_HistoriasClinicas_Historia_ClinicaId",
                table: "Animales");

            migrationBuilder.DropForeignKey(
                name: "FK_Animales_Personas_VeterinarioId",
                table: "Animales");

            migrationBuilder.DropTable(
                name: "HistoriasClinicas");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Animales");
        }
    }
}
