using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenParcial2_Gino_Higuera.Migrations
{
    /// <inheritdoc />
    public partial class cambiodetablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 10, 18, 13, 10, 23, 807, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 10, 19, 13, 10, 23, 807, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 10, 20, 13, 10, 23, 807, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 10, 21, 13, 10, 23, 807, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 10, 22, 13, 10, 23, 807, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2025, 10, 23, 13, 10, 23, 807, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2025, 10, 24, 13, 10, 23, 807, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2025, 10, 25, 13, 10, 23, 807, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2025, 10, 26, 13, 10, 23, 807, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2025, 10, 27, 13, 10, 23, 807, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Doctores",
                keyColumn: "DoctorId",
                keyValue: 1,
                column: "Nombre",
                value: "Dr. Vallarta");

            migrationBuilder.UpdateData(
                table: "Doctores",
                keyColumn: "DoctorId",
                keyValue: 2,
                column: "Nombre",
                value: "Dr. Escamilla");

            migrationBuilder.UpdateData(
                table: "Doctores",
                keyColumn: "DoctorId",
                keyValue: 3,
                column: "Nombre",
                value: "Dr. Polopolo");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Higuera", "Gino" });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Garcia", "Efrain" });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Montes de Oca", "Luis" });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 4,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Gomez", "An" });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 5,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Leal", "Raul" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 10, 16, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 10, 17, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 10, 18, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 10, 19, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 10, 20, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2025, 10, 21, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2025, 10, 22, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2025, 10, 23, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2025, 10, 24, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2025, 10, 25, 11, 42, 40, 767, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Doctores",
                keyColumn: "DoctorId",
                keyValue: 1,
                column: "Nombre",
                value: "Dr. Smith");

            migrationBuilder.UpdateData(
                table: "Doctores",
                keyColumn: "DoctorId",
                keyValue: 2,
                column: "Nombre",
                value: "Dr. Johnson");

            migrationBuilder.UpdateData(
                table: "Doctores",
                keyColumn: "DoctorId",
                keyValue: 3,
                column: "Nombre",
                value: "Dr. Brown");

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Perez", "Juan" });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Lopez", "Maria" });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Sanchez", "Carlos" });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 4,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Martinez", "Ana" });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 5,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Gomez", "Luis" });
        }
    }
}
