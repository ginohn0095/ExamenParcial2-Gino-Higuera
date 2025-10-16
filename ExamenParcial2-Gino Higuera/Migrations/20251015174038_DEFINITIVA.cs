using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenParcial2_Gino_Higuera.Migrations
{
    /// <inheritdoc />
    public partial class DEFINITIVA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 10, 16, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 10, 17, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 10, 18, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 10, 19, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 10, 20, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2025, 10, 21, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2025, 10, 22, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2025, 10, 23, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2025, 10, 24, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2025, 10, 25, 11, 40, 38, 460, DateTimeKind.Local).AddTicks(2011));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 10, 16, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 10, 17, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 10, 18, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2025, 10, 19, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2025, 10, 20, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 6,
                column: "Fecha",
                value: new DateTime(2025, 10, 21, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 7,
                column: "Fecha",
                value: new DateTime(2025, 10, 22, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 8,
                column: "Fecha",
                value: new DateTime(2025, 10, 23, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 9,
                column: "Fecha",
                value: new DateTime(2025, 10, 24, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 10,
                column: "Fecha",
                value: new DateTime(2025, 10, 25, 11, 26, 39, 869, DateTimeKind.Local).AddTicks(1907));
        }
    }
}
