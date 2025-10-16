using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamenParcial2_Gino_Higuera.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctores",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Especialidad = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctores", x => x.DoctorId);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Apellido = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteId);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    CitaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: true),
                    PacienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    DoctorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.CitaId);
                    table.ForeignKey(
                        name: "FK_Citas_Doctores_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctores",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citas_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctores",
                columns: new[] { "DoctorId", "Especialidad", "Nombre" },
                values: new object[,]
                {
                    { 1, "Cardiología", "Dr. Smith" },
                    { 2, "Pediatría", "Dr. Johnson" },
                    { 3, "Dermatología", "Dr. Brown" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "PacienteId", "Apellido", "Nombre" },
                values: new object[,]
                {
                    { 1, "Perez", "Juan" },
                    { 2, "Lopez", "Maria" },
                    { 3, "Sanchez", "Carlos" },
                    { 4, "Martinez", "Ana" },
                    { 5, "Gomez", "Luis" }
                });

            migrationBuilder.InsertData(
                table: "Citas",
                columns: new[] { "CitaId", "DoctorId", "Estado", "Fecha", "PacienteId" },
                values: new object[,]
                {
                    { 1, 1, "Pendiente", new DateTime(2025, 10, 16, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(602), 1 },
                    { 2, 1, "Confirmada", new DateTime(2025, 10, 17, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(619), 2 },
                    { 3, 2, "Cancelada", new DateTime(2025, 10, 18, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(621), 3 },
                    { 4, 2, "Pendiente", new DateTime(2025, 10, 19, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(622), 4 },
                    { 5, 3, "Confirmada", new DateTime(2025, 10, 20, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(630), 5 },
                    { 6, 3, "Pendiente", new DateTime(2025, 10, 21, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(631), 1 },
                    { 7, 2, "Confirmada", new DateTime(2025, 10, 22, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(632), 2 },
                    { 8, 1, "Cancelada", new DateTime(2025, 10, 23, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(633), 3 },
                    { 9, 3, "Pendiente", new DateTime(2025, 10, 24, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(635), 4 },
                    { 10, 2, "Confirmada", new DateTime(2025, 10, 25, 10, 56, 44, 313, DateTimeKind.Local).AddTicks(636), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_DoctorId",
                table: "Citas",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_PacienteId",
                table: "Citas",
                column: "PacienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Doctores");

            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
