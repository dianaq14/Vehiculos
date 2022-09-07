using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VehiculosTransporte.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Licencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conductor_CiudadResidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiudadResidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailTrabajo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoRepuesto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<double>(type: "float", nullable: true),
                    FechaCompra = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Justificación = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelEstudios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    placa = table.Column<int>(type: "int", nullable: true),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modelo_año = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapacidadPasajeros = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaisOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dueñoid = table.Column<int>(type: "int", nullable: true),
                    Mecanicoid = table.Column<int>(type: "int", nullable: true),
                    Conductorid = table.Column<int>(type: "int", nullable: true),
                    cilindraje_motor = table.Column<int>(type: "int", nullable: true),
                    NivelAceite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevisionTecnicoMecanica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelLiquidoFrenos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelRefrigerante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelLiquidoDireccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    seguro_contractual = table.Column<DateTime>(type: "datetime2", nullable: true),
                    seguro_extracontractual = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_Conductorid",
                        column: x => x.Conductorid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_Dueñoid",
                        column: x => x.Dueñoid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_Mecanicoid",
                        column: x => x.Mecanicoid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Conductorid",
                table: "Personas",
                column: "Conductorid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Dueñoid",
                table: "Personas",
                column: "Dueñoid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Mecanicoid",
                table: "Personas",
                column: "Mecanicoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
